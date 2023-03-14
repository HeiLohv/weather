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

        double lon;
        double lat;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textfil dit städer kommer att sparas
            file = "../../locations.txt";
        }

        void showLabels()
        {
            //Skapar en lista
            var labels = new List<Label> { labelWeather, labelDescription, labelSunrise, labelSunset, labelHumidity, labelPressure, labelWindSpeed, labelTemperature, labelMinTemp, labelMaxTemp, labelFeelsLike, labelFeels, labelDateTime, labelSunriseText, labelSunsetText, labelHumidityText, labelPressureText, labelWindSpeedText, labelMinTempText, labelMaxTempText};

            //Gör kontroller i listan labels synliga
            foreach (var label in labels)
                label.Visible = true;
        }
        void getWeather()
        {

            //Tar fram data om platsen som skrivits i sökfältet
            using (var web = new WebClient())
            {
                string url = $"https://api.openweathermap.org/data/2.5/weather?q={textBoxSearch_TextChanged.Text}&appid={apiKey}&units=metric";
                var json = web.DownloadString(url);
                weatherInfo.Root Info = JsonConvert.DeserializeObject<weatherInfo.Root>(json);

                //Sätter in data i kontroller
                weatherLabels(Info);
            }
        }

        private void weatherLabels(weatherInfo.Root Info)
        {
            //Sätter in och omvandlar data så att det kan visas 
            pictureBoxIcon.ImageLocation = $"https://openweathermap.org/img/w/{Info.weather[0].icon}.png";

            labelWeather.Text = Info.weather[0].main;
            labelDescription.Text = Info.weather[0].description;

            labelSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();
            labelSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();

            labelHumidity.Text = Info.main.humidity.ToString() + "%";
            labelPressure.Text = Info.main.pressure.ToString() + " mb";

            labelWindSpeed.Text = Info.wind.speed.ToString() + " m/s";

            labelTemperature.Text = Info.main.temp.ToString() + "°C";
            labelMinTemp.Text = Info.main.temp_min.ToString() + "°C";
            labelMaxTemp.Text = Info.main.temp_max.ToString() + "°C";
            labelFeels.Text = Info.main.feels_like.ToString() + "°C";

            labelDateTime.Text = convertDateTime(Info.dt).ToString();

            lon = Info.coord.lon;
            lat = Info.coord.lat;
        }

        DateTime convertDateTime(long sec)
        {
            //Omvandlar tid
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(sec).ToLocalTime();

            return dateTime;
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
            catch (WebException)
            {
                searchError();
                    
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Sätter in i listan från sökfältet
            listBoxList.Items.Add(textBoxSearch_TextChanged.Text);
        }

        void showWeather()
        {
            //Vald post 
            string selected = listBoxList.SelectedItem.ToString();

            using (var web = new WebClient())
            {
                //Tar fram data om vald plats i listan
                var url = $"https://api.openweathermap.org/data/2.5/weather?q={selected}&appid={apiKey}&units=metric";
                var json = web.DownloadString(url);
                weatherInfo.Root Info = JsonConvert.DeserializeObject<weatherInfo.Root>(json);

                //Sätter in data i kontroller
                weatherLabels(Info);
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            //Om man inte har valt någon post
            if(listBoxList.SelectedIndex <= -1)
            {
                var itemNotSelected = MessageBox.Show("You have not selected an item.", "No item selected", MessageBoxButtons.OK);
            }
            else{
                try
                {
                    //Visar upp information om vädret
                    showWeather();
                    showLabels();
                    getForecast();
                }
                //Felmeddelande visas om sökningen inte fungerat
                catch (WebException)
                {
                    searchError();

                }
                catch (ArgumentOutOfRangeException)
                {

                }
            };
            
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
            //Om filen finns
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
            //Sparar till textfil
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (var item in listBoxList.Items)
                {
                    writer.WriteLine(item);
                }
            }
        }

        void getForecast()
        {
            //Kod som tar fram väderprognosdata om plats
            using (var web = new WebClient())
            {
                int day = 32;
                string url = $"https://api.openweathermap.org/data/2.5/forecast?lat={lat}&lon={lon}&appid={apiKey}&cnt={day}&units=metric&exclude-current,minutely,hourly";
                var json = web.DownloadString(url);
                 weatherForecast.forecastInfo forecastInfo = JsonConvert.DeserializeObject<weatherForecast.forecastInfo>(json);

                ForecastUC fuc;

                //Skapar ny kontroll för varje dag
                for (int i = 0; i < 32; i++)
                {
                    fuc = new ForecastUC();
                    fuc.pictureBoxIconFuc.ImageLocation = $"https://openweathermap.org/img/w/{forecastInfo.list[i].weather[0].icon}.png";
                    fuc.labelWeatherFuc.Text = forecastInfo.list[i].weather[0].main;
                    fuc.labelDescriptionFuc.Text = forecastInfo.list[i].weather[0].description;
                    fuc.labelDateTimeFuc.Text = convertDateTime(forecastInfo.list[i].dt).DayOfWeek.ToString();

                    //Sätter in i flowLayoutPanelForecast
                    flowLayoutPanelForecast.Controls.Add(fuc);
                }
            }
        }

        void searchError()
        {
            //Felmeddelande som kommer att visas vid sökningsfel
            var searchError = MessageBox.Show("Could not find this location.", "Invalid search", MessageBoxButtons.OK);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Frågar om du vill tömma listBoxList
            var clearListbox = MessageBox.Show("Clear listbox?", "Clear", MessageBoxButtons.YesNo);

            if (clearListbox == DialogResult.Yes)
            {
                //Tömmer listBoxList
                listBoxList.Items.Clear();
            }
            else
            {
                //Meddelandet stängs   

            }
        }

        private void labelDateTime_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelWeather_Click(object sender, EventArgs e)
        {

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

        private void textBoxSearch_TextChanged_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
