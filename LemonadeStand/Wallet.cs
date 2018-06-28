using System;
namespace LemonadeStand
{
    public class Wallet

    {   private double playerMoney = 20;

        public double PlayerMoney
        {
            get { return playerMoney; }
            set { playerMoney = value; }
        }

        public Wallet()
        {
        }

        public double AddToWallet(double itemsSold)
        {
            PlayerMoney = PlayerMoney + itemsSold;

            return PlayerMoney;

        }

        public double SubtractToWallet(double itemCost)
        {
            PlayerMoney = PlayerMoney - itemCost;

            return PlayerMoney;

        }
    }   

}
