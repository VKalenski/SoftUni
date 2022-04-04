function focused() {
    let inputElements = document.querySelectorAll('input');

    for (const input of inputElements) {

        input.addEventListener('focus', (e) => {
            //input is the target in event object
            //parent node is div- we need him, because in many divs we have input field
            input.parentNode.classList.add('focused');
        });

        input.addEventListener('blur', () => {
            input.parentNode.classList = '';
        });
    }
}