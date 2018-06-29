using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Day_Weather
    {
        private int daysCount;
        private int daileyHours;
        private int todaysTemperature; //API goes here?
        public string todaysForecast;
       



        Random rnd = new Random();

        public int TodaysTemperature
        {
            get { return todaysTemperature; }
            set { todaysTemperature = value; }
        }


        public int DaysCount
        {
            get { return daysCount; }
            set { daysCount = value; }
        }

        public Day_Weather()
        {
            CalculateTodaysForecast();
            CalculateTodaysTemperature();
            Console.WriteLine("Today's Forcast is " + todaysForecast + " with a high of " + todaysTemperature + " degrees");
            Customer customers = new Customer();
            customers.CustomerWillBuy();

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


        //public void DailyListOfCustomer()
        //{
        //    int numberOfCustomers = rnd.Next(70, 120);

        //    for (int i = 0; i<numberOfCustomers; i++)
        //    {
        //        Customer customer = new Customer();
        //        customer.Add(rnd);
        //    }

        //}

    }

} 
