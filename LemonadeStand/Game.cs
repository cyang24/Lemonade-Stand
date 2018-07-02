using System;
using System.Collections.Generic;
namespace LemonadeStand
{
    public class Game 
    {
        Player player;
        Recipe recipe;
        public int currentDay = 1;

        public Game()
        {
            RunGame();
        }

        public void RunGame()
        {
            Console.WriteLine("\nWelcome to Lemonade Stand!\nYou will be challenged with trying to making as much as you can\nwith a starting budget of $20");
            Console.WriteLine("Let's Get Started!!");
            Console.WriteLine("\nWhat is your lemonade stands name?\n");
            player = new Player();
            Console.WriteLine("Good Luck " + player.PlayerName);
            UserInterface userInterface = new UserInterface();
            Inventory inventory = new Inventory();
            recipe = new Recipe();
            Store store = new Store();
            userInterface.CheckBalanceCheckInventoryGoToStore(player, inventory, store);
            GameLoopSevenDays(userInterface, store, inventory, recipe);

                       
        }

        public void GameLoopSevenDays(UserInterface userInterface, Store store, Inventory inventory, Recipe recipe)
        {
            do
            {
                Day_Weather day_Weather = new Day_Weather();
                player.SetLemonadePrice();
                day_Weather.DailyCustomerResults(player, inventory,recipe, day_Weather);
                userInterface.DisplayInventory(inventory);
                userInterface.CheckBalanceCheckInventoryGoToStore(player, inventory, store);
                Console.WriteLine(currentDay);
                currentDay += 1;
                Console.WriteLine("It's Day " + currentDay);

            }

            while (currentDay < 8);

        }
    }
}
