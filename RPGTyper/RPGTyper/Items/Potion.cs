using System;
namespace RPGTyper
{
    public class Potion : Item
    {
        private int _heal = 20;

        public int Heal
        {
            get { return _heal; }
        }

        public Potion(string name, string description) : base(name, description)
        {

        }
    }
}
