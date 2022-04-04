function demo(input){
    let numberLikeString=input.toString();
    let isSame=true;
    let sum=0;
    let firstNum=Number(numberLikeString[0]);

    for(let i=0;i<numberLikeString.length;i++){
        sum+=Number(numberLikeString[i]);
        if(Number(numberLikeString[i])!==firstNum){
            isSame=false;
        }
    }
    console.log(isSame);
    console.log(sum)
}
demo(212);