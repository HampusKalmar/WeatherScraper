using HtmlAgilityPack;
using System;
using System.Diagnostics;
using System.Net.Http;

namespace WeatherScraper
{
    class Scraper
    {
        private readonly Location location;
        private readonly Temperature temperature;


        public void ScrapeData()
        {
            string? url = Environment.GetEnvironmentVariable("WEATHER_URL");
            var httpClient = new HttpClient();
            var html =  httpClient.GetStringAsync(url);
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html.Result);
        }
    }
}