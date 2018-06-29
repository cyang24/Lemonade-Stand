using System;
using System.Collections.Generic;
using System.Linq;

namespace LemonadeStand
{
    public class Recipe 
    {   
        public int lemonsToUse;
        public int cupsToUse;
        public int iceToUse;
        public int sugarToUse;


        public Recipe()
        {

        }

        public void MakeRecipe()
        {
            Console.WriteLine($"Your Current Recipe is: \nCups {cupsToUse} \nLemons {lemonsToUse } \nSugar {sugarToUse} \nIce {iceToUse}\n");
        }


        public void UsedCups(Inventory inventory)
        {
            Console.WriteLine("You have " + inventory.cupsInventory.Count + " cups. How many cups would you like you use?");

            cupsToUse = int.Parse(Console.ReadLine());

            for(int i = 0 ; i < cupsToUse; i++)
            {
                inventory.cupsInventory.RemoveAt(0);
            }
        }

        public void UsedLemons(Inventory inventory)
        {
            Console.WriteLine("You have " + inventory.lemonsInventory.Count + " lemons. How many lemons would you like you use?");

            lemonsToUse = int.Parse(Console.ReadLine());

            for (int i = 0; i < lemonsToUse; i++)
            {
                inventory.lemonsInventory.RemoveAt(0);
            }
        }

        public void UsedSugar(Inventory inventory)
        {
            Console.WriteLine("You have " + inventory.sugarInventory.Count + " cups of sugar. How many cups would you like you use?");

            sugarToUse = int.Parse(Console.ReadLine());

            for (int i = 0; i < sugarToUse; i++)
            {
                inventory.sugarInventory.RemoveAt(0);
            }
        }

        public void UsedIce(Inventory inventory)
        {
            Console.WriteLine("You have " + inventory.iceInventory.Count + " ice cubes. How many ice cubes would you like you use per cup?");

            iceToUse = int.Parse(Console.ReadLine());

            for (int i = 0; i < iceToUse; i++)
            {
                inventory.iceInventory.RemoveAt(0);
            }
        }

    }   


}
