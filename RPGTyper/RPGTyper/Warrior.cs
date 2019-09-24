using System;
using System.Collections.Generic;

namespace RPGTyper
{
    public class Warrior : Player
    {
        private override List<Item> _inventory = new List<Item>();

        public Warrior(string name, int gold = 0) : base(name, gold)
        {
            _inventory
        }
    }
}
