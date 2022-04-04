function demo (array) {
    
    let sum = 0;
    for (let i = 0; i < array.length; i++) {
        sum += array[i];
    }
 
    let inverseValuesSum = 0;
 
    for (let i = 0; i < array.length; i++) {
        inverseValuesSum += 1 / array[i];
    }
 
    let stringConcat = '';
    for (let i = 0; i < array.length; i++) {
        stringConcat += array[i];
    }
 
    console.log(sum);
    console.log(inverseValuesSum);
    console.log(stringConcat);
}
demo([1, 2, 3]);
// let aggregateElements = (array) => {
//     let numbersArray = array.map(Number);
//     let sum = numbersArray.reduce((a, b) => a + b);
 
//     let inverseValuesSum = 0;
 
//     for (let i = 0; i < numbersArray.length; i++) {
//         inverseValuesSum += 1 / numbersArray[i];
//     }
 
//     let stringConcat = numbersArray.join('');
 
//     console.log(sum);
//     console.log(inverseValuesSum);
//     console.log(stringConcat);
// }
// aggregateElements([1, 2, 3]);