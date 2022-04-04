function demo(speed,area){
    const motorwayLimit=130;
    const interstateLimit=90;
    const cityLimit=50;
    const residentialLimit=20;

    let status;

    if(area==='motorway' ){
        if(speed<=motorwayLimit){
        console.log(`Driving ${speed} km/h in a ${motorwayLimit} zone`);
        }
        else{
            diff = Math.abs(speed - motorwayLimit);
            if (diff <= 20){
                 status='speeding';
            }
            else if(diff <= 40){
                 status='excessive speeding';
            }
            else {
                 status='reckless driving';
            }
            console.log(`The speed is ${diff} km/h faster than the allowed speed of ${motorwayLimit} - ${status}`)
        }
    }
    else  if(area==='interstate' ){
        if(speed<=interstateLimit){
        console.log(`Driving ${speed} km/h in a ${interstateLimit} zone`);
        }
        else{
            diff = Math.abs(speed - interstateLimit);
            if (diff <= 20){
                 status='speeding';
            }
            else if(diff <= 40){
                 status='excessive speeding';
            }
            else {
                 status='reckless driving';
            }
            console.log(`The speed is ${diff} km/h faster than the allowed speed of ${interstateLimit} - ${status}`)
        }
    }
    else  if(area==='city' ){
        if(speed<=cityLimit){
        console.log(`Driving ${speed} km/h in a ${cityLimit} zone`);
        }
        else{
            diff = Math.abs(speed - cityLimit);
            if (diff <= 20){
                 status='speeding';
            }
            else if(diff <= 40){
                 status='excessive speeding';
            }
            else {
                 status='reckless driving';
            }
            console.log(`The speed is ${diff} km/h faster than the allowed speed of ${cityLimit} - ${status}`)
        }
    }
    else  if(area==='residential' ){
        if(speed<=residentialLimit){
        console.log(`Driving ${speed} km/h in a ${residentialLimit} zone`);
        }
        else{
            diff = Math.abs(speed - residentialLimit);
            if (diff <= 20){
                 status='speeding';
            }
            else if(diff <= 40){
                 status='excessive speeding';
            }
            else {
                 status='reckless driving';
            }
            console.log(`The speed is ${diff} km/h faster than the allowed speed of ${residentialLimit} - ${status}`)
        }
    }

}
demo(40, 'city');
demo(21, 'residential');
demo(120, 'interstate');
demo(200, 'motorway');