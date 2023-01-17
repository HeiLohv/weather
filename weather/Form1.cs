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


namespace weather
{
    public partial class Form1 : Form
    {
        string apiKey = "168d1666fa09c5fdf5a98128f6ad20a4";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelWeather_Click(object sender, EventArgs e)
        {

        }

        void getWeather()
        {

            //Tar fram data när det skrivs en stad i sökfältet
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", textBoxSearch_TextChanged.Text, apiKey);
                var json = web.DownloadString(url);
                weatherInfo.Root Info = JsonConvert.DeserializeObject<weatherInfo.Root>(json);

                pictureBoxIcon.ImageLocation = "https://openweathermap.org/img/w/04d.png" + Info.weather[0].icon + ".png";
                labelWeather.Text = Info.weather[0].main;
                labelDescription.Text = Info.weather[0].description;

                labelSunrise.Text = Info.sys.sunrise.ToString();
                labelSunset.Text = Info.sys.sunset.ToString();

                labelHumidity.Text = Info.main.humidity.ToString();
                labelPressure.Text = Info.main.pressure.ToString();

                labelWindSpeed.Text = Info.wind.speed.ToString();

                labelTemperature.Text = Info.main.temp.ToString();
                labelMinTemp.Text = Info.main.temp_min.ToString();
                labelMaxTemp.Text = Info.main.temp_max.ToString();
                labelFeels.Text = Info.main.feels_like.ToString();


            }
        }
        //DateTime convertDateTime(long millisec)
        //{
        // DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
        //day = day.AddMilliseconds(millisec).ToLocalTime();
        //}

        private void buttonGet_Click(object sender, EventArgs e)
        {
            //Visar upp information
            getWeather();
            labelWeather.Visible = true;
            labelDescription.Visible = true;
            labelSunrise.Visible = true;
            labelSunset.Visible = true;
            labelHumidity.Visible = true;
            labelPressure.Visible = true;
            labelWindSpeed.Visible = true;
            labelTemperature.Visible = true;
            labelMinTemp.Visible = true;
            labelMaxTemp.Visible = true;
            labelFeelsLike.Visible = true;
            labelFeels.Visible = true;
        }

        private void textBoxSearch_TextChanged_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Lägger till i listan
            listBoxList.Items.Add(textBoxSearch_TextChanged.Text);
        }

        void showWeather()
        {

            string selected = listBoxList.SelectedItem.ToString();

            using (WebClient web = new WebClient())
            {
                //Tar fram data om vald plats i listan
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", selected, apiKey);
                var json = web.DownloadString(url);
                weatherInfo.Root Info = JsonConvert.DeserializeObject<weatherInfo.Root>(json);

                pictureBoxIcon.ImageLocation = "https://openweathermap.org/img/w/04d.png" + Info.weather[0].icon + ".png";
                labelWeather.Text = Info.weather[0].main;
                labelDescription.Text = Info.weather[0].description;

                labelSunrise.Text = Info.sys.sunrise.ToString();
                labelSunset.Text = Info.sys.sunset.ToString();

                labelHumidity.Text = Info.main.humidity.ToString();
                labelPressure.Text = Info.main.pressure.ToString();

                labelWindSpeed.Text = Info.wind.speed.ToString();

                labelTemperature.Text = Info.main.temp.ToString();
                labelMinTemp.Text = Info.main.temp_min.ToString();
                labelMaxTemp.Text = Info.main.temp_max.ToString();
                labelFeels.Text = Info.main.feels_like.ToString();


            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            //Visar upp information
            showWeather();
            labelWeather.Visible = true;
            labelDescription.Visible = true;
            labelSunrise.Visible = true;
            labelSunset.Visible = true;
            labelHumidity.Visible = true;
            labelPressure.Visible = true;
            labelWindSpeed.Visible = true;
            labelTemperature.Visible = true;
            labelMinTemp.Visible = true;
            labelMaxTemp.Visible = true;
            labelFeelsLike.Visible = true;
            labelFeels.Visible = true;
        }

        //Kod för att ta bort en post
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string delete = "Are you sure you want to delete " + listBoxList.SelectedItem + "?";

            //Frågar om du vill ta bort 
            var confirmResult = MessageBox.Show(delete, "Delete item", MessageBoxButtons.YesNo);

            if(confirmResult == DialogResult.Yes)
            {
                listBoxList.Items.Remove(listBoxList.SelectedItem);
            }
            else
            {
                //   
            }
            
        }
    }
}
