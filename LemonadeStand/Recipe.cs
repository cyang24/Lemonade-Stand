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
        Inventory inventory = new Inventory();


        public Recipe()
        {

            MakeRecipe();

           
        }

        public void MakeRecipe()
        {

        }


        public void UsedLemons()
        {
            Console.WriteLine("You have " + inventory.lemons.Count + "How many lemons would you like you use?");
            lemonsToUse = int.Parse(Console.ReadLine());



         
            //lemonsToUse = int.Parse(Console.ReadLine());

            //for (int i = 0; i < lemonsToUse; i++)
            //{
            //    if (inventory.lemons[i].lemons == lemons)
            //    {
            //        inventory.lemons.RemoveAt(i);
            //    }
            //}
        }


    }   


}
