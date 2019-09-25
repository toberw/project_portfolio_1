using System;
using System.Collections.Generic;

namespace RPGTyper
{
    public class Mage : Player
    {
        List<Item> _inventory = new List<Item>();
        List<Item> _equipped = new List<Item>();

        public Mage(string name, int gold = 0) : base(name, gold)
        {
        }
    }
}
