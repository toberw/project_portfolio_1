using System;
using System.Collections.Generic;

namespace RPGTyper
{
    abstract public class Player
    {
        private string _name;
        private int _gold;
        private int _xp;

        List<Item> _inventory = new List<Item>();

        public int XP
        {
            get { return _xp; }
            set { _xp = value; }
        }

        public int Gold
        {
            get { return _gold; }
            set { _gold = value; }
        }

        public Player(string name, int gold = 0)
        {
            _name = name;
            _gold = gold;
            _xp = 0;
        }

        public void Gains()
        {
            _xp++;
        }
        public void UltraGains()
        {
            _xp += 10;
        }
        public virtual void Attack()
        {
            Random rnd = new Random();
            int rndSelect = rnd.Next(100);

            if (rndSelect < 25 && rndSelect > 0)
            {
                Console.WriteLine("I've attacked with my main attack, Arg!");
            } else if (rndSelect > 25 && rndSelect < 50)
            {
                Console.WriteLine("I've attacked with a slightly stronger attack!");
            } else if (rndSelect > 50 && rndSelect < 75)
            {
                Console.WriteLine("You've acticated my trap card! Peasent!");
            } else if (rndSelect > 75 && rndSelect < 100)
            {
                Console.WriteLine(_name + " uses sword bash, their ultimate ability!");
            }
        }
        public void Inventory()
        {
            for(int i = 0; i < _inventory.Count; i++)
            {
                Console.WriteLine((i + 1) + ") " + _inventory[i].Name);
            }
        }
    }
}
