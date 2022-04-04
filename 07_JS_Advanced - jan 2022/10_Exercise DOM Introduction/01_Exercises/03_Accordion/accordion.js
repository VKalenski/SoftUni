function toggle() {
    let buttonElement = document.getElementsByClassName('button')[0];
    let buttonInfo = buttonElement.textContent;
    let extraText = document.getElementById('extra');

    if (buttonInfo === 'More') {
        buttonElement.textContent = 'Less';
        extraText.style.display = 'block';
    }
    else {
        buttonElement.textContent = 'More';
        extraText.style.display = 'none';
    }
}