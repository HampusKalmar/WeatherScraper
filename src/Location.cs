namespace WeatherScraper
{
    class Location
    {
        public Location(string name, string url)
        {
            Name = name;
            Url = url;
        }
        public string Name { get; private set; }
        public string Url { get; private set; }
    }
}