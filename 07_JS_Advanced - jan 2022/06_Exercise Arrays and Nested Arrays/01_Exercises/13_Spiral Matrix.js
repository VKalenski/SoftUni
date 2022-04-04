function demo(n) {
    var c = 1, min = 0, max = n - 1, x = 0, y = 0;
    const matrix = [];
    for (let i = 0; i < n; i++) { matrix.push([]) }
    while (c < n ** 2) {
        while (x < max) { matrix[y][x++] = c++ }
        while (y < max) { matrix[y++][x] = c++ }
        while (x > min) { matrix[y][x--] = c++ }
        min++;
        while (y > min) { matrix[y--][x] = c++ }
        max--;
    }
    matrix[y][x] = c;

    let result = '';
    for (let i = 0; i < matrix.length; i++) {
        for (let j = 0; j < matrix[i].length; j++) {
            result += matrix[i][j] + ' ';
        }
        result += '\n';
    }
    console.log(result);
}

demo(5);