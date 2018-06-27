using System;
using System.Collections.Generic;

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
            set { localWeather = value; }
        }

        public Day_WeatherCLass()
        {
        }


    }
}
