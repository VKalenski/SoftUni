function demo(input) {
    let firstNum = Number(input.shift());
    let lastNUm = Number(input.pop());

    return firstNum + lastNUm;
}

console.log(demo(['20', '30', '40']))