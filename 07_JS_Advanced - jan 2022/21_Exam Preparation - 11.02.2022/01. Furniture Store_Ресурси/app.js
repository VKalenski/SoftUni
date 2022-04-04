window.addEventListener('load', solve);

function solve() {    
    // We must make reference here
    const addButtonElement = document.getElementById('add');
    const modelInputElement = document.getElementById('model');
    const yearInputElement = document.getElementById('description');
    const descriptionInputElement = document.getElementById('add');
    const priceInputElement = document.getElementById('price');
    const furnitureListElement = document.getElementById('furniture-list');
    
    addButtonElement.addEventListener('click', (e) => {
        e.preventDefault();

        let model = modelInputElement.value;
        let description = descriptionInputElement.value;
        let year = Number(yearInputElement.value); // Parse
        let price = Number(priceInputElement.value); // Parse
        

        // Check for model and year by .doc
        if (!model || !description) {
            return;
        }

        if (year <= 0 || price <=0 ){
            return;
        }

        //Add 
        let rowElement = document.createElement('tr');
        let modelCellElement = document.createElement('td');
        let priceCellElement = document.createElement('td');
        let actionsCellElement = document.createElement('td');
        let infoButtonElement = document.createElement('button');
        let buyButtonElement = document.createElement('button');
        infoButtonElement.addEventListener('click', () => {
            if (e.currentTarget.textContent == 'More info') {
                e.currentTarget.textContent = 'Less info'
            }
            else {
                e.currentTarget.textContent = 'Less info';
            }
        });

        modelCellElement.textContent = model;
        priceCellElement.textContent = price.toFixed(2);

        infoButtonElement.textContent = 'More info';
        infoButtonElement.classList.add('infoBtn');
        buyButtonElement.textContent = 'Buy it';
        buyButtonElement.classList.add('buyBtn');

        actionsCellElement.appendChild(infoButtonElement);
        actionsCellElement.appendChild(buyButtonElement);

        rowElement.classList.add('info');

        rowElement.appendChild(modelCellElement);
        rowElement.appendChild(priceCellElement);
        rowElement.appendChild(actionsCellElement);

        furnitureListElement.appendChild(rowElement);

        //
    });
}
