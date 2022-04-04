function solve(array) {
    let juice = {};
    let result = {};
    array.forEach(j => {
        let [juiceName, juiceQuantity] = j.split(' => ');
        if (!juice[juiceName]) {
            juice[juiceName] = 0;
        }
        juice[juiceName] += Number(juiceQuantity);

        if (juice[juiceName] >= 1000) {
            if (!result[juiceName]) {
                result[juiceName] = 0;
            }
            let bottles = juice[juiceName] / 1000
            result[juiceName] += Math.floor(bottles);
            juice[juiceName] -= Math.floor(bottles) * 1000;
        }

    });

    let end = '';
    for (const currRess in result) {
        end += `${currRess} => ${result[currRess]}\n`;
    }
    return end;
}

console.log(solve(['Orange => 2000',
    'Peach => 1432',
    'Banana => 450',
    'Peach => 600',
    'Strawberry => 549']
));

console.log(solve(['Kiwi => 234',
    'Pear => 2345',
    'Watermelon => 3456',
    'Kiwi => 4567',
    'Pear => 5678',
    'Watermelon => 6789']
));