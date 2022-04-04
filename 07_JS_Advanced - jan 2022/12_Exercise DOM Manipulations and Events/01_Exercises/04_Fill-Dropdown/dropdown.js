function addItem() {
    let selectElement = document.getElementById('menu');
    let inputText = document.getElementById('newItemText').value;
    let inputValue = document.getElementById('newItemValue').value;

    let optionElement = document.createElement('option');
    optionElement.textContent = inputText;
    optionElement.value = inputValue;

    selectElement.appendChild(optionElement);

    document.getElementById('newItemText').value = '';
    document.getElementById('newItemValue').value = '';
}