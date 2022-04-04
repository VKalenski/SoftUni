function validate() {
    let regex = /[a-z]+@[a-z]+.[a-z]+/;

    let email = document.getElementById('email');

    email.addEventListener('change', () => {
        if (email.value.match(regex) == null) {
            email.classList.add('error');
        }
        else {
            email.classList = '';
        }
    });
}