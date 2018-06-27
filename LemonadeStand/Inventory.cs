using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Inventory
    {   
        public int lemonsToUse;

        public List<Lemon> lemons;
        public List<Sugar> sugar;
        public List<Ice> ice;
        public List<Cups> cups;

        public Inventory()
        {
            lemons = new List<Lemon>();
            sugar = new List<Sugar>();
            ice = new List<Ice>();
            cups = new List<Cups>();
        }

        public void UsedLemons()
        {
            Console.WriteLine("How many lemons would you like you use?");
            lemonsToUse = int.Parse(Console.ReadLine());

            for (int i = lemons.Count - 1; i >= lemonsToUse; i--)
            {
                lemons.RemoveAt(i);
            }

        }



    }

}
