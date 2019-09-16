using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tober_William_GroceryCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * William Tober
             * Week 1
             * 09/29/2018
             * MDV2330-O 01
             * Instructor: Dan Williams
             * */

            //Create an intro so the user gets an idea what this app is. 

            Console.WriteLine("Welcome to Grocery Calculator");
            Console.WriteLine("=====================================");

            //prompt the user for a question and then take their input
            //ask the user the quantity of each food item they have. 

            Console.WriteLine("Enter how many Apples you want, then press return!");
            string stringAppleCount = Console.ReadLine();

            //convert the user input from a string to an int using parse

            int intAppleCount = int.Parse(stringAppleCount);

            //show the user that their data has been registered

            Console.WriteLine(intAppleCount + " Apple(s) have been added to your cart.");

            //ask the user for the cost per apple

            Console.WriteLine("Enter the cost of each apple then press return.");

            //record the price inputted into a string

            string stringApplePrice = Console.ReadLine();

            //parse the string into a decimal

            decimal decimalApplePrice = decimal.Parse(stringApplePrice);

            //calculate total price of apple quantity*price

            decimal totalApplePrice = (decimalApplePrice * intAppleCount);

            //let the user know the data they've entered

            Console.WriteLine("You said the price for " + intAppleCount + " apple(s) is " + totalApplePrice.ToString("C") + "\r\n");
      

            //prompt the user for a question and then take their input
            //ask the user the quantity of each food item they have. 

            Console.WriteLine("Enter how many slices of steak you want, then press return.");
            string stringSteakCount = Console.ReadLine();

            //convert the user input from a string to an int using parse

            int intSteakCount = int.Parse(stringSteakCount);

            //show the user that their data has been registered

            Console.WriteLine(intSteakCount + " steak(s) have been added to your cart.");

            //ask the user for the cost per steak

            Console.WriteLine("Enter the cost of each steak then press return");

            //record the price inputted into a string

            string stringSteakPrice = Console.ReadLine();

            //parse the string into a decimal

            decimal decimalSteakPrice = decimal.Parse(stringSteakPrice);

            //calculate the total of quantity * price

            decimal totalSteakPrice = (decimalSteakPrice * intSteakCount);

            //let the user know the data they've entered

            Console.WriteLine("You said the price for " + intSteakCount + " steak(s) is " + totalSteakPrice.ToString("C") + "\r\n");

            


            //prompt the user for a question and then take their input
            //ask the user the quantity of each food item they have. 
            Console.WriteLine("Enter how many tubs of ice cream you want, then press enter.");
            string stringIcecreamCount = Console.ReadLine();
            //convert the user input from a string to an int using parse
            int intIcecreamCount = int.Parse(stringIcecreamCount);
            //show the user that their data has been registered
            Console.WriteLine(intSteakCount + " ice cream tub(s) have been added to your cart.");
            //ask the user for the cost of each ice cream tub
            Console.WriteLine("Enter the cost of each tub of Ice Cream then press return");
            //record the price inputted in to a string
            string stringIceCreamPrice = Console.ReadLine();
            //parse the string into a decimal
            decimal decimalIceCreamPrice = Decimal.Parse(stringIceCreamPrice);
            //create a total before tax of the quantity multiplied by the price
            decimal totalIceCreamPrice = (decimalIceCreamPrice * intIcecreamCount);
            //llet the user know the data they've entered
            Console.WriteLine("You said the price for " + intIcecreamCount + " Ice Cream tub(s) is " + totalIceCreamPrice.ToString("C") + "\r\n");

            //Ask the user for their sales tax, and save as string
            Console.WriteLine("Enter your state sales tax rate then press return.");
            string stringSalesTax = Console.ReadLine();
            //parse the string into a decimal
            decimal decimalSalesTax = decimal.Parse(stringSalesTax);
            decimalSalesTax /= 100;
            //relay the information to the user and then provide them the reciept
            Console.WriteLine("You indicated your state tax rate is " + decimalSalesTax + "%!");
            Console.WriteLine("Here is your groceries reciept.");
            Console.WriteLine("=======================================================");

            //get total of all food quantities * prices
            decimal totalAll = (totalApplePrice + totalIceCreamPrice + totalSteakPrice);

            decimal totalTax = totalAll * decimalSalesTax;

            decimal totalGrand = totalAll + totalTax;

            //give the values for the variables created above and display them as currency. 

            Console.WriteLine("Apple Total: " + totalApplePrice.ToString("C"));
            Console.WriteLine("Steak Total: " + totalSteakPrice.ToString("C"));
            Console.WriteLine("Ice Cream Total: " + totalIceCreamPrice.ToString("C"));
            

            Console.WriteLine("Your total without sales tax is: " + totalAll.ToString("C"));

            Console.WriteLine("Total Cost of Sales Tax: " + totalTax.ToString("C"));

            Console.WriteLine("Grand Total with Tax: " + totalGrand.ToString("C"));

            /* 
             * Test 1 
             * Apple Quantity 4
             * Apple Price $0.50
             * Steak Quantity 2
             * Steak Price $15.25
             * Ice Cream Quantity 1
             * Ice Cream Price $5.75
             * 
             * total cost of apple before tax $2.00
             * total cost of steak before tax $30.50
             * total cost of ice cream before tax $5.75
             * 
             * total sales tax on all items $2.68
             * total of all items including tax $40.93
             * 
             * Test 2
             * Apple Quantity 6
             * Apple Price $0.75
             * Steak Quantity 4
             * Steak Price $13.24
             * Ice Cream Quantity 2 
             * Ice Cream Price $3.75
             * 
             * total cost of apple before tax $4.50
             * total cost of steak before tax $52.96
             * total cost of ice cream before tax $7.50
             * 
             * total sales tax on all items $5.85
             * total of all items including tax $70.81
             * 
             */











        }
    }
}
