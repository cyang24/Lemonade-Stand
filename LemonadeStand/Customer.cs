using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Customer : Day_Weather
    {
        public bool chanceToBuy = false;
        Player player = new Player();



        public Customer()
        {
            
        }

        public void CustomerWillBuy()
        {
            CalculateTodaysForecast();
            CalculateTodaysTemperature();
            player.LemonadePriceRank();

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
            }

        }

    }
}
