function lockedProfile() {
    let allButtons = Array.from(document.querySelectorAll('button'));

    allButtons.forEach(b => {
        b.addEventListener('click', function showInfo(event) {
            let currentRatio = event.target.parentElement.querySelector('input[type="radio"]');
            let currentButton = event.target;

            if (currentRatio.checked == false && currentButton.textContent == 'Show more') {

                currentButton.textContent = 'Hide it';
                let hiddenInfo = currentButton.parentElement
                    .querySelector('div').style.display = 'inline-block';
            }
            else if (currentRatio.checked == false && currentButton.textContent == 'Hide it') {

                currentButton.textContent = 'Show more';
                let hiddenInfo = currentButton.parentElement
                    .querySelector('div').style.display = 'none';
            }
        });
    });
}