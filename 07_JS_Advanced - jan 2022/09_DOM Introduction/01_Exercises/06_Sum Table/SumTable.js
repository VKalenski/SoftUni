function sumTable() {
    let allTdElementsInTable = document.querySelectorAll('td:nth-child(2)');
    let sumElement = document.getElementById('sum');
    let sum = 0;
    for (let i = 0; i < allTdElementsInTable.length - 1; i++) {
        sum += Number(allTdElementsInTable[i].textContent);
    }
    sumElement.textContent = sum;
}