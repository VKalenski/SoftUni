function addItem() {
    let inputElement = document.getElementById('newItemText');
    let ulElement = document.getElementById('items');

    let createLiElement = document.createElement('li');
    createLiElement.textContent = inputElement.value;

    ulElement.appendChild(createLiElement);

    inputElement.value = '';
}