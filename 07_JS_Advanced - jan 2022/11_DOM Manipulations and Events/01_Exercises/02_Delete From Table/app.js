function deleteByEmail() {
    let inputElement = document.querySelector('input[name="email"]');
    let allEmailsElement = document.querySelectorAll('td:nth-of-type(2)');
    let divResultElement = document.getElementById('result');

    let allEmails = Array.from(allEmailsElement);
    let elementToDelete = allEmails.find(x => x.textContent == inputElement.value);

    if (elementToDelete != undefined) {
        elementToDelete.parentNode.remove();
        divResultElement.textContent = 'Deleted';
    }
    else {
        divResultElement.textContent = 'Not found.';
    }
    inputElement.value = '';
}