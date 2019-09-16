using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tober_William_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             William Tober
             MDV2330-O
             09/30/2018
             Arrays Assignment
             */

            //Create your own project and call it Lastname_Firstname_Arrays
            //Copy this code inside of this Main section into your Main Section
            //Work through each of the sections

            /* 
              -Use the 2 arrays below
              -Do Not Re-Declare or Re-Define the elements inside of it.
            */


            //This is the Declare and Definition of the 2 Starting Number Arrays
            //Notice the differet ways to create an array.
            //Both are correct!

            int[] firstArray = new int[4];
            firstArray[0] = 34;
            firstArray[1] = 20;
            firstArray[2] = 91;
            firstArray[3] = 49;

            double[] secondArray = new double[4] { 42, 120.30, 210.20, 32.50 };


            /*
              -Find the total sum of each of the 2 individual arrays  
              -Store each sum in a variable and output that variable to console
              -Be sure to double check them with a calculator.
              -Do not assume the computer will give you the correct output!
              */

            //Adding each item in the first array. 
            double firstArrayTotal = (firstArray[0] + firstArray[1] + firstArray[2] + firstArray[3]);

            //print the total of the first array
            Console.WriteLine("The total of the first array is: " + firstArrayTotal);

            //adding each item in the second array
            double secondArrayTotal = (secondArray[0] + secondArray[1] + secondArray[2] + secondArray[3]);

            Console.WriteLine("the total of the second array is: " + secondArrayTotal);



            /*
              -Find the average value of each of the 2 individual arrays
              -Store each average in a variable and output that variable to console
              -Be sure to double check them with a calculator.
              -Do not assume the computer will give you the correct output!
              -You should be using the total variable created early!
              */

            //I used the previously calculated totals and divided them by the number of items in the array. 

            double firstArrayAverage = (firstArrayTotal / 4);

            //Write to console the average of the first array
            Console.WriteLine("The average of the items in the first array is: " + firstArrayAverage);

            //use the previous total to find the total of the second array and divide it by the number of items in that array

            double secondArrayAverage = (secondArrayTotal / 4);

            //Write to console the average of the numbers in the second array

            Console.WriteLine("The average of the items in the second are is: " + secondArrayAverage);



            /*
               Create a 3rd number array.  
               The values of this array will come from the 2 given arrays.
                -You will take the first item in each of the 2 number arrays, add them together and then store this sum inside of the new array.
                -For example Add the index#0 of array 1 to index#0 of array2 and store this inside of your new array at the index#0 spot.
                    -This would make the first element of this array = 42+ 34 = 76
                -Repeat this for each index #.
                -Do not add them by hand, the computer must add them.
                -Do not use the numbers themselves, use the array elements.
                -After you have the completed new array, output each element one at a time to the Console.
             */

            //Your code for the 3d Array goes here

            //declare the datatype of the new array, I chose double because given the values of the int's they would transfer into a double but the
            //decimal numbers in the double would not transfer into an INT
            double[] thirdArray = new double[4];

            thirdArray[0] = (firstArray[0] + secondArray[0]);
            thirdArray[1] = (firstArray[1] + secondArray[1]);
            thirdArray[2] = (firstArray[2] + secondArray[2]);
            thirdArray[3] = (firstArray[3] + secondArray[3]);

            //Log to console the values of each items in the array
            //the pdf stated that I was supposed to output onto one line
            //I opted to listen to what the code says.. because code is law 
            Console.WriteLine("The value for the first item in the third array is: " + thirdArray[0]);
            Console.WriteLine("The value for the second item in the third array is: " + thirdArray[1]);
            Console.WriteLine("The value for the third item in the third array is: " + thirdArray[2]);
            Console.WriteLine("The value for the fourth item in the third array is: " + thirdArray[3]);


            /*
               Given the array of strings below named MixedUp.  
               You must create a string variable that puts the items in the correct order to make a complete sentence 
               that is a famous phrase by Rick Cook.
                -Use each element in the array, do not re-write the strings themselves.
                - Do Not Re-Declare or Re-Define the elements inside of it.
                -Concatenate them in the correct order to form a sentence.
                -Store this new sentence string inside of a string variable you create.
                -Output this new string variable to the console.
             */

            //Declare and Define The String Array
            string[] MixedUp = new string[] { "universe is winning.", "erse trying to produce bigger an", "between software engineers striving to build bigger ", "d better idiots. So far, the ", "Programming today is a race ", "and better idiot-proof programs, and the univ" };

            //declare the string variable to 
            string notMixedUp = (MixedUp[4] + MixedUp[2] + MixedUp[5] + MixedUp[1] + MixedUp[3] + MixedUp[0]);

            //Write the new string variable to console and show that it is correct
            Console.WriteLine(notMixedUp);




        }
    }
}
