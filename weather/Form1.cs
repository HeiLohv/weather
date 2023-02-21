using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.IO;


namespace weather
{
    public partial class Form1 : Form
    {
        string apiKey = "168d1666fa09c5fdf5a98128f6ad20a4";

        string file;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            file = "../../places.txt";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelWeather_Click(object sender, EventArgs e)
        {

        }

        double lon;
        double lat;

        void showLabels()
        {
            //Skapar en lista
            var labels = new List<Label> { labelWeather, labelDescription, labelSunrise, labelSunset, labelHumidity, labelPressure, labelWindSpeed, labelTemperature, labelMinTemp, labelMaxTemp, labelFeelsLike, labelFeels, labelDateTime, labelDateTimeForecast, labelWeatherForecast, labelTempForecast};

            //Gör kontroller i den synliga
            foreach (var label in labels)
                label.Visible = true;
        }
        void getWeather()
        {

            //Tar fram data om platsen som skrivits i sökfältet
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric", textBoxSearch_TextChanged.Text, apiKey);
                var json = web.DownloadString(url);
                weatherInfo.Root Info = JsonConvert.DeserializeObject<weatherInfo.Root>(json);

                //Sätter in data i kontroller
                pictureBoxIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labelWeather.Text = Info.weather[0].main;
                labelDescription.Text = Info.weather[0].description;

                labelSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();
                labelSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();

                labelHumidity.Text = Info.main.humidity.ToString();
                labelPressure.Text = Info.main.pressure.ToString();

                labelWindSpeed.Text = Info.wind.speed.ToString();

                labelTemperature.Text = Info.main.temp.ToString() + "°C";
                labelMinTemp.Text = Info.main.temp_min.ToString() + "°C";
                labelMaxTemp.Text = Info.main.temp_max.ToString() + "°C";
                labelFeels.Text = Info.main.feels_like.ToString() + "°C";

                labelDateTime.Text = convertDateTime(Info.dt).ToString();

                lon = Info.coord.lon;
                lat = Info.coord.lat;
            }
        }
        DateTime convertDateTime(long sec)
        {
            //Förvandlar till aktuell tid
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();

            return day;
        }


        private void buttonGet_Click(object sender, EventArgs e)
        {
            //Visar upp information om vädret
            try
            {
                getWeather();
                showLabels();
                getForecast();
            }
            //Meddelande visas om sökningen inte fungerat
            catch
            {
                searchError();
            }
        }

        private void textBoxSearch_TextChanged_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Sätter in i listan från sökfältet
            listBoxList.Items.Add(textBoxSearch_TextChanged.Text);
        }

        void showWeather()
        {

            string selected = listBoxList.SelectedItem.ToString();

            using (WebClient web = new WebClient())
            {
                //Tar fram data om vald plats i listan
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric", selected, apiKey);
                var json = web.DownloadString(url);
                weatherInfo.Root Info = JsonConvert.DeserializeObject<weatherInfo.Root>(json);

                //Sätter in data i kontroller
                pictureBoxIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labelWeather.Text = Info.weather[0].main;
                labelDescription.Text = Info.weather[0].description;

                labelSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();
                labelSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();

                labelHumidity.Text = Info.main.humidity.ToString();
                labelPressure.Text = Info.main.pressure.ToString();

                labelWindSpeed.Text = Info.wind.speed.ToString();

                labelTemperature.Text = Info.main.temp.ToString() + "°C";
                labelMinTemp.Text = Info.main.temp_min.ToString() + "°C";
                labelMaxTemp.Text = Info.main.temp_max.ToString() + "°C";
                labelFeels.Text = Info.main.feels_like.ToString() + "°C";

                labelDateTime.Text = convertDateTime(Info.dt).ToString();

            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            //Visar upp information om vädret
            try
            {
                showWeather();
                showLabels();
                getForecast();
            }
            //Meddelande visas om sökningen inte fungerat
            catch
            {
                searchError();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string delete = "Are you sure you want to delete " + listBoxList.SelectedItem + "?";

            //Om listan är tom
            if (listBoxList.Items.Count < 1)
            {
                var listBoxIsEmpty = MessageBox.Show("There are no items to delete.", "Empty list", MessageBoxButtons.OK);
            }
            //Om man inte har valt någon post att radera
            else if (listBoxList.SelectedIndex <= -1)
            {
                var itemNotSelected = MessageBox.Show("You have not selected an item to delete.", "No item selected", MessageBoxButtons.OK);
            }
            else
            {

                //Frågar om man vill radera vald post
                var confirmResult = MessageBox.Show(delete, "Delete item", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    //Tar bort den valda posten
                    listBoxList.Items.Remove(listBoxList.SelectedItem);
                }
                else
                {
                    //Meddelandet stängs   

                }
            };

        }

        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(file))
            {
                StreamReader Textfile = new StreamReader(file);
                string line;

                //Läser av rader
                while ((line = Textfile.ReadLine()) != null)
                {
                    listBoxList.Items.Add(line);
                }
                //Stänger filen
                Textfile.Close();
                
            }
            //Om filen inte hittas
            else
            {   
                MessageBox.Show("File not found", "Error");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Skriver till textfilen med StreamWriter
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (var item in listBoxList.Items)
                {
                    writer.WriteLine(item);
                }
            }
        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }

        private void labelFeelsLike_Click(object sender, EventArgs e)
        {

        }

        private void labelFeels_Click(object sender, EventArgs e)
        {

        }


        void getForecast()
        {
            //Kod som tar fram väderprognosdata om plats
            using (WebClient web = new WebClient())
            {
                int day = 5;
                string url = string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&appid={2}&cnt={3}&units=metric&exclude-current,minutely,hourly", lat, lon, apiKey, day);
                var json = web.DownloadString(url);
                weatherForecast.forecastInfo forecastInfo = JsonConvert.DeserializeObject<weatherForecast.forecastInfo>(json);

                //Sätter in data i kontroller
                //pictureBoxIconForecast.ImageLocation = "https://openweathermap.org/img/w/" + forecastInfo.list[1].weather[0].icon + ".png";
                //labelWeatherForecast.Text = string.Format("{0}", forecastInfo.list[1].weather[0].main);
                //labelDateTimeForecast.Text = string.Format(convertDateTime(forecastInfo.list[1].dt).DayOfWeek.ToString());
                //labelTempForecast.Text = string.Format("{0}", forecastInfo.list[1].temp.ToString() + "°C");

                ForecastUC fuc;

                for (int i = 0; i < 30; i++)
                {
                    fuc = new ForecastUC();
                    fuc.pictureBoxIconFuc.ImageLocation = "https://openweathermap.org/img/w/" + forecastInfo.list[i].weather[0].icon + ".png";
                    fuc.labelWeatherFuc.Text = forecastInfo.list[i].weather[0].main;
                    fuc.labelDateTimeFuc.Text = convertDateTime(forecastInfo.list[i].dt).DayOfWeek.ToString();

                    //Sätter in i flowLayoutPanel
                    flowLayoutPanelForecast.Controls.Add(fuc);
                }
            }
        }

        void searchError()
        {
            var searchError = MessageBox.Show("Could not find this location.", "Invalid search", MessageBoxButtons.OK);
        }

        private void labelDateTime_Click(object sender, EventArgs e)
        {
            
        }
    }
}
