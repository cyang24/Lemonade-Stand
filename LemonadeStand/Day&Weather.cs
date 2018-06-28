using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Day_Weather
    {
        private int daysCount;
        private int daileyHours;
        private int todaysWeather; //API goes here?
        public string todaysForecast;

        Random random = new Random();

        public int TodayslWeather
        {
            get { return todaysWeather; }
            set { todaysWeather = value; }
        }


        public int DaysCount
        {
            get { return daysCount; }
            set { daysCount = value; }
        }

        public Day_Weather()
        {
            TodaysForecast();
            TodaysWeather();
            Console.WriteLine("Today's Forcast is " + todaysForecast + " with a high of " + todaysWeather);
        }

        public void TodaysWeather()
        {
            todaysWeather = random.Next(55, 99);
        }

        public void TodaysForecast()
        {   
            
            List<string> forecast = new List<string>();
            forecast.Add("Rainy");
            forecast.Add("Partly Cloudy");
            forecast.Add("Overcast");
            forecast.Add("Sunny");
       

            int numberGenerator = random.Next(1, 4);

            switch (numberGenerator)
            {
                case 1:
                    todaysForecast = forecast[0];
                    break;
                case 2:
                    todaysForecast = forecast[1];
                    break;
                case 3:
                    todaysForecast = forecast[2];
                    break;
                case 4:
                    todaysForecast = forecast[3];
                    break;
            }
        }

    }

} 
