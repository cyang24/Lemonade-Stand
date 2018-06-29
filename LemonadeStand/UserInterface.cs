using System;
namespace LemonadeStand
{
    public class UserInterface
    {
        public UserInterface()
        {

        }

        public void DisplayBalance(Player player)
        {
            Console.WriteLine($"\nCurrent Balnce: $ {player.wallet.PlayerMoney} \n");
        }

        public void DisplayInventory(Inventory inventory)
        {            
            Console.WriteLine($"\nCurrent Inventory:\ncups: {inventory.cupsInventory.Count} \nlemons: {inventory.lemonsInventory.Count} \nsugar: { inventory.sugarInventoery.Count} \nice cubes: { inventory.iceInventory.Count}\n\n");
        }

        public void PromptToBuy(Store store, Player player, Inventory inventory)
        {
            Console.WriteLine("Would you like to buy something Yes or No");
            string buyMore = Console.ReadLine().ToLower();

            switch (buyMore)
            {
                case "yes":
                store.BuyForInventory(player, inventory);
                break;

            case "no":
                break;
            }
        }

    }
}
