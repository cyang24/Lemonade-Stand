using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Inventory
    {   
     
        public List<Lemon> lemons;
        public List<Sugar> sugar;
        public List<Ice> ice;
        public List<Cups> cups;

        public Inventory()
        {
            lemons = new List<Lemon>();
            sugar = new List<Sugar>();
            ice = new List<Ice>();
            cups = new List<Cups>();
        }

    }

}
