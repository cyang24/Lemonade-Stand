using System;
namespace LemonadeStand
{
    public class UserInterface
    {   


        public UserInterface()
        {

        }

        public void CheckBalanceCheckInventoryGoToStore(Player player, Inventory inventory, Store store)
        {
            Console.WriteLine("\nWhat would you like to do " + player.PlayerName + "?\na) Check Balance\nb) Check Inventory\nc) Go To Store\nd) Make Lemonade\ne) Exit\n");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "a":
                    Console.Clear();
                    DisplayBalance(player);
                    CheckBalanceCheckInventoryGoToStore(player, inventory, store);
                    break;
                case "b":
                    Console.Clear();
                    DisplayInventory(inventory);
                    CheckBalanceCheckInventoryGoToStore(player, inventory, store);
                    break;
                case "c":
                    Console.Clear();
                    store.BuyForInventory(player,inventory);
                    CheckBalanceCheckInventoryGoToStore(player, inventory, store);
                    break;
                case "d":
                    Console.Clear();
                    player.recipe.MakeRecipe(inventory, player, store);
                    break;
                case "e":
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid Entry Try Again.");
                    CheckBalanceCheckInventoryGoToStore(player, inventory, store);
                    break;
            }

        }

        public void DisplayBalance(Player player)
        {
            Console.WriteLine($"\nCurrent Balnce: $ {player.wallet.PlayerMoney} \n");
        }

        public void DisplayInventory(Inventory inventory)
        {            
            Console.WriteLine($"\nCurrent Inventory:\ncups: {inventory.cupsInventory.Count} \nlemons: {inventory.lemonsInventory.Count} \nsugar: { inventory.sugarInventory.Count} \nice cubes: { inventory.iceInventory.Count}\n\n");
        }

        public void NotEnoughMessage(Player player, Inventory inventory, Store store)
        {
            Console.WriteLine("Not enough. Please buy more.");
            CheckBalanceCheckInventoryGoToStore(player, inventory, store);
        }




    }
}
