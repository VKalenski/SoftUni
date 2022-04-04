function addItem() {
    let inputElement = document.getElementById('newItemText');
    let ulElement = document.getElementById('items');

    let createLiElement = document.createElement('li');
    createLiElement.textContent = inputElement.value;

    let deleteElement = document.createElement('a');
    deleteElement.href = '#';
    deleteElement.textContent = '[Delete]';

    deleteElement.addEventListener('click', () => {
        deleteElement.parentNode.remove();
    })

    createLiElement.appendChild(deleteElement);
    ulElement.appendChild(createLiElement);
    inputElement.value = '';
}