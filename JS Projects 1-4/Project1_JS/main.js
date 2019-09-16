/* Array Assignment from SDI */

let firstArray = [32, 20, 91, 49];

let secondArray =  [42, 120.30, 210.20, 32.50];

let firstArrayTotal = 0;
for (let i = 0; i < firstArray.length; i++)
{
    firstArrayTotal += firstArray[i];
}

alert("The total of the first array is: " + firstArrayTotal);

let secondArrayTotal = 0;
for (let i = 0; i < secondArray.length; i++)
{
    secondArrayTotal += secondArray[i];
}

alert("The total for the second Array is: " + secondArrayTotal);

let firstArrayAverage = (firstArrayTotal / firstArray.length);
alert("The average of the first array is: " + firstArrayAverage);

let secondArrayAverage = (secondArrayTotal / secondArray.length);
alert("The average of the second array is: " + secondArrayAverage);

let thirdArray = [0,0,0,0];

for (let i = 0; i < firstArray.length; i++)
{
    thirdArray[i] += firstArray[i];
    thirdArray[i] += secondArray[i];

    alert("The value for item " + (i+1) + " is " + thirdArray[i]);
}

//fix the mixed up string
let mixedUp = [ "universe is winning.", "erse trying to produce bigger an", "between software engineers striving to build bigger ", "d better idiots. So far, the ", "Programming today is a race ", "and better idiot-proof programs, and the univ" ];

let notMixedUp = (mixedUp[4] + mixedUp[2] + mixedUp[5] + mixedUp[1] + mixedUp[3] + mixedUp[0]);

alert(notMixedUp);
