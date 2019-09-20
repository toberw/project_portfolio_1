using System;

namespace RPGTyper
{
    class Program
    {
        static void Main(string[] args)
        {
            Player currentPlayer = new Player("John Doe");
            bool programRunning = true;

            while (programRunning)
            {
                Console.WriteLine("This is the start of things. ");

                while (Console.ReadKey().Key != ConsoleKey.X)
                {
                    Console.Clear();
                    currentPlayer.XP += 1;
                    Console.WriteLine($"Experience: {currentPlayer.XP}");
                }

                programRunning = false;


            }
        }
    }
}
