function colorize() {
    let allEvenRow = document.querySelectorAll('table tr')

    for (let i = 0; i < allEvenRow.length; i++) {
        if (i % 2 !== 0) {
            allEvenRow[i].style.background = 'Teal';
        }
    }
}