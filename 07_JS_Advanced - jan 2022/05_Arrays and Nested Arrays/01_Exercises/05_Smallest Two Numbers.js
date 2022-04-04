function demo(input) {
    let result = [];
    input.sort((a, b) => a - b);// сортираме във възходящ ред
    result = input.slice(0, 2);// взимаме 1вите два най- малки елемента
    return result.join(' ');
}

console.log(demo([30, 15, 50, 5]));