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

    }

}
