using System;
using System.Collections.Generic;

namespace RPGTyper
{
    public class Archer : Player
    {
        List<Item> _inventory = new List<Item>();
        List<Item> _equipped = new List<Item>();

        public Archer(string name, int gold = 0) : base(name, gold)
        {
        }
    }
}
