using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class SellerClass : PlayerClass
    {
        public int popularity;
        public int makeRecipe;
        public int money;

        public SellerClass()
        {
            StoreClass Inventory = new StoreClass();
        }
    }   

}
