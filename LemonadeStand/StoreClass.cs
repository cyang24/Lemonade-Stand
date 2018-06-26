using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class StoreClass
    {
        //public int upadatedLemonsInventory;
        //public int upadatedSugarInventory;
        //public int upadatedCupsInventory;
        //public int upadatedIceInventory;
        private double playerMoney = 20;
        public double itemCost;
        List<LemonClass> lemons;
       

        private int lemonsCount = 0;
        private int sugarsCount = 0;
        private int cupsCount = 0;
        private int iceCount = 0;

        public int LemonsCount
        {
            get { return lemonsCount; }
            set { lemonsCount = value; }
        }

        public int SugarsCount
        {
            get { return sugarsCount; }
            set { sugarsCount = value; }
        }

        public int CupsCount
        {
            get { return cupsCount; }
            set { cupsCount = value; }
        }

        public int IceCount
        {
            get { return iceCount; }
            set { iceCount = value; }
        }
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
            Console.WriteLine("\nCurrent Balnce: $" + PlayerMoney);
            Console.WriteLine("\nCurrent Inventory:");
            Console.WriteLine("\ncups: " + CupsCount);
            Console.WriteLine("\nlemons: " + LemonsCount);
            Console.WriteLine("\nice sugar: " + SugarsCount);
            Console.WriteLine("\nice cubes: " + IceCount);
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

        public double BuyCups()
        {
            Console.WriteLine("How many cups would you like to buy? \n 25 cups for 82¢ \n 50 cups for $1.54 \n 75 cups for $2.88 \n");
            string amountToBuy = Console.ReadLine().ToLower();

            switch (amountToBuy)
            {
                case "25":
                    CupsCount = 25 + CupsCount;
                    Console.WriteLine("You now have " + CupsCount + " cups");
                    Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 0.82));
                    BuyMoreItems();
                    break;

                case "50":

                    CupsCount = 50 + CupsCount;
                    Console.WriteLine("You now have " + CupsCount + " cups");
                    Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 1.54));
                    BuyMoreItems();
                    break;

                case "75":

                    CupsCount = 75 + CupsCount;
                    Console.WriteLine("You now have " + CupsCount + " cups");
                    Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 2.88));
                    BuyMoreItems();
                    break;

                default:
                    Console.WriteLine("Invalid Entry Try Again.");
                    BuyCups();
                    break;
            }

            return PlayerMoney;

        }

        public double BuyLemons()
        {
            Console.WriteLine("How many lemons would you like to buy? \n 10 for 96¢ \n 30 for $2.39 \n 75 for $4.43?");
            string amountToBuy = Console.ReadLine().ToLower();

            switch (amountToBuy)
            {
                case "10":

                    LemonsCount = 10 + LemonsCount;
                    Console.WriteLine("You now have " + LemonsCount + " lemons");
                    Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 0.96));
                    BuyMoreItems();
                    break;

                case "30":

                    LemonsCount = 30 + LemonsCount;
                    Console.WriteLine("You now have " + LemonsCount + " lemons");
                    Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 2.39));
                    BuyMoreItems();
                    break;

                case "75":

                    LemonsCount = 75 + LemonsCount;
                    Console.WriteLine("You now have " + LemonsCount + " lemons");
                    Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 4.43));
                    BuyMoreItems();
                    break;

                default:
                    Console.WriteLine("Invalid Entry Try Again.");
                    BuyCups();
                    break;
            }

            return PlayerMoney;
        }


        public double BuySugar()
        {
            Console.WriteLine("How many cups would you like to buy? \n  8 cups for 60¢ \n 20 cups for $1.73 \n 48 cups for $3.42\n");
            string amountToBuy = Console.ReadLine().ToLower();

            switch (amountToBuy)
            {
                case "8":
                    SugarsCount = 8 + SugarsCount;
                    Console.WriteLine("You now have " + SugarsCount + " cups of sugar");
                    Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 0.60));
                    BuyMoreItems();
                    break;

                case "20":

                    SugarsCount = 20 + SugarsCount;
                    Console.WriteLine("You now have " + SugarsCount + " cups of sugar");
                    Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 1.73));
                    BuyMoreItems();
                    break;

                case "48":

                    SugarsCount = 48 + SugarsCount;
                    Console.WriteLine("You now have " + SugarsCount + " cups of sugar");
                    Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 3.42));
                    BuyMoreItems();
                    break;

                default:
                    Console.WriteLine("Invalid Entry Try Again.");
                    BuyCups();
                    break;
            }

            return PlayerMoney;
        }

            public double BuyIce()
            {
                Console.WriteLine("How much Ice would you like to buy? \n  100 bags for 75¢ \n 250 bags for $2.11 \n 500 bags for $3.69\n");
                string amountToBuy = Console.ReadLine().ToLower();

                switch (amountToBuy)
                {
                    case "100":
                        SugarsCount = 100 + SugarsCount;
                        Console.WriteLine("You now have " + SugarsCount + " bags of sugar");
                        Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 0.75));
                        BuyMoreItems();
                        break;

                    case "250":

                        SugarsCount = 250 + SugarsCount;
                        Console.WriteLine("You now have " + SugarsCount + " bags of sugar");
                        Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 2.11));
                        BuyMoreItems();
                        break;

                    case "500":

                        SugarsCount = 500 + SugarsCount;
                        Console.WriteLine("You now have " + SugarsCount + " bags of sugar");
                        Console.WriteLine("Your current balance is " + "$" + CalculatePlayerPurchase(PlayerMoney, 3.69));
                        BuyMoreItems();
                        break;

                    default:
                        Console.WriteLine("Invalid Entry Try Again.");
                        BuyCups();
                        break;
                }

                return PlayerMoney;
        }

        //public void CreateLemon
        //    {
        //        lemons = new List<LemonClass>; 

        //        for (int i, int = 10, i++)
        //        {
        //        lemons += int i;
        //        }
        //    }
        //}

        //public void SetInventoryList()
        //{
        //    List<string> inventoryItems = new List<string>();

        //    inventoryItems.Add ("Lemonade");
        //    inventoryItems.Add ("Sugar");
        //    inventoryItems.Add ("Ice");
        //    inventoryItems.Add("Cups");

        //}

        //public void GetInventoryList()
        //{
        //    List<String> inventoryList = SetInventoryList();
        //}

    }
}
