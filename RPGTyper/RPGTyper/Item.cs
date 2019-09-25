using System;
namespace RPGTyper
{
    public class Item
    {

        private string _name;
        private string _description;

        public string Name
        {
            get { return _name; }
        }

        public string Description
        {
            get { return _description; }
        }

        public Item(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void Describe()
        {
            Console.WriteLine(_description);
        }
    }
}
