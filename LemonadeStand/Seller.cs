using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Seller : Player
    {
        public int popularity;
        public int makeRecipe;
        private double playerMoney = 20;

        public double PlayerMoney
        {
            get { return playerMoney; }
            set { playerMoney = value; }
        }
      

        public Seller()
        {
            Store store = new Store();
        }
    }   

}
