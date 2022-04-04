function demo(year, month, day) {
    let date = new Date(year, month, day);
    date.setDate(date.getDate()-1);
    if(day===1){
        date.setDate(date.getDate()-1);
    }
    let newYear = date.getFullYear();
    let newMonth = date.getMonth();
    let newDate = date.getDate();
    console.log(`${newYear}-${newMonth}-${newDate}`);
}
demo(2016, 10, 1);