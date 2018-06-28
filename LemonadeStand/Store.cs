﻿using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Store
    {
        public Player player = new Player();
        public double itemCost;
        Inventory inventory = new Inventory();
        public string amountToBuy;

        public Store()
        {
            DisplayInventoryAndBalance();
            BuyMoreItems();
        }

        public void BuyForInventory()
        {
            Console.WriteLine("\nWhat would you like to purchase? \na) cups \nb) lemons \nc) sugar \nd) ice\n");
            string userIput = Console.ReadLine();


            switch (userIput)
            {
                case "a":
                    BuyCups();
                    break;

                case "b":
                    BuyLemons();
                    break;

                case "c":
                    BuySugar();
                    break;
                case "d":
                    BuyIce();
                    break;

                default:
                    Console.WriteLine("Invalid Entry Try Again.");
                    BuyForInventory();
                    break;
            }
        }

        public void DisplayInventoryAndBalance()
        {
            Console.WriteLine($"\nCurrent Balnce: $ {player.wallet.PlayerMoney} \n\nCurrent Inventory:\ncups: {inventory.cups.Count} \nlemons: {inventory.lemons.Count} \nsugar: { inventory.sugar.Count} \nice cubes: { inventory.ice.Count}\n\n");
        }


        public void BuyMoreItems()
        {   
            Console.WriteLine("\n");
            Console.WriteLine("Would you like to buy something Yes or No");
            string buyMore = Console.ReadLine().ToLower();
            
            if (buyMore == "yes" )
            
            {
                BuyForInventory();
            }

            else 
            {
               DisplayInventoryAndBalance();
            }

        }

        public void BuyCups()
        {
            Console.WriteLine("How many cups would you like to buy? \n 25 for 82¢ \n 50 for $1.54 \n 100 for $2.88?");
            amountToBuy = Console.ReadLine().ToLower();

            if (int.Parse(amountToBuy) == 25)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(0.25));
                BuyCupsMath();
            }
            else if (int.Parse(amountToBuy) == 50)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(1.54));
                BuyCupsMath();
            }
            else if (int.Parse(amountToBuy) == 100)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(2.88));
                BuyCupsMath();
            }
            else
            {
                Console.WriteLine("Invalid Entry Try Again.");
                BuyMoreItems();
            }

            BuyMoreItems();
        }


        public void BuyLemons()
        {
            Console.WriteLine("How many lemons would you like to buy? \n 10 for 96¢ \n 30 for $2.39 \n 75 for $4.43?");
            amountToBuy = Console.ReadLine().ToLower();

            if (int.Parse(amountToBuy) == 10)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(0.96));
                BuyLemonsMath();
            }
            else if (int.Parse(amountToBuy) == 30)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(2.39));
                BuyLemonsMath();
            }
            else if (int.Parse(amountToBuy) == 75)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(4.43));
                BuyLemonsMath();
            }
            else{
               Console.WriteLine("Invalid Entry Try Again.");
               BuyMoreItems();
            }

            BuyMoreItems();
        }

        public void BuySugar()
        {
            Console.WriteLine("How much sugar would you like to buy? \n 8 cups for 60¢ \n 20 cups for $1.73 \n 48 cups for $3.42?");
            amountToBuy = Console.ReadLine().ToLower();

            if (int.Parse(amountToBuy) == 8)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(0.60));
                BuySugarMath();
            }
            else if (int.Parse(amountToBuy) == 20)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(1.73));
                BuySugarMath();
            }
            else if (int.Parse(amountToBuy) == 48)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(3.42));
                BuySugarMath();
            }
            else
            {
                Console.WriteLine("Invalid Entry Try Again.");
                BuyMoreItems();
            }

            BuyMoreItems();

        }

        public void BuyIce()
        {
            Console.WriteLine("How many ice cubes would you like to buy? \n 100 for 75¢ \n 250 for $2.11 \n 500 for $3.69?");
            amountToBuy = Console.ReadLine().ToLower();

            if (int.Parse(amountToBuy) == 100)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(0.75));
                BuyIceMath();
            }
            else if (int.Parse(amountToBuy) == 250)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(2.11));
                BuyIceMath();
            }
            else if (int.Parse(amountToBuy) == 500)
            {
                Console.WriteLine("Your current balance is " + "$" + player.wallet.SubtractToWallet(3.96));
                BuyIceMath();
            }
            else
            {
                Console.WriteLine("Invalid Entry Try Again.");
                BuyMoreItems();
            }

            BuyMoreItems();

        }

        public void BuyLemonsMath()
        {
            for (int i = 0; i < int.Parse(amountToBuy); i++)
            {
                Lemon lemon = new Lemon();
                inventory.lemons.Add(lemon);
            }

            Console.WriteLine("You now have " + inventory.lemons.Count + " lemons");
        }


        public void BuySugarMath()
        {
            for (int i = 0; i < int.Parse(amountToBuy); i++)
            {
                Sugar sugar = new Sugar();
                inventory.sugar.Add(sugar);
            }
            Console.WriteLine("You now have " + inventory.sugar.Count + " cups of sugar");
        }

        public void BuyIceMath()
        {
            for (int i = 0; i<int.Parse(amountToBuy); i++)
            {
                Ice ice = new Ice();
                inventory.ice.Add(ice);
            }

            Console.WriteLine("You now have " + inventory.ice.Count + " cups of ice");
        }

        public void BuyCupsMath()
        {
            for (int i = 0; i < int.Parse(amountToBuy); i++)
            {
                Cups cups = new Cups();
                inventory.cups.Add(cups);
            }

            Console.WriteLine("You now have " + inventory.cups.Count + " cups");
            BuyMoreItems();
        }

    }
}
