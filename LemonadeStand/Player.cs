using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public abstract class Player
    {

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
