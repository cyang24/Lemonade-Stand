using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Recipe 
    {   
        public int lemonsToUse;
        public int cupsToUse;
        public int iceToUse;
        public int sugarToUse;
        Inventory inventory;


        public Recipe()
        {

        }

        public void MakeRecipe()
        {
            Console.WriteLine($"Your Current Recipe is: \nCups {cupsToUse} \nLemons {lemonsToUse } \nSugar {sugarToUse} \nIce {iceToUse}\n");
        }


        //public void UsedLemons(Inventory inventory)
        //{
        //    Console.WriteLine("You have " + inventory.lemons.Count + "How many lemons would you like you use?");

        //    lemonsToUse = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < lemonsToUse; i++)
        //    {

        //        inventory.lemons.RemoveAt(i);
        //    }
        //}
    }   


}
