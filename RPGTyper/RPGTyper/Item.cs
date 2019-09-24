using System;
namespace RPGTyper
{
    abstract public class Item
    {

        private string _name;
        private string _description;
        //1 - weapon, 2 - armor, 3 - cape, 4 - shield, 5 - misc

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public Item(string name, string description)
        {
            _name = name;
            _description = description;

        }

        public void Descript()
        {
            Console.WriteLine(_description);
        }
    }
}
