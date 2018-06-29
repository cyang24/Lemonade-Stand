using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Store
    {   
        public decimal itemCost;
        public string amountToBuy;
        UserInterface userInterface = new UserInterface();


        public Store()
        {
        }

        public void BuyForInventory(Player player, Inventory inventory)
        {
            Console.WriteLine("\nWhat would you like to purchase? \na) cups \nb) lemons \nc) sugar \nd) ice\n");
            string userInput = Console.ReadLine();


            switch (userInput)
            {
                case "a":
                    BuyCups(player, inventory);
                    break;

                case "b":
                    BuyLemons(player, inventory);
                    break;

                case "c":
                    BuySugar(player, inventory);
                    break;
                case "d":
                    BuyIce(player, inventory);
                    break;

                default:
                    Console.WriteLine("Invalid Entry Try Again.");
                    BuyForInventory(player, inventory);
                    break;
            }
        }

        public void BuyCups(Player player, Inventory inventory)
        {
            Console.WriteLine("How many cups would you like to buy? \n 25 for 82¢ \n 50 for $1.54 \n 100 for $2.88?");
            amountToBuy = Console.ReadLine();

            if (int.Parse(amountToBuy) == 25)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(Convert.ToDecimal(0.25)));
                inventory.BuyCupsMath(amountToBuy);
            }
            else if (int.Parse(amountToBuy) == 50)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(Convert.ToDecimal(1.54)));
                inventory.BuyCupsMath(amountToBuy);
            }
            else if (int.Parse(amountToBuy) == 100)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(Convert.ToDecimal(2.88)));
                inventory.BuyCupsMath(amountToBuy);
            }
            else
            {
                Console.WriteLine("Invalid Entry Try Again.");
            }
        }


        public void BuyLemons(Player player, Inventory inventory)
        {
            Console.WriteLine("How many lemons would you like to buy? \n 10 for 96¢ \n 30 for $2.39 \n 75 for $4.43?");
            amountToBuy = Console.ReadLine();

            if (int.Parse(amountToBuy) == 10)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(Convert.ToDecimal(0.96)));
                inventory.BuyLemonsMath(amountToBuy);
                PromptToBuy(player, inventory);
            }
            else if (int.Parse(amountToBuy) == 30)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(Convert.ToDecimal(2.39)));
                inventory.BuyLemonsMath(amountToBuy);
                PromptToBuy(player, inventory);
            }
            else if (int.Parse(amountToBuy) == 75)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(Convert.ToDecimal(4.43)));
                inventory.BuyLemonsMath(amountToBuy);
                PromptToBuy(player, inventory);
            }
            else{
               Console.WriteLine("Invalid Entry Try Again.");
            }
        }

        public void BuySugar(Player player, Inventory inventory)
        {
            Console.WriteLine("How much sugar would you like to buy? \n 8 cups for 60¢ \n 20 cups for $1.73 \n 48 cups for $3.42?");
            amountToBuy = Console.ReadLine().ToLower();

            if (int.Parse(amountToBuy) == 8)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(Convert.ToDecimal(0.60)));
                inventory.BuySugarMath(amountToBuy);
            }
            else if (int.Parse(amountToBuy) == 20)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(Convert.ToDecimal(1.73)));
                    inventory.BuySugarMath(amountToBuy);
            }
            else if (int.Parse(amountToBuy) == 48)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(Convert.ToDecimal(3.42)));
                    inventory.BuySugarMath(amountToBuy);
            }
            else
            {
                Console.WriteLine("Invalid Entry Try Again.");
            }

        }

        public void BuyIce(Player player, Inventory inventory)
        {
            Console.WriteLine("How many ice cubes would you like to buy? \n 100 for 75¢ \n 250 for $2.11 \n 500 for $3.69?");
            amountToBuy = Console.ReadLine().ToLower();

            if (int.Parse(amountToBuy) == 100)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(Convert.ToDecimal(0.75)));
                inventory.BuyIceMath(amountToBuy);
                PromptToBuy(player, inventory);


            }
            else if (int.Parse(amountToBuy) == 250)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(Convert.ToDecimal(2.11)));
                inventory.BuyIceMath(amountToBuy);
            }
            else if (int.Parse(amountToBuy) == 500)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(Convert.ToDecimal(3.96)));
                inventory.BuyIceMath(amountToBuy);
            }
            else
            {
                Console.WriteLine("Invalid Entry Try Again.");
            }
        }

        public void PromptToBuy(Player player, Inventory inventory)
        {
            Console.WriteLine("Would you like to buy something Yes or No");
            string buyMore = Console.ReadLine().ToLower();

            switch (buyMore)
            {
                case "yes":
                    BuyForInventory(player, inventory);
                    break;

                case "no":
                    break;
            }
        }







      

    }
}
