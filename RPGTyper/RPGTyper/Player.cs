using System;
using System.Collections.Generic;

namespace RPGTyper
{
    abstract public class Player
    {
        private string _name;
        private int _gold;
        private int _xp;
        private int _hp;
        //did you win? 
        private bool _complete = false;
        //are you alive? 
        private bool _state = true;

        private List<Item> _inventory = new List<Item>();
        private List<Item> _geared = new List<Item>();

        public bool State
        {
            get { return _state; }
            set { _state = value; }
        }
        public bool Completed
        {
            get { return _complete; }
            set { _complete = value; }
        }
        public List<Item> Gear
        {
            get { return _geared; }
            set { _geared = value; }
        }
        public List<Item> Inventory
        {
            get { return _inventory; }
            set { _inventory = value; }
        }
        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }
        public int XP
        {
            get { return _xp; }
            set { _xp = value; }
        }
        public string Name
        {
            get { return _name; }
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
            _hp = 100;
        }
         
        public int PotionTotal()
        {
            int output = 0;

            foreach(Potion pot in _inventory)
            {
                output++;
            }

            return output;
        }
    }
}
