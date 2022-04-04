function demo(p1,p2,p3,p4,p5,p6){
    let number=Number(p1);
    
    function chop(n){
        return n/2;
    } 

    function dice(n){
        return Math.sqrt(n);
    }

    function spice(n){
        return n+=1;
    }

    function bake(n){
        return n*=3;
    }

    function fillet(n){
        return n*=0.80;
    }

    let arrayOfOperations=[p2,p3,p4,p5,p6];
    
    for(let i=0;i<arrayOfOperations.length;i++){
        if(arrayOfOperations[i]==='chop'){
            number=chop(number);
            console.log(number);
        }
        else if(arrayOfOperations[i]==='dice'){
            number=dice(number);
            console.log(number);
        }
        else if(arrayOfOperations[i]==='spice'){
            number=spice(number);
            console.log(number);
        }
        else if(arrayOfOperations[i]==='bake'){
            number=bake(number);
            console.log(number);
        }
        else if(arrayOfOperations[i]==='fillet'){
            number=fillet(number);
            console.log(number.toFixed(1));
        }
    }
    
}

demo('32', 'chop', 'chop', 'chop', 'chop', 'chop');
demo('9', 'dice', 'spice', 'chop', 'bake', 'fillet');