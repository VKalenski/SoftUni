function demo(name, population, treasury) {
    let obj = {
        name,
        population,
        treasury
    }
    return obj;
}

console.log(demo('Tortuga',
    7000,
    15000));