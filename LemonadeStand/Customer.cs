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
            customerPriceRanking = rnd.Next(0,5);
        }

        public void CustomerWeatherRating()
        {
            customerWeatherRanking = rnd.Next(60,99);
        }

        public void CustomerWillBuy(Player player)
        {
            if (todaysForecast.ToLower() == "sunny")
            {
                if (TodaysTemperature >= 60 && customerWeatherRanking >= 60)
                {   
                    if (customerPriceRanking >= 0  && player.lemonadeRank >=0 )
                    {
                        chanceToBuy = true;
                    }
                    chanceToBuy = true;
                }
            }
            else if (todaysForecast.ToLower() == "partly cloudy")
            {
                if (TodaysTemperature >= 75 && customerWeatherRanking >= 75)
                {   
                    if (customerPriceRanking >= 0 && player.lemonadeRank >= 0 )
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
                if (TodaysTemperature >= 80 && customerWeatherRanking >= 80)
                {   
                    if (customerPriceRanking <= 2 && player.lemonadeRank >= 2)
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
                if (TodaysTemperature >= 90 && customerWeatherRanking >= 90)
                {   
                    if (customerPriceRanking <= 1 && player.lemonadeRank >= 1)
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


            //add to wallet statement

            if (chanceToBuy == true)
            {
                player.wallet.AddToWallet(player.LemonadePrice);
            }

        }

    }
}
