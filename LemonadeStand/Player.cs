using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Player
    {
        public Recipe recipe = new Recipe();
        public Wallet wallet = new Wallet();
        public Inventory inventory = new Inventory();
        private double lemonadePrice;

        protected string playerName = (Console.ReadLine());


        public double LemonadePrice
        {
            get { return lemonadePrice; }
            set { LemonadePrice = value; }

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
            LemonadePrice = int.Parse(Console.ReadLine());

            recipe.MakeRecipe();
        }
    }
}
