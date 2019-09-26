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

        public int BattleRoll(Player player)
        {
            Random rnd = new Random();
            int roll = rnd.Next(100);
            int reward = 0;

            if (roll <= 1)
            {
                //THIS WIL HAVE DIALOG THAT WILL GET PULLED FROM FILEIO
                Console.WriteLine("You are unfortunate enough to end up fighting Alvarava.\n" +
                    "He screams a teriffying screetch, it's then and only then you realize.\n" +
                    "You're dead.");
                if(player.HP > 80)
                {
                    Console.WriteLine("You fought hard and you were able to defeat the dragon. Ending your quest.");
                    player.HP = -30;
                    player.Completed = true;
                    player.XP =+ 500;
                    player.State = true;

                } else if (player.HP < 80)
                {
                    Console.WriteLine("The dragon uses it's fire breath, you don't have what it takes to withstand the dragon breath.\n" +
                        "Your body starts burning and everything goes black.");
                }
            } else
            {

            }

            return reward;
        }
    }
}
