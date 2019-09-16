/** Create by william tober on 09/10/2019 **/

// Mad Libs Project From Scalable Data Infrastructure
//Console.Log is writing the console

//Header for code so the user knows what's going on.

let userAnimal = prompt("Welcome to story time! \n" +
    "\n\n" +
    "Type an animal and then press enter: ");
let userName = prompt("Choose a name and then press enter: ");
let userAdjective = prompt("Type an adjective and then press enter: ");
let userFoodItem = prompt("Type a food and press enter: ");
let userYear = prompt("Type a year and then press enter: ");
let userCost = prompt("Type a cost and then press enter: ");
let userNumber = prompt("Type a random and then press enter: ");

//Parse and assign all the number variables into an array
let arrayNumbers = [parseFloat(userYear), parseFloat(userCost), parseFloat(userNumber
)];


alert(userName + " was a tiny " + userAnimal + ".\n" +
    userName + " liked to play with " + userAdjective + " balls.\n" +
    "On the summer of " + arrayNumbers[0] + " he ate " + arrayNumbers[2] + " " + userFoodItem + "'s" + " that only cost " + "$" + arrayNumbers[1]);

