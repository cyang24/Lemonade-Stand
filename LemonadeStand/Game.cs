using System;
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
            Store store = new Store();
            store.DisplayInventoryAndBalance();
            Console.WriteLine("All set " + player.PlayerName + "\nLet's go make some Lemonade\n\n");
            player.inventory.UsedLemons();
            store.DisplayInventoryAndBalance();



        }
    }
}
