function attachEventsListeners() {
    let allButtonsElements = Array.from(document.querySelectorAll('input[value="Convert"]'));
    allButtonsElements.forEach(b => {
        b.addEventListener('click', clickedConverter)
    });

    function clickedConverter(event) {
        let currentButton = event.target.id;

        if (currentButton === 'daysBtn') {
            let days = Number(document.getElementById('days').value);

            document.getElementById('hours').value = days * 24;
            document.getElementById('minutes').value = days * 1440;
            document.getElementById('seconds').value = days * 86400;
        }
        else if (currentButton === 'hoursBtn') {
            let hours = Number(document.getElementById('hours').value);

            document.getElementById('days').value = hours / 24;
            document.getElementById('minutes').value = hours * 60;
            document.getElementById('seconds').value = hours * 3600;
        }
        else if (currentButton === 'minutesBtn') {
            let minutes = Number(document.getElementById('minutes').value);

            document.getElementById('days').value = minutes / 60 / 24;
            document.getElementById('hours').value = minutes / 60;
            document.getElementById('seconds').value = minutes * 60;
        }
        else if (currentButton === 'secondsBtn') {
            let seconds = Number(document.getElementById('seconds').value);

            document.getElementById('days').value = seconds / 60 / 60 / 24;
            document.getElementById('hours').value = seconds / 60 / 60;
            document.getElementById('minutes').value = seconds / 60;
        }
    }
}