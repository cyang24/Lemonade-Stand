using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Player
    {   
        public Recipe recipe = new Recipe();
        public Wallet wallet = new Wallet();
        public Inventory inventory = new Inventory();

        protected string playerName = (Console.ReadLine());

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



    }
}
