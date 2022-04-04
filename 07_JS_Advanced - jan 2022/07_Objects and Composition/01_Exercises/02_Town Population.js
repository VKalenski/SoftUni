function demo(input) {
    let allTowns = {};

    for (let currRow of input) {
        let splittedInfo = currRow.split(' <-> ');

        let townName = splittedInfo[0];
        let population = Number(splittedInfo[1]);

        if (allTowns[townName] != undefined) {
            allTowns[townName] += population;
        } else {
            allTowns[townName] = population;
        }
    }

    for (let town in allTowns) {
        console.log(`${town} : ${allTowns[town]}`);
    }
}

// demo(['Sofia <-> 1200000',
//       'Montana <-> 20000',
//       'New York <-> 10000000',
//       'Washington <-> 2345000',
//       'Las Vegas <-> 1000000']);

demo(['Istanbul <-> 100000',
    'Honk Kong <-> 2100004',
    'Jerusalem <-> 2352344',
    'Mexico City <-> 23401925',
    'Istanbul <-> 1000']);