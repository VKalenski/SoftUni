function demo(name, population, treasury) {
    let info = {
        name,
        population,
        treasury,
        taxRate: 10,
        collectTaxes: function () {
            return this.treasury += this.population * this.taxRate;
        },
        applyGrowth: function (percentage) {
            return this.population *= 1 + (percentage / 100);
        },
        applyRecession: function (percentage) {
            return this.treasury *= 1 - (percentage / 100);
        }
    }

    return info;
}

// const city = 
//   demo('Tortuga',
//   7000,
//   15000);
// console.log(city);

const city =
    demo('Tortuga',
        7000,
        15000);
city.collectTaxes();
console.log(city.treasury);
city.applyGrowth(5);
console.log(city.population);