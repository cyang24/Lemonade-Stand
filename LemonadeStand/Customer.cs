using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Customer
    {
        public bool chanceToBuy = false;
        Day_Weather newWeather = new Day_Weather();



        public Customer()
        {

        }

        public void CustomerWillBuy()
        {
            newWeather.CalculateTodaysForecast();
            newWeather.CalculateTodaysWeather();

            if (newWeather.todaysForecast.ToLower() == "sunny")
            {
                if (newWeather.TodaysWeather >= 60 && newWeather.TodaysWeather <= 99)
                {
                    chanceToBuy = true;
                }
            }
            else if (newWeather.todaysForecast.ToLower() == "partly cloudy")
            {
                if (newWeather.TodaysWeather >= 75 && newWeather.TodaysWeather <= 99)
                {
                    chanceToBuy = true;
                }
                else
                {
                    chanceToBuy = false;
                }
            }
            else if (newWeather.todaysForecast.ToLower() == "overcast")
            {
                if (newWeather.TodaysWeather >= 80 && newWeather.TodaysWeather <= 99)
                {
                    chanceToBuy = true;
                }
                else
                {
                    chanceToBuy = false;
                }
            }

            else if (newWeather.todaysForecast.ToLower() == "rainy")
            {
                if (newWeather.TodaysWeather >= 90 && newWeather.TodaysWeather <= 99)
                {
                    chanceToBuy = true;
                }
                else
                {
                    chanceToBuy = false;
                }
        }


        //weather is good / High Weather / Good Forecast
        // weahter chance



        // price of lemonade 
        // random price option



    }


}
}
