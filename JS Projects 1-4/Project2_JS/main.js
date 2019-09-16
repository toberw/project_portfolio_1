/* Grocery calculator converted to javascript */

let userAppleCount = prompt("Welcome to grocery calculator!\n\n" +
    "Enter how many Apples you want, then press return: ");

let userAppleCountInt = parseInt(userAppleCount);

let userAppleCost = prompt(userAppleCountInt + "Apple(s) have been added to your cart.\n" +
    "Enter the cost of an apple and press enter: ");

let userAppleCostFloat = parseFloat(userAppleCost);
let userAppleTotalCost = userAppleCostFloat * userAppleCountInt;

alert("The total price of " + userAppleCountInt + " apple(s) is $" + userAppleTotalCost + ".");

let userSteakCount = prompt("Enter how many slices of steak you want, then press enter: ");
let userSteakCountInt = parseInt(userSteakCount);

let userSteakCost = prompt(userSteakCount + " steak(s) have been added to your cart.\n" +
    "Enter the cost of each steak, then press enter: ");
let userSteakCostFloat = parseFloat(userSteakCost);

let userSteakTotalCost = userSteakCostFloat * userSteakCountInt;

alert("The total price of " + userSteakCount + " steak(s) is $" + userSteakTotalCost + ".");

let userIceCreamCount = prompt("Enter how many tubs of ice cream tubs you want, then press enter: ");
let userIceCreamCountInt = parseInt(userIceCreamCount);

let userIceCreamPrice = prompt(userIceCreamCountInt + " ice cream tub(s) have been added to your cart. \n" +
    "Enter the cost of each ice cream tub and press enter: ");
let userIceCreamPriceFloat = parseFloat(userIceCreamPrice);
let userIceCreamPriceTotal = userIceCreamPriceFloat + userIceCreamCountInt;

alert("You said the price for " + userIceCreamCount + " ice cream tub(s) is $" + userIceCreamPriceTotal);

let userSalesTax = prompt("Enter the state sales tax rate then press return: ");
let userSalesTaxFloat = parseFloat(userSalesTax);
userSalesTaxFloat = userSalesTaxFloat/100;

let userTotal = userAppleTotalCost + userSteakTotalCost + userIceCreamPriceTotal;
let userTotalTax = userTotal * userSalesTaxFloat;
let userTotalWTax = userTotal + userTotalTax;

alert("Here is your grocery receipt!\n" +
    "-------------------\n" +
    "Total: " + userTotal + "\n" +
    "Total Tax: " + userTotalTax + "\n" +
    "Grand Total: " + userTotalWTax + "\n\n" +
    "Thank you for shopping!");



