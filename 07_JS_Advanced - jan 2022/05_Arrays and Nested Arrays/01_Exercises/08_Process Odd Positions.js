function demo(input) {
    let filterInput = input.filter((n, i) => i % 2 != 0);
    let reducedInput = filterInput.map((n) => n + n);
    let reverseResult = reducedInput.reverse();
    
    return reverseResult.join(' ');
}

console.log(demo([10, 15, 20, 25]));
console.log(demo([3, 0, 10, 4, 7, 3]));