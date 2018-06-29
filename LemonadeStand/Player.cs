using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Player
    {
        
        public Wallet wallet = new Wallet();
        public Inventory inventory = new Inventory();
        public Recipe recipe;
        private string playerName = (Console.ReadLine());
        private decimal lemonadePrice;
        public int lemonadeRank;



        public decimal LemonadePrice
        {
            get { return lemonadePrice; }
            set { lemonadePrice = value; }

        }

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }

        }

        protected int recipeRating;

        public int RecipeRating
        {
            get { return recipeRating; }
            set { recipeRating = value; }
        }


        public Player()
        {


        }

        public void SetPrice_Recipe()
        {
            Console.WriteLine("What price would you like to sell your lemonade at?\n");

            LemonadePrice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("$" + LemonadePrice);
        }

        public void LemonadePriceRank()
        {
            if (decimal.ToDouble(LemonadePrice) < 0.10)
            {
                lemonadeRank = 0;
            }
            else if (decimal.ToDouble(LemonadePrice) >= 0.10 && decimal.ToDouble(LemonadePrice) <= 0.25)
            {
                lemonadeRank = 1;
            }
            else if (decimal.ToDouble(LemonadePrice) >= 0.25 && decimal.ToDouble(LemonadePrice) <= 0.50)
            {
                lemonadeRank = 2;
            }
            else if (decimal.ToDouble(LemonadePrice) >= 0.50 && decimal.ToDouble(LemonadePrice) <= 0.75)
            {
                lemonadeRank = 3;
            }
            else if (decimal.ToDouble(LemonadePrice) >= 0.75 && decimal.ToDouble(LemonadePrice) <= 1)
            {
                lemonadeRank = 4;
            }
               
        }
    }
}
