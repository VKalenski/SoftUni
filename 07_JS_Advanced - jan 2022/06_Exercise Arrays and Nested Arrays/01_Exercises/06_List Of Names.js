function demo(array) {
    array.sort((a, b) => a.localeCompare(b)).forEach(function (element, i) {
        console.log(`${++i}.${element}`);
    });
}

demo(["John", "Bob", "Christina", "Ema"]);