let Player = class {
    let _name;
    let _gold = 0;
    let _xp = 0;

    constructor(name, gold = 0){
        this._name = name;
        this._gold = gold;
    }
}





//MAIN JAVASCRIPT SECTION
let programRunning = true;

console.log("Welcome to RPGTyper\n\n" +
    "Please enter your character name: ");
let userName = readline();

while(programRunning) {
    console.log("Hello " + userName + "! Welcome to RPGWriter! \n" +
        "There are several types of heros. \n" +
        "Which hero are you? \n" +
        "1) Warrior\n" +
        "2) Mage\n" +
        "3) Archer\n" +
        "\n" +
        "Choose a class and press enter: ");
    let classSelection = readline();

    switch(classSelection) {
        case "1":
        case "one":
        case "warrior":
        case "melee":
        {

        }
        break;

        case "2":
        case "two":
        case "mage":
        case "magic":
        {

        }
        break;

        case "3":
        case "three":
        case "archer":
        case "range":
        {

        }
        break;

        default: {
            console.log("Not a valid entry, please select a type of hero and press enter: ");
        }

        Console.clear();
    }
}