using System;
using System.Collections.Generic;

namespace RPGTyper
{
    public class Warrior : Player
    {
        List<Item> _inventory = new List<Item>();
        List<Item> _equipped = new List<Item>();

        public Warrior(string name, int gold = 0) : base(name, gold)
        {
            Item basicSword = new Weapon("sword", "Stick with a pointy side.");
        }
    }
}
