using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Inventory ////SOLID DESIGN PRINCIPAL - Single responsibilty to keep track of inventory and to add or subtract.
    {   
        
        public List<Lemon> lemonsInventory;
        public List<Sugar> sugarInventory;
        public List<Ice> iceInventory;
        public List<Cups> cupsInventory;

        public Inventory()
        {
            lemonsInventory = new List<Lemon>();
            sugarInventory = new List<Sugar>();
            iceInventory = new List<Ice>();
            cupsInventory = new List<Cups>();
        }

        public void BuyLemonsMath(string amountToBuy)
        {
            for (int i = 0; i < int.Parse(amountToBuy); i++)
            {
                Lemon lemon = new Lemon();
                lemonsInventory.Add(lemon);
            }

                 Console.WriteLine("You now have " + lemonsInventory.Count + " lemons");
        }

       
        public void BuyCupsMath(string amountToBuy)
        {
            for (int i = 0; i < int.Parse(amountToBuy); i++)
            {   
                Cups cups = new Cups();
                cupsInventory.Add(cups);
            }

                Console.WriteLine("You now have " + cupsInventory.Count + " cups");
        }

        public void BuyIceMath(string amountToBuy)
        {
            for (int i = 0; i < int.Parse(amountToBuy); i++)
            {
                Ice ice = new Ice();
                iceInventory.Add(ice);
            }

                Console.WriteLine("You now have " + iceInventory.Count + " cups of ice");
        }

        public void BuySugarMath(string amountToBuy)
        {
            for (int i = 0; i < int.Parse(amountToBuy); i++)
            {
                Sugar sugar = new Sugar();
                sugarInventory.Add(sugar);
            }
                Console.WriteLine("You now have " + sugarInventory.Count + " cups of sugar");
        }

        public void UsedTotalAfterOneDay(Recipe recipe, Day_Weather day_Weather) //2 lemons 2 sugars = 1 cup
        {
            if (recipe.cupsToUse > day_Weather.thirstyCustomers.Count)
            {
                for (int i = 0; i < day_Weather.totalBought; i++)
                {
                    cupsInventory.RemoveAt(0);
                }
            }
            else if (recipe.cupsToUse < day_Weather.thirstyCustomers.Count)
                for (int i = 0; i < recipe.cupsToUse; i++)
                {
                    cupsInventory.RemoveAt(0);
                }

            //for Lemons
            if (recipe.cupsToUse > day_Weather.thirstyCustomers.Count)
            {
                for (int i = 0; i < recipe.lemonsToUse; i++)
                {
                    lemonsInventory.RemoveAt(0);
                }
            }

            else if (recipe.cupsToUse < day_Weather.thirstyCustomers.Count)
                for (int i = 0; i < recipe.lemonsToUse; i++)
                {
                    lemonsInventory.RemoveAt(0);
                }

            //for Sugar
            if (recipe.cupsToUse > day_Weather.thirstyCustomers.Count)
            {
                for (int i = 0; i < recipe.sugarToUse; i++)
                {
                    sugarInventory.RemoveAt(0);
                }
            }

            else if (recipe.cupsToUse < day_Weather.thirstyCustomers.Count)
            {
                for (int i = 0; i < recipe.sugarToUse; i++)
                {
                    sugarInventory.RemoveAt(0);
                }
            }

            //for Ice

            iceInventory.Clear();
            Console.WriteLine("All your ice melted");
        }

    }

}
