function demo(input) {

    let allProducts = [];

    while (input.length > 0) {
        let [town, product, price] = input.shift().split(' | ');

        if (allProducts.filter(x => x.product === product).length > 0) {
            let obj = allProducts.find(x => x.product === product);
            if (obj.price > Number(price)) {
                obj.price = Number(price);
                obj.town = town;
            }
        } else {
            let obj = { town, product, price: Number(price) };
            allProducts.push(obj);
        }
    }

    allProducts.forEach(element => {
        console.log(`${element.product} -> ${element.price} (${element.town})`);
    });
}

demo(['Sample Town | Sample Product | 1000',
    'Sample Town | Orange | 2',
    'Sample Town | Peach | 1',
    'Sofia | Orange | 3',
    'Sofia | Peach | 2',
    'New York | Sample Product | 1000.1',
    'New York | Burger | 10']
);