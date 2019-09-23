class Player {
    _name;
    _gold;
    _xp;

    _attack;
    _magic;
    _range;

    constructor(name, gold = 0, xp = 0, attack = 0, range = 0, magic = 0){
        this._name = name;
        this._gold = gold;
        this._xp = xp;
        this._attack = attack;
        this._magic = magic;
        this._range = range;

    }

    levelUp() {
        this._xp += 1;
    }
}
class Warrior extends Player {

    constructor(name) {
        super(name, 0, 0, 100, 0, 0);
    }
}

class Archer extends Player {
    constructor(name) {
        super(name, 0, 0,  0, 100, 0);
    }
}

class Mage extends Player {
    constructor(name) {
        super(name,0, 0, 0,0,100);
    }
}
//MAIN JAVASCRIPT SECTION


let programRunning = true;
let currentPlayer;

let userName = prompt("welcome to rpgtyper\n\n" +
    "please enter your character name: ").toLowerCase();

while(programRunning) {

    let classSelection = prompt("hello " + userName + "! welcome to rpgtyper! \n" +
        "there are several types of heros. \n" +
        "which hero are you? \n" +
        "1) warrior\n" +
        "2) mage\n" +
        "3) archer\n" +
        "\n" +
        "choose a class and press enter: ").toLowerCase();

    switch(classSelection) {
        case "1":
        case "one":
        case "warrior":
        case "melee":
        {
            currentPlayer = new Warrior(userName)
            programRunning = false;
        }
        break;

        case "2":
        case "two":
        case "mage":
        case "magic":
        {
            currentPlayer = new Mage(userName);
            programRunning = false;
        }
        break;

        case "3":
        case "three":
        case "archer":
        case "range":
        {
            currentPlayer = new Archer(userName);
            programRunning = false;
        }
        break;

        default: {
            alert("not a valid entry, please select a type of hero and press enter!");
        }
    }
}

alert(currentPlayer._name + " welcome to the game!\n" +
    "your stats are as follows: \n\n" +
    "attack - " + currentPlayer._attack + "\n" +
    "magic - " + currentPlayer._magic + "\n" +
    "range - " + currentPlayer._range + "\n\n" +
    "you will be our savior, when this game is done being written...");

programRunning = true;

while(programRunning){
    let input = prompt("press ENTER to fight or press X to exit: ").toLowerCase();

    switch(input){
        case "x":
        {
            alert("thank you for playing!\n" +
                "although, i don't think you did very much.");
            programRunning = false;
        }
        default:
        {
            currentPlayer.levelUp();

            alert("you gained 1 xp! \n" +
                "your total XP is " + currentPlayer._xp + "\n" +
                "press enter to go again!");
        }

    }

}