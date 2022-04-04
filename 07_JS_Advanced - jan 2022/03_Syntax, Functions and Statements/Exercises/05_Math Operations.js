function demo(numA,numB,sign){
    //'+', '-', '*', '/', '%', '**'
    let result=0;

    function Add(a,b){
        return a+b;
    }

    function Substract(a,b){
        return a-b;
    }

    function Multiply(a,b){
        return a*b;
    }

    function Division(a,b){
        return a/b;
    }

    function SpecialDivision(a,b){
        return a%b;
    }

    function Pow(a,b){
        return a**b;
    }

    switch(sign){
        case '+':
        result=Add(numA,numB);
        break;
        case '-':
        result=Substract(numA,numB);
        break;
        case '*':
        result=Multiply(numA,numB);
        break; 
        case '/':   
        result=Division(numA,numB);
        break; 
        case '%':   
        result=SpecialDivision(numA,numB);
        break; 
        case '**':   
        result=Pow(numA,numB);
        break; 
    }

    console.log(result);
}
demo(3, 5.5, '*');