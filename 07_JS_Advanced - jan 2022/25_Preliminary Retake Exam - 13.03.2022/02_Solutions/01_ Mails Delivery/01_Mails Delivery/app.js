window.addEventListener('laod', solve);

function solve() {
    
    // Getting information from the form    
    const addButtonElement = document.getElementById('add');
    const resetButtonElement = document.getElementById('reset');
    const recipientName = document.getElementById('recipientName');
    const title = document.getElementById('title');
    const message = document.getElementById('message');
    const newElement = document.getElementById('list');

    // Add to the list
    addButtonElement.addEventListener('click', (e) => {
        e.preventDefault();

        let recName = recipientName.value;
        let tit = title.value;
        let mes = message.value;

        recipientName.value = '';
        title.value = '';
        message.value = '';

        if (!recName || !tit || !mes) {
            return;
        }

        let element = document.createElement('li')
        let elementTwo = document.createElement('li')
        let recNameList = document.createElement('h4');
        let titList = document.createElement('h4');
        let mesList = document.createElement('span');

        // Send and delete mails
        let sendButton = document.createElement('button');
        let deleteButton = document.createElement('button');

        // document.appendChild(sendButton);

        sendButton.textContent = 'Send';
        deleteButton.textContent = 'Delete';

        titList.textContent = `Title: ${tit}`;
        recNameList.textContent = `Recipient Name: ${recName}`;
        mesList.textContent = `${mes}`;

        element.appendChild(recNameList);
        element.appendChild(titList);
        element.appendChild(mesList);
        element.appendChild(sendButton);
        element.appendChild(deleteButton);
        newElement.appendChild(element);
        // newElement.appendChild(elementTwo);

        // // Send mails
        // sendButton.addEventListener('click', (e) => {
        //     if (e.currentTarget.textContent == "Send") {

        //     }

            

        // });
        
        // // Delete mails
        // deleteButton.addEventListener('click', (e) => {

        // });

        // Reset
        resetButtonElement.addEventListener('click', (e) => {
            e.preventDefault();

            recipientName.value = '';
            title.value = '';
            message.value = '';
        });
    })
}

solve()