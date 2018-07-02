using System;
using System.Collections.Generic;


namespace LemonadeStand
{
    public class Day_Weather
    {
        private int todaysTemperature;
        public string todaysForecast;
        public List<Customer> thirstyCustomers;
        public List<Customer> customersThatBought;
        public Customer customer;
        public Random rnd = new Random();
        public double totalBought;


        public int TodaysTemperature
        {
            get { return todaysTemperature; }
            set { todaysTemperature = value; }
        }

        public Day_Weather()
        {
            CalculateTodaysForecast();
            CalculateTodaysTemperature();
            Console.WriteLine("Today's Forecast is " + todaysForecast + " with a high of " + todaysTemperature + " degrees");
        }

        public void CalculateTodaysTemperature()
        {
            todaysTemperature = rnd.Next(55, 99);
        }

        public void CalculateTodaysForecast()
        {

            List<string> forecast = new List<string>();
            forecast.Add("Rainy");
            forecast.Add("Partly Cloudy");
            forecast.Add("Overcast");
            forecast.Add("Sunny");


            int numberGenerator = rnd.Next(1, 4);

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


        public void DailyCustomerResults(Player player, Inventory inventory, Recipe recipe, Day_Weather day_Weather)
        {   
            customer = new Customer();
            thirstyCustomers = new List<Customer>();
            GenerateCustomerConditions(); // creates number of customers
            Console.WriteLine("You have " + thirstyCustomers.Count + " potential customers today!");
            ChanceBasedOnWeather(); // creates weather condition chances
            ChanceBasedOnPrice(player); // creates price chances
            ChanceBasedOnTemperature(); // creates temperature chances
            CustomersWillBuy(player);
            CupsSold(player);
            DailyTotalResults(player);
            player.recipe.UsedTotalAfterOneDay(player, inventory, day_Weather);
            ResetCustomers(); //resets customer count
        }



        public void GenerateCustomerConditions()
        {
            int min = 75;
            int max = 125;

            if (todaysForecast == "sunny")
            {
                min += 10;
                max += 20;
            }
            else if (todaysForecast == "rainy")
            {
                min -= 10;
                max -= 10;
            }

            int numberOfCustomers = rnd.Next(min, max);

            for (int i = 0; i < numberOfCustomers; i++)
            {
                Customer customers = new Customer();
                thirstyCustomers.Add(customers);
            }
        }

        public void ChanceBasedOnWeather()
        {
            if (todaysForecast == "sunny")
            {
                customer.PercentChanceToBuy += rnd.Next(0, 20);
            }
            else if (todaysForecast == "partly cloudy")
            {
                customer.PercentChanceToBuy += rnd.Next(0, 15);
            }
            else if (todaysForecast == "Overcast")
            {
                customer.PercentChanceToBuy += rnd.Next(0, 5);
            }
            else if (todaysForecast == "Rainy")
            {
                customer.PercentChanceToBuy -= rnd.Next(0, 30);
            }

        }

        public void ChanceBasedOnPrice(Player player)
        {
            if (player.lemonadeRank == 0)
            {
                customer.PercentChanceToBuy += rnd.Next(0, 20);
            }
            else if (player.lemonadeRank == 1)
            {
                customer.PercentChanceToBuy += rnd.Next(0, 10);
            }
            else if (player.lemonadeRank == 2)
            {
                customer.PercentChanceToBuy += rnd.Next(0, 5);
            }
            else if (player.lemonadeRank == 3)
            {
                customer.PercentChanceToBuy -= rnd.Next(0,2);
            }
            else if (player.lemonadeRank == 4)
            {
                customer.PercentChanceToBuy -= rnd.Next(0, 35);
            }
            else if (player.lemonadeRank == 5)
            {
                customer.PercentChanceToBuy -= rnd.Next(35, 50);
            }
        }

        public void ChanceBasedOnTemperature()
        {
            if (TodaysTemperature >= 90)
            {
                customer.PercentChanceToBuy += rnd.Next(0, 20);
            }
            else if (TodaysTemperature >= 80 && TodaysTemperature <= 90)
            {
                customer.PercentChanceToBuy += rnd.Next(0, 15);
            }
            else if (TodaysTemperature >= 70 && TodaysTemperature <= 80)
            {
                customer.PercentChanceToBuy += rnd.Next(0, 10);
            }
            else if (TodaysTemperature >= 60 && TodaysTemperature <= 70)
            {
                customer.PercentChanceToBuy += rnd.Next(0, 5);
            }
            else if (TodaysTemperature >= 50 && TodaysTemperature <= 60)
            {
                customer.PercentChanceToBuy -= 30;
            }

        }

        public void CustomersWillBuy(Player player)
        {
            for (int i = 0; i < thirstyCustomers.Count; i++)
            {
                if (thirstyCustomers[i].PercentChanceToBuy < 49)
                {
                    thirstyCustomers.RemoveAt(i);
                }
            }
         }

        public void DailyTotalResults(Player player)
        {
            if (totalBought <= 0)
            {
                Console.WriteLine("Today" + " you sold " + totalBought + " cups.");
            }
            else 
            {
                Console.WriteLine("After Today" + " you sold " + totalBought + " cups and made " + (player.LemonadePrice * thirstyCustomers.Count) + ".");
                player.wallet.AddToWallet(player.LemonadePrice * Convert.ToDecimal(totalBought));
            }
        }

        public void ResetCustomers()
        {
            thirstyCustomers.Clear();
        }

        public void CupsSold(Player player)
        {
            if (player.recipe.cupsToUse < thirstyCustomers.Count)
            {
                totalBought = player.recipe.cupsToUse;
            }
            else if (player.recipe.cupsToUse > thirstyCustomers.Count)
            {
                totalBought = thirstyCustomers.Count;
            }

        }
    }   
} 
