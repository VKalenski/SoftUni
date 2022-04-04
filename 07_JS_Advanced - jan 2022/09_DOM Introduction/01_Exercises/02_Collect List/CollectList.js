function extractText() {
    let allListElemenet = document.getElementById('items');
    let resultAreaElement = document.getElementById('result');
    resultAreaElement.textContent = allListElemenet.textContent;
}