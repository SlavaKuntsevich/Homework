using System.Text.Json;

namespace lesson12_13
{
    public class Program
    {
        static void Main(string[] args)
        {
            WeekDaysWeather days = new WeekDaysWeather();
            WeekDaysWeatherDelegate week = days.SevenDays;
            week();
            week();
            week();
            week();
            week();

            using (var fs = new FileStream("data.json", FileMode.Open))
            {
                var superHeroSquad = JsonSerializer.Deserialize<Squad>(fs);
            }
        }        
    }
}