function demo(obj) {
    let result = {};
    let engine = {};
    let carriage = {};

    result['model'] = obj.model;

    if (obj.power <= 90) {
        engine['power'] = 90;
        engine['volume'] = 1800;
    }
    else if (obj.power <= 120) {
        engine['power'] = 120;
        engine['volume'] = 2400;
    }
    else if (obj.power <= 200) {
        engine['power'] = 200;
        engine['volume'] = 3500;
    }
    result['engine'] = engine;

    carriage['type'] = obj.carriage;
    carriage['color'] = obj.color;

    result['carriage'] = carriage;

    if (obj.wheelsize % 2 === 0) {
        obj.wheelsize -= 1;
    }
    result['wheels'] = [obj.wheelsize, obj.wheelsize, obj.wheelsize, obj.wheelsize];
    return result;
}

console.log(demo({
    model: 'VW Golf II',
    power: 90,
    color: 'blue',
    carriage: 'hatchback',
    wheelsize: 14
}
)); 