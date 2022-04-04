function demo(input){
   let regexPattern = /\w+/g;
    let results = input.match(regexPattern);    

    console.log(
        results
        .map(x => x.toUpperCase())
        .join(', '));
}
demo('Hi, how are you?')