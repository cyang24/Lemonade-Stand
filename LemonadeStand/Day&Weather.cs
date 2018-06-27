using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Day_Weather
    {
        private int daysCount;
        private int daileyHours;
        private float localWeather; //API goes here

        public double LocalWeather
        {
            get { return localWeather; }
            //set { localWeather = value; }
        }


        public double DaysCount
        {
            get { return daysCount; }
            //set { localWeather = value; }
        }

        public Day_Weather()
        {

        }
    }

} 
