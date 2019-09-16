using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tober_William_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /* William Tober
             * 10/14/2018
             * MDV2330-O 01
             * Methods
             * */

            //START OF PROBLEM #1

            //introduce the currency converter
            Console.WriteLine("----========[Currency Converter]========----");

            //Ask the user how many euros they want to convert
            Console.WriteLine("How many euros would you like to convert?");

            //translate the users input into a string variable
            String euroString = Console.ReadLine();

            //declare a variable for try parse
            Decimal euroDecimal;
            
            //validate the users input
            while (!(decimal.TryParse(euroString, out euroDecimal)) || euroDecimal < 0)
            {
                Console.WriteLine("Please enter valid number of euros to convert, then press enter.");
                euroString = Console.ReadLine();
            }

            //Call a method in a variable to obtain the converted value

            Decimal convertedDecimal = Converter(euroDecimal);

            //report to the user the value of their euros in dollars.  
            Console.WriteLine("{0} euros converted to dollars is {1} \r\n", euroDecimal, convertedDecimal.ToString("C"));

            /*Test # 1
             * Euros - 5.50
             * Results - "5.50 euros convered to dollars is $6.38"
             * 
             * Test # 2
             * Euros - 15.32 
             * Results - "15.32 euros converted to dollars is $17.77"
             * 
             * Test # 3 
             * Euros - 20
             * Results - "15.32 euros convered to dollars is $23.20 "
             * 
             * */


            //END OF PROBLEM #1
            //START OF PROBLEm #2

            //declare an array for the names of the planets. 
            String[] planetNames = new String[] { null, "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptun" };
            Double[] planetMultiplier = new Double[] { 0, 0.38, 0.91, 1, 0.38, 2.34, 0.93, 0.92, 1.12 };
            //Introduce the application to the user so they know what they're are doing
            Console.WriteLine("Welcome to the Space Weight Converter!");

            //Ask the user for their weight in pounds.
            Console.WriteLine("Please type in your weight in pounds!");
            //record the user input into a string
            String weightString = Console.ReadLine();

            //declare a variable to record the user input and try parse later
            Double weightDouble;

            //verify that the user input is valid and if not ask them again
            while (!(double.TryParse(weightString, out weightDouble)) || weightDouble < 0)
            {
                //askt he user to input their answer again
                Console.WriteLine("Please enter your weight in pounds, then press enter.");
                weightString = Console.ReadLine();

            }

            //Ask the user for what planet they would like their weight to be converted to.
            Console.WriteLine("Please choice a planet you would liek to be converted on. Type the cumber that correlates to your planet.");
            Console.WriteLine("1-MERCURY, 2-VENUS, 3-EARTH, 4-MARS, 5-JUPITER, 6-SATURN, 7-URANUS, 8-NEPTUNE");

            //store the users response into a string varaible
            String selectionString = Console.ReadLine();

            //declare a variable to parse it to. 
            SByte selectionSByte;

            while (!(SByte.TryParse(selectionString, out selectionSByte)) || selectionSByte <= 0 || selectionSByte >= 9)
            {
                //prompt the user for the input again
                Console.WriteLine("Please enter your selection then press return.");
                selectionString = Console.ReadLine();
            }

            //Thank the user for selecting a planet correctly. 
            Console.WriteLine("Thank you for typing {0} as your planet choice.", selectionSByte);

            //use the function below to calculate the weight after the conversion. 
            //reference the array
            Double convertedWeight = WeightConverter(weightDouble, planetMultiplier[selectionSByte]);

            //Let the user know the values that got calculated and how much they weight on that planet
            if (planetNames[selectionSByte] != planetNames[3])
            {
                Console.WriteLine("On Earth you weight {0}lbs, but on {1} you would weigh {2}lbs.", weightDouble, planetNames[selectionSByte], convertedWeight);
            } else
            {
                Console.WriteLine("On Earth you weigh {0}lbs.", weightDouble);
            }

            /* Test # 1 
             * Weight - 160
             * Selection 6
             * Results - "On Earth you weight 160lbs, but on Saturn you would weigh 148.8lbs."
             * 
             * Test # 2
             * Weight - 210
             * Selection 9
             * Reprompted for valid choice, 5 seleected. 
             * Results - "On Earth you weight 210lbs, but on Jupiter you would weigh 491.4lbs."
             * 
             * Test # 3 
             * Weight - 235
             * Selection - 3
             * Results - "On Earth you weight 235lbs."
             * */

            //END OF PROBLEM #2
            //START OF PROBLEM #3

            //Declare the hardcoded arrays for problem 3
            //int[] firstArray = new int[] { 4, 65, 32, 42, 12 };
            //int[] secondArray = new int[] { 1, 2, 5, 6, 9 };

            //int[] firstArray = new int[] {54, 125, 96, 72, 45, 67};
            //int[] secondArray = new int[] {87, 122, 145, 65, 3, 800};

            int[] firstArray = new int[] {200, 321, 72, 36, 24, 25};
            int[] secondArray = new int[] {125, 200, 325, 25, 20, 92};

            //create the four loop to cycle through the arrays and use the function to do the math.
            for (int i = 0; i < firstArray.Length; i++)
            {
                int calculatedArrays = arrayCalculator(firstArray[i], secondArray[i]);
                Console.WriteLine("{0} - {1} is {2}", firstArray[i], secondArray[i], calculatedArrays);
            }

            /*Test # 1
             * First array - { 4, 65, 32, 42, 12 };
             * Second array - { 1, 2, 5, 6, 9 };
             * Results
             * "4 - 1 is 3"
             * "65 - 2 is 63"
             * "32 - 5 is 27"
             * "42 - 6 is 36"
             * "12 - 9 is 3"
             * 
             * Test # 2
             * First Array - {54, 125, 96, 72, 45, 67};
             * Second Array - {87, 122, 145, 65, 3, 800};
             * Results
             * "54 - 87 is -33"
             * "125 - 122 is 3"
             * "96 - 145 is -49"
             * "72 - 65 is 7"
             * "45 - 3 is 42"
             * "67 - 800 is -733"
             * 
             * Test # 3
             * First Array - {200, 321, 72, 36, 24, 25};
             * Second Array - {125, 200, 325, 25, 20, 92};
             * Results
             * "200 - 125 is 75"
             * "321 - 200 is 121"
             * "72 - 325 is -253"
             * "36 - 25 is 11"
             * "24 - 20 is 4"
             * "25 - 92 is -67"
             * */
        }
        //declare a function that uses parameters capable of utilizing the two array values
        public static int arrayCalculator(int arrayOne, int arrayTwo)
        {
            //do the calculations of the two array parameters
            int calculatedArrays = arrayOne - arrayTwo;
            //return the data of the calculated arrays
            return calculatedArrays;
        }
        

        public static Double WeightConverter(Double userWeight, Double planetMultiplier)
        {
            //calculate the users weight on that plenet with the transmitted multiplier
            Double convertedWeight = userWeight * planetMultiplier;

            //return the value converted Weight
            return convertedWeight;

        }




        //declare a method that has the paramater for one value, i.e. how many euros are we converting
        public static decimal Converter(Decimal euroAmount)
        {
            //what is the current conversion rate of EURO to USD
            decimal usDollarRate = 1.16m;

            //declare a variable to store and calculate total dolalrs
            decimal totalDollars = euroAmount * us"DollarRate;

            //return the totalDollars variable
            return totalDollars;
        }
    }
}
