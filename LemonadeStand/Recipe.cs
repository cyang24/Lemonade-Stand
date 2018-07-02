using System;
using System.Collections.Generic;
using System.Linq;

namespace LemonadeStand
{
    public class Recipe 
    {   
        public double lemonsToUse;
        public double cupsToUse;
        public double iceToUse;
        public double sugarToUse;
        UserInterface userInterface = new UserInterface();
        public Recipe()
        {

        }

        public void MakeRecipe(Inventory inventory, Player player, Store store)
        {
            Console.WriteLine("\nLet's make some lemonade!\n");
            
            UsedCups(inventory, player, store);
            UsedLemons(inventory, player, store);
            UsedSugar(inventory, player, store);
            UsedIce(inventory, player, store);

            Console.WriteLine($"\nYour Current Recipe is: \nCups {cupsToUse} \nLemons {lemonsToUse } \nSugar {sugarToUse} \nIce {iceToUse}\n");

        }


        public void UsedCups(Inventory inventory, Player player, Store store)
        {
            Console.WriteLine("You have " + inventory.cupsInventory.Count + " cups. How many cups would you like you use?");
            cupsToUse = int.Parse(Console.ReadLine());

            if (iceToUse < 0)
            {
                userInterface.NotEnoughMessage(player, inventory, store);
            }
        }

        public void UsedLemons(Inventory inventory, Player player, Store store)
        {
            Console.WriteLine("You have " + inventory.lemonsInventory.Count + " lemons. How many lemons would you like you use?");
            lemonsToUse = int.Parse(Console.ReadLine());

            if (iceToUse < 0)
            {
                userInterface.NotEnoughMessage(player, inventory, store);
            }

        }

        public void UsedSugar(Inventory inventory, Player player, Store store)
        {
            Console.WriteLine("You have " + inventory.sugarInventory.Count + " cups of sugar. How sugar would you like you use?");
            sugarToUse = int.Parse(Console.ReadLine());

            if (sugarToUse < 0)
            {
                userInterface.NotEnoughMessage(player, inventory, store);
            }
        }

        public void UsedIce(Inventory inventory, Player player, Store store)
        {
            Console.WriteLine("You have " + inventory.iceInventory.Count + " ice cubes. How many ice cubes would you like you use?");
            iceToUse = int.Parse(Console.ReadLine());

            if (iceToUse < 0)
            {
                userInterface.NotEnoughMessage(player, inventory, store);
            }

        }

        public void UsedTotalAfterOneDay(Player player, Inventory inventory, Day_Weather day_Weather)
        {
            if (player.recipe.cupsToUse > day_Weather.thirstyCustomers.Count)
            {
                for (int i = 0; i < day_Weather.totalBought; i++)
                {
                    inventory.cupsInventory.RemoveAt(0);
                }
            }
            else if (cupsToUse < day_Weather.thirstyCustomers.Count)
                for (int i = 0; i < player.recipe.cupsToUse; i++)
                {
                    inventory.cupsInventory.RemoveAt(0);
                }

            //for Lemons
            if (player.recipe.cupsToUse > day_Weather.thirstyCustomers.Count)
            {
                for (int i = 0; i < player.recipe.lemonsToUse; i++)
                {
                    inventory.lemonsInventory.RemoveAt(0);
                }
            }

            else if (player.recipe.cupsToUse < day_Weather.thirstyCustomers.Count)
                for (int i = 0; i < player.recipe.lemonsToUse; i++)
                {
                inventory.lemonsInventory.RemoveAt(0);
                }

            //for Sugar
            if (player.recipe.cupsToUse > day_Weather.thirstyCustomers.Count)
            {
                for (int i = 0; i < player.recipe.sugarToUse; i++)
                {
                    inventory.sugarInventory.RemoveAt(0);
                }
            }

            else if (player.recipe.cupsToUse < day_Weather.thirstyCustomers.Count)
            {
                for (int i = 0; i < player.recipe.sugarToUse; i++)
                {
                    inventory.sugarInventory.RemoveAt(0);
                }
            }

            //for Ice

            inventory.iceInventory.Clear();
            Console.WriteLine("All your ice melted");
        }

    }   
}
