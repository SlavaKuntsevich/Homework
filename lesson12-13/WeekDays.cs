using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson12_13
{
    public class WeekDaysWeather
    {
        private event WeatherDelegate? Weahter = delegate (string weather)
        {
            Console.Write(weather);
        };
        private int daysCount;
        private string[] weather = { "Ясно", "Смерч", "Ливень", "Снегопад", "Торнадо","Землетрясение", "Извержение вулкана","Цунами" };
        private int DaysCount
        {
            get { return daysCount; }
            set
            {
                if (value <= 7) daysCount = value;
                if (value > 7) daysCount = 1;
            }
        }
        public WeekDaysWeather()
        {
            DaysCount = 1;
        }
        public void SevenDays()
        {
            Random rand = new Random();
            switch (DaysCount)
            {
                case 1:
                    Console.Write($"Понедельник - {weather[rand.Next(0, 8)]} \n");                    
                    DaysCount++;
                    break;
                case 2:
                    Console.Write($"Вторник - {weather[rand.Next(0, 8)]} \n");                   
                    DaysCount++;
                    break;
                case 3:
                    Console.Write($"Среда - {weather[rand.Next(0, 8)]} \n");                    
                    DaysCount++;
                    break;
                case 4:
                    Console.Write($"Четверг - {weather[rand.Next(0, 8)]} \n");
                    DaysCount++;
                    break;
                case 5:
                    Console.Write($"Пятница - {weather[rand.Next(0, 8)]} \n");
                    DaysCount++;    
                    break;
                case 6:
                    Console.Write($"Суббота - {weather[rand.Next(0, 8)]} \n");
                    DaysCount++;
                    break;
                case 7:
                    Console.Write($"Воскресенье - {weather[rand.Next(0, 8)]} \n");
                    DaysCount++;
                    break;
            }

        }
    }
}
