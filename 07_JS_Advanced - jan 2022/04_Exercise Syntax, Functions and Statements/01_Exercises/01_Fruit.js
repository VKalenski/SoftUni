function demo(fruit,weight,price){
    let fruitName= fruit;
    let weightInKilo= weight/1000;
    let pricePerKilo= price;

    let total= weightInKilo*pricePerKilo;

    console.log(`I need $${total.toFixed(2)} to buy ${weightInKilo.toFixed(2)} kilograms ${fruitName}.`)
}

demo('orange', 2500, 1.80);