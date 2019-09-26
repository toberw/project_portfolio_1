using System;
using System.Collections.Generic;

namespace RPGTyper
{
    public class Warrior : Player
    {
        public Warrior(string name, int gold = 0) : base(name, gold)
        {
            Item basicSword = new Weapon("sword", "stick with a pointy side.");
            Item basicArmor = new Armor("bronze armor", "it's not much but it'll do.");
            Item basicPotion = new Potion("health restore", "restores 20hp");
            //Preset Gear
            base.Gear.Add(basicSword);
            base.Gear.Add(basicArmor);
            //Preset Inventory
            base.Inventory.Add(basicPotion);
            base.Inventory.Add(basicPotion);
            base.Inventory.Add(basicPotion);


        }
    }
}
