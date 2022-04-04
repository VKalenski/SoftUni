function demo(a){
    let result;
    let typeOfInput=typeof(a);
    if(typeOfInput=='number'){
        result=Math.pow(a,2)* Math.PI;
        console.log(result.toFixed(2));
    }
    else{
        console.log(`We can not calculate the circle area, because we receive a ${typeOfInput}.`);
    }
}
demo(5);