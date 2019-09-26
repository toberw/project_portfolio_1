using System;
using System.Collections.Generic;

namespace RPGTyper
{
    class Program
    {
        static Player currentPlayer;
        //declare the type of campeign
        static Quest quest = new Quest("dragons never die", "search for the lost dragon, alvarava!");
        static bool programRunning = true;

        static void Main(string[] args)
        {
            

            
            bool playedBefore = false;
            bool playedBeforeLoop = true; 

            while (programRunning)
            {
                //Createa  method to store this if statement and just return a player.. 
                if (!playedBefore)
                {
                    Console.Write("welcome to rpgwriter, you're on a quest to become the\n" +
                        "greatest hero that ever lived!\n\n" +
                        "what is your name hero?\n\n" +
                        "type your name and press enter:  ");

                    string playerName = Console.ReadLine().ToLower();

                    playerName = Validate.ValidateString(playerName, "please don't leave your name blank: ");

                    Console.Clear();

                    while (playedBeforeLoop)
                    {
                        Console.Write($"Hello {playerName}! Welcome to rpgwriter! \n" +
                        $"there are several types of heros.\n" +
                        "which hero are you? \n\n" +
                        "1) warrior\n" +
                        "2) mage\n" +
                        "3) archer\n" +
                        "\n" +
                        "choose a class and press enter: ");

                        string classChoice = Console.ReadLine().ToLower();
                        classChoice = Validate.ValidateString(classChoice, "please do not leave your class choice blank: ");

                        switch (classChoice)
                        {
                            case "1":
                            case "warrior":
                            case "one":
                            case "war":
                                {
                                    currentPlayer = new Warrior(playerName);
                                    playedBefore = true;
                                    playedBeforeLoop = false;
                                }
                                break;
                            case "2":
                            case "two":
                            case "mage":
                            case "magic":
                                {
                                    currentPlayer = new Mage(playerName);
                                    playedBefore = true;
                                    playedBeforeLoop = false;
                                }
                                break;
                            case "3":
                            case "three":
                            case "archer":
                            case "arrow":
                            case "range":
                                {
                                    currentPlayer = new Archer(playerName);
                                    playedBefore = true;
                                    playedBeforeLoop = false;
                                }
                                break;
                            default:
                                break;
                        }

                    }
                    Console.Clear();
                }

                Console.Write("menu Select: \n" +
                    "\n" +
                    "1. fight\n" +
                    "2. inventory\n" +
                    "3. character\n\n" +
                    "choose your next move and press return: ");

                string userInput = Console.ReadLine();
                Validate.ValidateString(userInput, "please don't leave your selection blank!");

                Console.Clear();
                switch(userInput)
                {
                    case "1":
                    case "one":
                    case "fight":
                        {
                            quest.BattleRoll(currentPlayer);
                        }
                        break;
                    case "2":
                    case "two":
                    case "inventory":
                        {
                            InventoryManager();
                        }
                        break;
                    case "3":
                    case "three":
                    case "character":
                        {

                        }
                        break;
                    default:
                        {
                            Console.WriteLine("please enter a valid entry selection, and press return.: ");
                        }
                        break;
                }

                //checks to see if the player has died or beat the main boss.
                
                
                if(currentPlayer.Completed != true)
                {
                    StatSheet();
                }
                Validate.Continue();
                StateCheck();

            }
        }
        static List<Item> InventoryManager()
        {
            List<Item> output = new List<Item>();
            bool programRunnin = true;
            /*
            Console.WriteLine($"{currentPlayer.Name}'s inventory\n" +
                $"------------------------");
            for (int i = 0; i < currentPlayer.Inventory.Count; i++)
            {
                Console.WriteLine($"{i+1}) {currentPlayer.Inventory[i].Name}\n" +
                    $"{currentPlayer.Inventory[i].Description}");
            }
            Console.WriteLine("\nequipped gear\n" +
                "------------------------");
            for (int i = 0; i < currentPlayer.Gear.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {currentPlayer.Gear[i].Name}\n" +
                    $"{currentPlayer.Gear[i].Description}");
            }
            Console.WriteLine("--------------------------------");*/
            while (programRunnin)
            {
                Console.Clear();
                Console.WriteLine("manage your inventory\n" +
                    "1) equip\n" +
                    "2) unequip\n" +
                    $"3) use potion ({currentPlayer.PotionTotal()})\n" +
                    "4) shop\n" +
                    "5) exit\n" +
                    "\n" +
                    "please select an option above: ");

                string userInput = Console.ReadLine();
                userInput = Validate.ValidateString(userInput, "please don't leave your selection blank: ");

                switch (userInput)
                {
                    case "1":
                    case "one":
                    case "equip":
                        {
                            bool met = false;
                            int armorCount = 0;
                            int weaponCount = 0;
                            int userLimit = 0;

                            List<Item> placeHolder = new List<Item>();

                            foreach (Armor arm in currentPlayer.Gear)
                            {
                                armorCount++;
                            }
                            foreach(Weapon wep in currentPlayer.Gear)
                            {
                                weaponCount++;
                            }

                            //conditional to find out what the player can equip. 
                            if (armorCount == 1 && weaponCount == 1)
                            {
                                Console.WriteLine("please un-equip your weapon and armor before putting more on!");
                                
                            } else if (armorCount == 1 && weaponCount != 1)
                            {
                                Console.WriteLine("you're unable to equip armor. please select which weapon to equip!");
                                userLimit = WeaponList();
                                foreach(Armor arm in currentPlayer.Inventory)
                                {
                                    placeHolder.Add(arm);
                                    currentPlayer.Inventory.Remove(arm);
                                }
                                foreach(Potion pot in currentPlayer.Inventory)
                                {
                                    placeHolder.Add(pot);
                                    currentPlayer.Inventory.Remove(pot);
                                }
                                met = true; 

                            } else if (armorCount != 1 && weaponCount == 1)
                            {
                                Console.WriteLine("you're unable to equip a weapon. please select armor to equip!");
                                userLimit = ArmorList();
                                foreach(Weapon wep in currentPlayer.Inventory)
                                {
                                    placeHolder.Add(wep);
                                    currentPlayer.Inventory.Remove(wep);
                                }
                                foreach(Potion pot in currentPlayer.Inventory)
                                {
                                    placeHolder.Add(pot);
                                    currentPlayer.Inventory.Remove(pot);
                                }
                                met = true;
                            }

                            if (met)
                            {
                                Console.Write("\nwhich piece of equipment would you like to equip?\n" +
                                "please select the correspending number for the equipment: ");

                                string input = Console.ReadLine();
                                input = Validate.ValidateString(input, "please don't leave your selection blank: ");

                                int inputInt = Validate.ValidateInt(input, "please enter a real number and try again: ", 1, userLimit);

                                currentPlayer.Gear.Add(currentPlayer.Inventory[inputInt]);
                                currentPlayer.Inventory.RemoveAt(inputInt);
                            }
                            
                            foreach (Item item in placeHolder)
                            {
                                currentPlayer.Inventory.Add(item);
                            }
                        }
                        break;
                    case "2":
                    case "two":
                    case "unequip":
                        {
                            Console.Write("which item would you like to unequip? ");

                            GearList();
                            Console.Write("\nplease select a number representing an item above: ");
                            string unequipInput = Console.ReadLine();
                            unequipInput = Validate.ValidateString(unequipInput, "please don't leave your entry blank");
                            int unequipInputInt = Validate.ValidateInt(unequipInput, "please enter a real number", 1, currentPlayer.Gear.Count);

                            currentPlayer.Inventory.Add(currentPlayer.Gear[unequipInputInt]);
                            currentPlayer.Gear.RemoveAt(unequipInputInt);
                        }
                        break;
                    case "3":
                    case "three":
                    case "use potion":
                    case "potion":
                        {

                        }
                        break;
                    case "4":
                    case "four":
                    case "shop":
                    case "store":
                        {
                            Console.WriteLine("welcome to the item shop!\n" +
                                "--------------------------------\n" +
                                "there is a special on potions right now.\n\n" +
                                "how many potions would you like to buy?: ");
                            userInput = Console.ReadLine();
                            int userInputInt = Validate.ValidateInt(userInput, "please enter a real number: ", 0);
                            Item basicPotion = new Potion("health restore", "restores 20 hp");

                            for (int i = 0; i < userInputInt; i++)
                            {
                                currentPlayer.Inventory.Add(basicPotion);
                            }

                        }
                        break;
                    case "5":
                    case "five":
                    case "exit":
                    case "quit":
                    case "stop":
                    case "x":
                        {
                            programRunnin = false;
                        }
                        break;
                }
                Validate.Continue();
            }

            return output;
        }
        static void StateCheck()
        {
            if (currentPlayer.State == false)
            {
                programRunning = false;
            } else if (currentPlayer.State != false)
            {
                programRunning = true;
                Console.WriteLine("You've survived another day, and get ready for the next day. ");
            }
        }
        static void StatSheet()
        {
            Console.WriteLine($"\nHP: {currentPlayer.HP}\n" +
                $"Gold: {currentPlayer.Gold}\n" +
                $"Total XP: {currentPlayer.XP}");
        }
        static void GearList()
        {
            //lists all the gear that can be worn by the player
            for (int i = 0; i < currentPlayer.Gear.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {currentPlayer.Gear[i].Name}\n" +
                    $"{currentPlayer.Gear[i].Name}");
            }
        }
        static int ArmorList()
        {
            int i = 0;
            //lists all the armor that can be worn by the player
            foreach(Armor arm in currentPlayer.Inventory)
            {
                Console.WriteLine($"{i + 1}) {arm.Name}\n" +
                    $"{arm.Description}");
                i++;
            }
            return i;
        }
        static int WeaponList()
        {
            //lists all the weapons taht can be worn by the player
            int i = 0;
            foreach(Weapon wep in currentPlayer.Inventory)
            {
                Console.WriteLine($"{i + 1}) {wep.Name}\n" +
                    $"{wep.Description}");
                i++;
            }
            return i; 
        }
    }
}
