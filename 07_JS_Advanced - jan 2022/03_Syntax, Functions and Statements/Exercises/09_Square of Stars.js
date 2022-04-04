function demo(input){
    if(input===undefined){
        for(let i=0;i<5;i++){
            console.log('* '.repeat(5));
        }
    }
    for(let i=0;i<input;i++){
        console.log('* '.repeat(input));
    }
}
demo();