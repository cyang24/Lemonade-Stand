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
            Console.WriteLine("What is your lemonade stands name?\n");
            Player player = new Player();
            Console.WriteLine("Good Luck " + player.PlayerName);
            Console.WriteLine("Let's Get Started!!");
            UserInterface userInterface = new UserInterface();
            Store store = new Store();
            userInterface.DisplayBalance(player);
            Console.Clear();
            userInterface.DisplayInventory(player.inventory);
            userInterface.PromptToBuy(store,player,player.inventory);
            userInterface.DisplayInventory(player.inventory);
            //userInterface.DisplayInventory();
            //Console.WriteLine("All set " + player.PlayerName + "\nLet's go make some Lemonade\n\n");
            //player.recipe.UsedLemons();
            //Day_Weather weather = new Day_Weather();
            //player.SetPrice_Recipe();



        }
    }
}
