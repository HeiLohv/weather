using System;

namespace weather
{
    public class weatherForecast
    {
        public list<list> list { get; set; }
    }

    public class temp
    {
        public double day { get; set; }
    }

    public class weather
    {
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
        public list<list> list { get; set; }
    }

    public class list
    {
        public double dt { get; set; }
        public temp temp { get; set; }
        public List<weather> weather { get; set; }
    }



}
