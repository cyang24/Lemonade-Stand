using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Customer : Day_Weather
    {
        public bool chanceToBuy = false;
        public double customerPriceRanking;
        public double customerWeatherRanking;

        public Customer()
        {
            CustomerPriceRating();
            CustomerWeatherRating();
            
        }

        public void CustomerPriceRating()
        {
            customerPriceRanking = rnd.Next(0,1);
        }

        public void CustomerWeatherRating()
        {
            customerWeatherRanking = rnd.Next(60,99);
        }

        public void CustomerWillBuy(Player player)
        {
            if (todaysForecast.ToLower() == "sunny")
            {
                if (TodaysTemperature >= 60 && TodaysTemperature <= 99)
                {   
                    if (player.lemonadeRank >= 0)
                    {
                        chanceToBuy = true;
                    }
                    chanceToBuy = true;
                }
            }
            else if (todaysForecast.ToLower() == "partly cloudy")
            {
                if (TodaysTemperature >= 75 && TodaysTemperature <= 99)
                {   
                    if (player.lemonadeRank >= 0 )
                    {
                        chanceToBuy = true; 
                    }
                        
                    chanceToBuy = true;
                }
                else
                {
                    chanceToBuy = false;
                }
            }
            else if (todaysForecast.ToLower() == "overcast")
            {
                if (TodaysTemperature >= 80 && TodaysTemperature <= 99)
                {   
                    if (player.lemonadeRank <= 2)
                    {
                        chanceToBuy = true;
                    }
                    chanceToBuy = true;
                }
                else
                {
                    chanceToBuy = false;
                }
            }

            else if (todaysForecast.ToLower() == "rainy")
            {
                if (TodaysTemperature >= 90 && TodaysTemperature <= 99)
                {   
                    if (player.lemonadeRank <= 1)
                    {
                        chanceToBuy = true;
                    }

                    chanceToBuy = true;
                }
                else
                {
                    chanceToBuy = false;
                }
            } //need if true add to wallet statement

        }

    }
}
