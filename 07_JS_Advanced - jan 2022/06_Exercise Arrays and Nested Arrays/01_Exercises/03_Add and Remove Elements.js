function demo(array) {
    let result = [];
    for (let i = 0; i < array.length; i++) {
        if (array[i] === 'add') {
            result.push(i + 1);
        } else if (array[i] === 'remove') {
            result.pop();
        }
    }
    
    if (result.length === 0) {
        console.log('Empty');
    } else {
        result.forEach(r => console.log(r));
    }
}

demo(['add',
    'add',
    'add',
    'add']);