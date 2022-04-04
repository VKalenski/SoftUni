function demo(allFlavors, startFlavor, endFlavor) {
    let firstFlavorIndex = allFlavors.indexOf(startFlavor);
    let secondFlavorIndex = allFlavors.indexOf(endFlavor);

    return allFlavors.slice(firstFlavorIndex, secondFlavorIndex + 1);
}

console.log(demo(['Pumpkin Pie',
    'Key Lime Pie',
    'Cherry Pie',
    'Lemon Meringue Pie',
    'Sugar Cream Pie'],
    'Key Lime Pie',
    'Lemon Meringue Pie'
));

console.log(demo(['Apple Crisp',
    'Mississippi Mud Pie',
    'Pot Pie',
    'Steak and Cheese Pie',
    'Butter Chicken Pie',
    'Smoked Fish Pie'],
    'Pot Pie',
    'Smoked Fish Pie'
));