using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tober_William_MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * William Tober
             * MDV2330-O
             * 09/29/2018
             * MadLibs
             */

            //Header for the code so the user knows what they're doing
            Console.WriteLine("Welcome to story time!  " );
            Console.WriteLine("================================================");

            //Prompt the user for an animal
            Console.WriteLine("Choose an animal and then press enter. ");
            //save the user input as a string
            string stringAnimal = Console.ReadLine();

            //Prompt the user for a name
            Console.WriteLine("Choose a name and then press enter. ");
            //save the user input as a string
            string stringName = Console.ReadLine();

            //Prompt the user for a adjective
            Console.WriteLine("Choose an adjective and then press enter. ");
            //save the user input as a string
            string stringAdjective = Console.ReadLine();

            //Prompt the user for a food item
            Console.WriteLine("Choose a food and then press enter. ");
            //save the user input as a string
            string stringFoodItem = Console.ReadLine();

            //Prompt the user for a year
            Console.WriteLine("Choose a year and then press enter. ");
            //save the user input as a string
            string stringYear = Console.ReadLine();

            //prompt the user for a random cost
            Console.WriteLine("Choose a cost and then press enter. ");
            //save the user input as a string
            string stringCost = Console.ReadLine();

            //prompt the user for a random number
            Console.WriteLine("Choose a number and then press enter. ");
            //save the user input as a string
            string stringNumber = Console.ReadLine();

            //PARSE AND ASSIGN ALL THE NUMBER VARIABLES INTO AN ARRAY

            //i chose decimal datatype because one of the variables was related to money and I don't believe we can create an array that includes multiple data types. 
            decimal[] arrayNumbers = new decimal[3];
            //parse the strings that are storing numbers into a decimal data type
            arrayNumbers[0] = decimal.Parse(stringYear); 
            arrayNumbers[1] = decimal.Parse(stringCost);
            arrayNumbers[2] = decimal.Parse(stringNumber);

            //create a  console.writeline that uses string concatenation with some of the string variables that I've defined above. 
            Console.WriteLine(stringName + " was a tiny " + stringAnimal + ".");
            Console.WriteLine(stringName + " liked to play with " + stringAdjective + " balls.");
            Console.WriteLine("On the summer of " + arrayNumbers[0] + " he ate " + arrayNumbers[2] + " " + stringFoodItem + " that only cost " + arrayNumbers[1]);

            //FIN





        }
    }
}
