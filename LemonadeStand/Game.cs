using System;
using System.Collections.Generic;
namespace LemonadeStand
{
    public class Game 
    {

        public Game()
        {
            RunGame();
        }

        public void RunGame()
        {
            //Console.WriteLine("\nWhat is your lemonade stands name?\n");
            Player player = new Player();
            //Console.WriteLine("Good Luck " + player.PlayerName);
            //Console.WriteLine("Let's Get Started!!");
            //Console.Clear();
            UserInterface userInterface = new UserInterface();
            Store store = new Store();
            //Console.Clear();
            userInterface.CheckBalanceCheckInventoryGoToStore(player, player.inventory, store);
            player.SetLemonadePrice();
            Day_Weather day_Weather = new Day_Weather();
            //day_Weather.DailyListOfCustomer();
            Console.WriteLine(day_Weather.thirstyCustomers);
            //userInterface.DisplayInventory();
            //Console.WriteLine("All set " + player.PlayerName + "\nLet's go make some Lemonade\n\n");
            //player.recipe.MakeRecipe(player.inventory);
            //userInterface.DisplayInventory(player.inventory);
            //Day_Weather weather = new Day_Weather();



        }
    }
}
