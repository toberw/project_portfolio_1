using System;
namespace RPGTyper
{
    public class Quest
    {
        private string _name;
        private string _dialog;

        public Quest(string name, string dialog)
        {
            _name = name;
            _dialog = dialog;
        }

        public void BattleRoll(Player player)
        {
            Random rnd = new Random();
            int roll = rnd.Next(100);
            int reward = 0;

            if (roll <= 1)
            {
                //THIS WIL HAVE DIALOG THAT WILL GET PULLED FROM FILEIO
                Console.WriteLine("you are unfortunate enough to end up fighting alvarava.\n" +
                    "he screams a teriffying screetch, it's then and only then you realize.\n" +
                    "this might be the end..\n");
                if(player.HP > 80)
                {
                    Console.WriteLine("you fought hard and you were able to defeat the dragon. Ending your quest.");
                    player.HP -= 30;
                    player.Completed = true;
                    player.Gold += 500;
                    player.State = false;

                } else if (player.HP < 80)
                {
                    Console.WriteLine("the dragon uses it's fire breath, you don't have what it takes to withstand the dragon breath.\n" +
                        "your body starts burning and everything goes black.");
                }
            } else
            {
                if (player.HP > 1)
                {
                    Console.WriteLine("you look at a baby dragon, it's still pretty mean looking.\n" +
                    "you manage to fight it");
                    player.Gold += 2;
                    player.HP -= 2;
                    player.XP += 4;
                } else if (player.HP < 1)
                {
                    Console.WriteLine("you look at a baby dragon, it's still pretty mean looking.\n" +
                    "you use your weapon but have no fight left in you.\n" +
                    "you Died.");
                }
                
            }
        }
    }
}
