using System;
using System.Collections.Generic;
namespace LemonadeStand
{
    public class Game 
    {
        Player player;
        public int currentDay = 1;
        Recipe recipe;

        public Game()
        {
            RunGame();
        }

        public void RunGame()
        {
            Console.WriteLine("\nWhat is your lemonade stands name?\n");
            player = new Player();
            Console.WriteLine("Good Luck " + player.PlayerName);
            Console.WriteLine("Let's Get Started!!");
            UserInterface userInterface = new UserInterface();
            Inventory inventory = new Inventory();
            recipe = new Recipe();
            Store store = new Store();
            userInterface.CheckBalanceCheckInventoryGoToStore(player, inventory, store);
            GameLoopSevenDays(userInterface, store, inventory,recipe);
            userInterface.DisplayInventory(inventory);
                       
        }

        public void GameLoopSevenDays(UserInterface userInterface, Store store, Inventory inventory, Recipe recipe)
        {
            do
            {
                Day_Weather day_Weather = new Day_Weather();
                player.SetLemonadePrice();
                day_Weather.DailyCustomerResults(player);
                player.inventory.UsedTotalAfterOneDay(recipe, day_Weather);
                userInterface.CheckBalanceCheckInventoryGoToStore(player, inventory, store);
                currentDay += 1;
            }

            while (currentDay < 8);

        }
    }
}
