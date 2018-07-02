using System;
namespace LemonadeStand
{
    public class Wallet ////SOLID DESIGN PRINCIPAL - "S" Wallet Keeps track of funds and contains 2 methods one to add and one to subtract.

    {   private decimal playerMoney = 20;

        public decimal PlayerMoney
        {
            get { return playerMoney; }
            set { playerMoney = value; }
        }

        public Wallet()
        {
        }

        public decimal AddToWallet(decimal itemsSold) 
        {
            PlayerMoney = PlayerMoney + itemsSold;

            return PlayerMoney;

        }

        public decimal SubtractToWallet(decimal itemCost)
        {
            if (itemCost < PlayerMoney)
            {
                PlayerMoney = PlayerMoney - itemCost;
            }
            else if (itemCost > PlayerMoney)
            {
                Console.WriteLine("Sorry not enough money!!");
            }
            return PlayerMoney;
        }
    }   

}
