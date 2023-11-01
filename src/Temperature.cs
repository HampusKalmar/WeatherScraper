namespace WeatherScraper
{
    class Temperature
    {
        public Temperature(string time, string temp)
        {
            Time = time;
            Temp = temp;
        }
        public string Time { get; private set; }
        public string Temp { get; private set; }
    }
}