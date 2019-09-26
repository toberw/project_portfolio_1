using System;
namespace RPGTyper
{
    public class Validate
    {

        public static int ValidateInt(string input, string input2 = "Error, Please enter a valid intereger. ", int min = 0, int max = 0)
        {
            int output;

            if (min == 0 && max == 0)
            {
                while (!(int.TryParse(input, out output)))
                {
                    Console.Write(input2);
                    input = Console.ReadLine().ToLower();
                }
            }
            else
            {
                while (!(int.TryParse(input, out output) && output >= min && output <= max))
                {
                    Console.Write(input2);
                    input = Console.ReadLine().ToLower();
                }
            }

            return output;
        }

        public static string ValidateString(string input, string input2)
        {
            string validatedString = input;
            bool isValidationRunning = true;
            while (isValidationRunning)
            {
                if (String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input))
                {
                    Console.Write(input2);
                    input = Console.ReadLine().ToLower();
                }
                else
                {
                    validatedString = input;
                    isValidationRunning = false;
                }
            }
            return validatedString;
        }


        public static void Continue()
        {
            Console.Write("\nPress any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
        
    }
}
