using System;

namespace RPGTyper
{
    class Program
    {
        static Player currentPlayer;

        static void Main(string[] args)
        {
            
            bool programRunning = true;
            bool playedBefore = false;
            bool playedBeforeLoop = true; 

            while (programRunning)
            {
                //Createa  method to store this if statement and just return a player.. 
                if (!playedBefore)
                {
                    Console.Write("Welcome to RPGWriter, you're on a quest to become the\n" +
                        "greatest hero that ever lived!\n\n" +
                        "What is your name hero?\n\n" +
                        "Type your name and press enter:  ");

                    string playerName = Console.ReadLine().ToLower();

                    playerName = Validate.ValidateString(playerName, "Please don't leave your name blank: ");

                    Console.Clear();

                    while (playedBeforeLoop)
                    {
                        Console.Write($"Hello {playerName}! Welcome to RPGWriter! \n" +
                        $"There are several types of heros.\n" +
                        "Which hero are you? \n\n" +
                        "1) Warrior\n" +
                        "2) Mage\n" +
                        "3) Archer\n" +
                        "\n" +
                        "Choose a class and press enter: ");

                        string classChoice = Console.ReadLine().ToLower();
                        classChoice = Validate.ValidateString(classChoice, "Please do not leave your class choice blank: ");

                        switch (classChoice)
                        {
                            case "1":
                            case "warrior":
                            case "one":
                            case "war":
                                {
                                    currentPlayer = new Warrior(playerName);
                                    playedBefore = false;
                                    playedBeforeLoop = false;
                                }
                                break;
                            case "2":
                            case "two":
                            case "mage":
                            case "magic":
                                {
                                    currentPlayer = new Mage(playerName);
                                    playedBefore = false;
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
                                    playedBefore = false;
                                    playedBeforeLoop = false;
                                }
                                break;
                            default:
                                break;
                        }

                    }

                }

                Console.Write("Menu Select: \n" +
                    "\n" +
                    "1. Fight\n" +
                    "2. Quest\n" +
                    "3. Inventory\n" +
                    "4. Character\n\n" +
                    "Choose your next move and press return: ");

                string userInput = Console.ReadLine();
                Validate.ValidateString(userInput, "Please don't leave your selection blank!");


                switch(userInput)
                {
                    case "1":
                    case "one":
                    case "fight":
                        {

                        }
                        break;
                    case "2":
                    case "two":
                    case "quest":
                        {

                        }
                        break;
                    case "3":
                    case "three":
                    case "inventory":
                        {

                        }
                        break;
                    case "4":
                    case "four":
                    case "character":
                        {

                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Something went wrong, please enter your answer again: ");
                        }
                        break;
                }
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
