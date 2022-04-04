function solve(input) {

    let processor = () => {
        let result = [];
        return {
            add: (el) => {
                result.push(el);
            },
            remove: (el) => {
                result = result.filter((x) => x !== el);
            },
            print: () => {
                console.log(result.join(','));
            },
        };
    };

    let resultOfFunct = processor();
    input.map((x) => x.split(' '))
        .map(([cmd, value]) => resultOfFunct[cmd](value));
}

solve(['add hello', 'add again', 'remove hello', 'add again', 'print']);