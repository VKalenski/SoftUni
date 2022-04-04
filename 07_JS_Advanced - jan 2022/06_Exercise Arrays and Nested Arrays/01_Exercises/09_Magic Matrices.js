function demo(array) {
    let rowSums = [];
    let colSums = [];

    let isEqual = true;

    let sum = 0;

    let firstRowSum = array[0].reduce((a, b) => a + b);

    for (let i = 0; i < array.length; i++) {
        rowSums.push(array[i].reduce((a, b) => a + b));
    }

    for (let i = 0; i < array.length; i++) {
        if (firstRowSum != array[i].reduce((a, b) => a + b)) {
            isEqual = false;
        }
    }

    for (let i = 0; i < array.length; i++) {
        sum = 0;
        for (let j = 0; j < array[i].length; j++) {
            if (j >= array.length) {
                rowSums.push(0);
                break;
            }
            else {

                sum += Number(array[j][i]);
            }
        }
        colSums.push(sum);
    }

    for (let row of rowSums) {
        for (let col of colSums) {
            if (row !== col) {
                isEqual = false;
            }
        }
        break;
    }
    if (isEqual) {
        return true;
    }
    else {
        return false;
    }
}

// console.log(demo([[4, 5, 6],
//       [6, 5, 4],
//       [5, 5, 5]]));

console.log(demo([[11, 32, 45],
[21, 0, 1],
[21, 1, 1, 1]]));