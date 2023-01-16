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

            using (WebClient web = new WebClient()){
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q=(0)&appid=(1)", textBoxSearch_TextChanged.Text, apiKey);
                var json = web.DownloadString(url);
                weatherInfo.Root Info = JsonConvert.DeserializeObject<weatherInfo.Root>(json);

                pictureBoxIcon.ImageLocation = "https://openweathermap.org/img/w/04d.png" + Info.weather[0].icon + ".png";
                labelWeather.Text = Info.weather[0].main;
                labelSunrise.Text = Info.sys.sunrise.ToString();
                labelSunset.Text = Info.sys.sunset.ToString();
                labelHumidity.Text = Info.main.humidity.ToString();
                labelPressure.Text = Info.main.pressure.ToString();
                labelWindSpeed.Text = Info.wind.speed.ToString();

            }
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        private void textBoxSearch_TextChanged_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
