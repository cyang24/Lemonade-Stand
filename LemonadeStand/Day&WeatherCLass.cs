using System;
namespace LemonadeStand
{
    public class Day_WeatherCLass
    {
        private int daysCount;
        private int daileyHours;
        private float localWeather; //API goes here

        public float LocalWeather
        {
            get { return localWeather; }
            set { localWeather = value; }
        }


        public float DaysCount
        {
            get { return daysCount; }
            set { localWeather = 7; }
        }

        public Day_WeatherCLass()
        {
        }


    }
}
