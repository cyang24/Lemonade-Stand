using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class StoreClass
    {
        private double playerMoney = 20;
        public double itemCost;
        InventoryClass newInventory = new InventoryClass();

        public double PlayerMoney
        {
            get { return playerMoney; }
            set { playerMoney = value; }
        }

        public StoreClass()
        {
            DisplayInventoryAndBalance();
            BuyMoreItems();
        }

        public double BuyForInventory()
        {
            Console.WriteLine("\nWhat would you like to purchase? \na) cups \nb) lemons \nc) sugar \nd) ice\n");
            string userIput = Console.ReadLine();

            switch (userIput)
            {
                case "a":
                    BuyCups();
                    BuyMoreItems();
                    break;

                case "b":
                    BuyLemons();
                    BuyMoreItems();
                    break;

                case "c":
                    BuySugar();
                    BuyMoreItems();
                    break;
                case "d":
                    BuyIce();
                    BuyMoreItems();
                    break;

                default:
                    Console.WriteLine("Invalid Entry Try Again.");
                    BuyForInventory();
                    break;
            }

            return PlayerMoney;
        }

        public void DisplayInventoryAndBalance()
        {
            Console.WriteLine($"\nCurrent Balnce: $" {PlayerMoney} "\nCurrent Inventory \n cups" {newInventory.cups.Count} "\nlemons: " {newInventory.lemons.Count} "\nice sugar: " { newInventory.sugar.Count} "\nice cubes: " { newInventory.ice.Count});
        }

        public double CalculatePlayerPurchase(double PlayerMoney, double itemCost)
        {
            PlayerMoney = PlayerMoney - itemCost;
            return PlayerMoney;
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
            string amountToBuy = Console.ReadLine().ToLower();

            for (int i = 0; i < int.Parse(amountToBuy); i++)
            {
                CupsClass cups = new CupsClass();
                newInventory.cups.Add(cups);
            }
            Console.WriteLine("You now have " + newInventory.cups.Count + " cups");

            if (int.Parse(amountToBuy) == 25)
            {
                Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 0.82));
            }
            else if (int.Parse(amountToBuy) == 50)
            {
                Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 1.54));
            }
            else if (int.Parse(amountToBuy) == 100)
            {
                Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 2.88));
            }
            else
            {
                Console.WriteLine("Invalid Entry Try Again.");
            }

            BuyMoreItems();

        }


        public void BuyLemons()
        {
            Console.WriteLine("How many lemons would you like to buy? \n 10 for 96¢ \n 30 for $2.39 \n 75 for $4.43?");
            string amountToBuy = Console.ReadLine().ToLower();

            for (int i = 0; i < int.Parse(amountToBuy); i++)
            {
                LemonClass lemon = new LemonClass();
                newInventory.lemons.Add(lemon);
            }
            Console.WriteLine("You now have " + newInventory.lemons.Count + " lemons");

            if (int.Parse(amountToBuy) == 10)
            {
                Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 0.96));
            }
            else if (int.Parse(amountToBuy) == 30)
            {
                Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 2.39));
            }
            else if (int.Parse(amountToBuy) == 75)
            {
                Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 4.43));
            }
            else{
               Console.WriteLine("Invalid Entry Try Again.");
            }

            BuyMoreItems();
           
        }

        public void BuySugar()
        {
            Console.WriteLine("How much sugar would you like to buy? \n 8 cups for 60¢ \n 20 cups for $1.73 \n 48 cups for $3.42?");
            string amountToBuy = Console.ReadLine().ToLower();

            for (int i = 0; i < int.Parse(amountToBuy); i++)
            {
                SugarClass sugar = new SugarClass();
                newInventory.sugar.Add(sugar);
            }
            Console.WriteLine("You now have " + newInventory.sugar.Count + " cups of sugar");

            if (int.Parse(amountToBuy) == 8)
            {
                Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 0.60));
            }
            else if (int.Parse(amountToBuy) == 20)
            {
                Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 1.73));
            }
            else if (int.Parse(amountToBuy) == 48)
            {
                Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 3.42));
            }
            else
            {
                Console.WriteLine("Invalid Entry Try Again.");
            }

            BuyMoreItems();

        }

        public void BuyIce()
        {
            Console.WriteLine("How much sugar would you like to buy? \n 100 cups for 75¢ \n 250 cups for $2.11 \n 500 cups $3.69?");
            string amountToBuy = Console.ReadLine().ToLower();

            for (int i = 0; i < int.Parse(amountToBuy); i++)
            {
                IceClass ice = new IceClass();
                newInventory.ice.Add(ice);
            }
            Console.WriteLine("You now have " + newInventory.sugar.Count + " cups of ice");

            if (int.Parse(amountToBuy) == 8)
            {
                Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 0.60));
            }
            else if (int.Parse(amountToBuy) == 20)
            {
                Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 1.73));
            }
            else if (int.Parse(amountToBuy) == 48)
            {
                Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 3.42));
            }
            else
            {
                Console.WriteLine("Invalid Entry Try Again.");
            }

            BuyMoreItems();

        }



    }
}
