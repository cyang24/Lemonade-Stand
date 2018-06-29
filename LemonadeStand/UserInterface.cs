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
            Console.WriteLine("What would you like to do?\na) Check Balance\nb) Check Inventory\nc) Go To Store\n");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "a":
                    DisplayBalance(player);
                    break;

                case "b":
                    DisplayInventory(inventory);
                    break;

                case "c":
                    store.PromptToBuy(player, inventory);
                    break;
                default:
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
            Console.WriteLine($"\nCurrent Inventory:\ncups: {inventory.cupsInventory.Count} \nlemons: {inventory.lemonsInventory.Count} \nsugar: { inventory.sugarInventoery.Count} \nice cubes: { inventory.iceInventory.Count}\n\n");
        }



    }
}
