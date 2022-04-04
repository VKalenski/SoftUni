function demo(a,b,c){
    let lengthA=a.length;
    let lengthB=b.length;
    let lengthC=c.length;
    
    let sum=lengthA+lengthB+lengthC;
    let avg=Math.floor(sum/3);

    console.log(sum);
    console.log(avg);

}
demo('chocolate', 'ice cream', 'cake');