using System;

namespace RPGTyper
{
    public class Player
    {
        private string _name;
        private int _gold;
        private int _xp;

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

        
    }
}
