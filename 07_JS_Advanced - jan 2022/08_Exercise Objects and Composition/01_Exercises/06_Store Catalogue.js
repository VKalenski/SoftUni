function demo(array) {
    let firstLetter = '';
    let obj = {};
    for (let i = 0; i < array.length; i++) {

        let sorted = array.sort((a, b) => a.localeCompare(b));

        let [product, price] = sorted[i].split(' : ');
        obj[product] = price;

        if (firstLetter !== sorted[i][0]) {
            console.log(sorted[i][0]);
        }

        console.log(`  ${product}: ${obj[product]}`);
        firstLetter = sorted[i][0];
    }
}

demo(['Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10']);