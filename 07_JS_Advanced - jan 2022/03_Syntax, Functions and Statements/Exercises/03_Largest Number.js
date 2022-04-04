function demo(a,b,c){
    let num1=Number(a);
    let num2= Number(b);
    let num3=Number(c);

    let result=Math.max(num1,num2,num3);

    console.log(`The largest number is ${result}.`);

}
demo(5, -3, 16);