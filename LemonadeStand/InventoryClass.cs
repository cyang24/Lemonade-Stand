using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class InventoryClass
    {   
        public List<LemonClass> lemons;
        public List<SugarClass> sugar;
        public List<IceClass> ice;
        public List<CupsClass> cups;

        public InventoryClass()
        {
            lemons = new List<LemonClass>();
            sugar = new List<SugarClass>();
            ice = new List<IceClass>();
            cups = new List<CupsClass>();
        }
    }
}
