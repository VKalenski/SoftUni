function demo(steps,footprint,speed){
    let distanceInMeters = steps * footprint;
    let speedMeterInSecond = speed / 3.6;
    let minutesForBreaks = Math.floor(distanceInMeters / 500);
    let timeNeeded = distanceInMeters / speedMeterInSecond + minutesForBreaks * 60;

    let hours = Math.floor(timeNeeded / 3600);
    let minutes = Math.floor(timeNeeded / 60);
    let seconds = Math.ceil(timeNeeded % 60);

    let result = hours < 10 ? `0${hours}:` :  `${hours}:`;
    result += minutes < 10 ? `0${minutes}:` :  `${minutes}:`;
    result +=  `${seconds}`;

    console.log(result);

}
demo(4000, 0.60, 5);