function encodeAndDecodeMessages() {
    let allButtons = Array.from(document.querySelectorAll('button'));
    allButtons.forEach(b => {
        b.addEventListener('click', clickButton);
    });
    function clickButton(event) {
        let currentButton = event.target;
        if (currentButton.textContent == 'Encode and send it') {
            let textAreaSender = currentButton.parentElement.querySelector('textarea').value;
            let encoded = '';
            for (let i = 0; i < textAreaSender.length; i++) {
                encoded += String.fromCharCode(textAreaSender[i].charCodeAt(0) + 1)
            }
            let textAreaReceiver = currentButton.parentElement.parentElement.querySelectorAll('textarea')[1];
            textAreaReceiver.value = encoded;
            currentButton.parentElement.querySelector('textarea').value = '';
        }
        else if (currentButton.textContent == 'Decode and read it') {
            let textAreaReceiver = currentButton.parentElement.parentElement.querySelectorAll('textarea')[1].value;

            let decoded = '';
            for (let i = 0; i < textAreaReceiver.length; i++) {
                decoded += String.fromCharCode(textAreaReceiver[i].charCodeAt(0) - 1)
            }
            currentButton.parentElement.parentElement.querySelectorAll('textarea')[1].value = decoded;
        }
    }
}