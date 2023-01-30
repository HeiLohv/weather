using System;

class weatherForecast
{
    public class list
    {
        public long dt { get; set; }
        public temp temp { get; set; }
        public List<Weather> weather { get; set; }
    }

    public class Temp
    {
        public double day { get; set; }  
    }

    public class Weather
    {
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class forecastInfo
    {
        public List<list> list { get; set; }
    }

}
