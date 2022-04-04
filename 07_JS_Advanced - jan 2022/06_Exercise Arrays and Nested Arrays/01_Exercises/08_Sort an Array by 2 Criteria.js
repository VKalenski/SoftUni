function demo(array) {
    console.log(array.sort((a, b) => a.length - b.length || a.localeCompare(b)).join('\n'));
}

demo(['alpha',
    'beta',
    'gamma'])