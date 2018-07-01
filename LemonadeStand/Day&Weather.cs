using System;
using System.Collections.Generic;
using System.Linq;

namespace LemonadeStand
{
    public class Day_Weather
    {
        private int todaysTemperature; //API goes here?
        public string todaysForecast;
        public List<Customer> thirstyCustomers;
        public List<Customer> customersThatBought;
        public Customer customer;
        public Random rnd = new Random();
        public int totalBought;

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


        public void DailyCustomerResults(Player player)
        {   
            customer = new Customer();
            thirstyCustomers = new List<Customer>();
            customersThatBought = new List<Customer>();
            GenerateCustomerConditions(); // creates number of customers
            ChanceBasedOnWeather(); // creates weather condition chances
            ChanceBasedOnPrice(player); // creates price chances
            ChanceBasedOnTemperature(); // creates temperature chances
            DailyTotalResults(player); // displays player daily totals
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
                customer.PercentChanceToBuy = rnd.Next(75, 100);
            }
            else if (todaysForecast == "partly cloudy")
            {
                customer.PercentChanceToBuy = rnd.Next(70, 75);
            }
            else if (todaysForecast == "Overcast")
            {
                customer.PercentChanceToBuy = rnd.Next(50, 65);
            }
            else if (todaysForecast == "Rainy")
            {
                customer.PercentChanceToBuy = rnd.Next(30, 40);
            }
            
        }

        public void ChanceBasedOnPrice(Player player)
        {
            if (player.lemonadeRank == 0)
            {
                customer.PercentChanceToBuy = rnd.Next(75, 100);
            }
            else if (player.lemonadeRank == 1)
            {
                customer.PercentChanceToBuy = rnd.Next(70, 75);
            }
            else if (player.lemonadeRank == 2)
            {
                customer.PercentChanceToBuy = rnd.Next(50, 65);
            }
            else if (player.lemonadeRank == 3)
            {
                customer.PercentChanceToBuy = rnd.Next(30, 40);
            }
            else if (player.lemonadeRank == 4)
            {
                customer.PercentChanceToBuy = rnd.Next(0, 25);
            }
        }

        public void ChanceBasedOnTemperature()
        {
            if (TodaysTemperature >= 90)
            {
                customer.PercentChanceToBuy = rnd.Next(75, 100);
            }
            else if (TodaysTemperature >= 80 && TodaysTemperature <= 90)
            {
                customer.PercentChanceToBuy = rnd.Next(70, 75);
            }
            else if (TodaysTemperature >= 70 && TodaysTemperature <= 80)
            {
                customer.PercentChanceToBuy = rnd.Next(50, 65);
            }
            else if (TodaysTemperature >= 60 && TodaysTemperature <= 70)
            {
                customer.PercentChanceToBuy = rnd.Next(30, 40);
            }
            else if (TodaysTemperature >= 50 && TodaysTemperature <= 60)
            {
                customer.PercentChanceToBuy = rnd.Next(0, 25);
            }
        }

        public void CustomersWillBuy()
        {
            if (customer.PercentChanceToBuy >= 50)
            {
                totalBought = customersThatBought.Count;
            }
        }

        public void DailyTotalResults(Player player)
        {
            Console.WriteLine("Today you made " + (player.LemonadePrice * customersThatBought.Count) + ".");
            player.wallet.AddToWallet(player.LemonadePrice * customersThatBought.Count);
        }

        public void ResetCustomers()
        {
            if (thirstyCustomers.Count() > 0)
            {
                for (int i = 0; i < thirstyCustomers.Count; i++)
                {
                    thirstyCustomers.RemoveAt(0);
                }
            }
        }

    }
} 
