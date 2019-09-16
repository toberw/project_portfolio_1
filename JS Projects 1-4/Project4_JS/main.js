/* Rewrite of the methods assignment in SDI */

//START OF PROBLEM #1
let usDollarRate = 1.16;

let euroString = prompt("How many euros would you like to convert?");
let euroFloat = parseFloat(euroString);

while (!parseFloat(euroString)){
    euroString = prompt("Please enter a real amount of Euros and press return: ")
}

let totalDollars = euroFloat * usDollarRate;

alert(euroFloat + " euros converted to dollars is $" + totalDollars);