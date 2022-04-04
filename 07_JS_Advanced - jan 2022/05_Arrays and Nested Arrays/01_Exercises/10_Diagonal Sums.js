function demo(matrix) {

    let primary = 0;
    let secondary = 0;

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            if (row === col) {
                primary += matrix[row][col];
            }

            if ((row + col) === (matrix.length - 1)) {
                secondary += matrix[row][col];
            }
        }
    }
    
    console.log(primary + ' ' + secondary);
}

demo([[20, 40],
[10, 60]]
);