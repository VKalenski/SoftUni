function solve() {
  let allButtons = Array.from(document.querySelectorAll('button'));

  allButtons.forEach(b => {
    let currentButton = b.textContent;
    if (currentButton == 'Generate') {
      b.addEventListener('click', generate);
    }

    if (currentButton == 'Buy') {
      b.addEventListener('click', buy);
    }
  });

  function generate(event) {
    let textAreaInput = JSON.parse(event.target.parentElement.querySelector('textarea').value);

    for (let i = 0; i < textAreaInput.length; i++) {
      let inpName = textAreaInput[i].name;
      let inpPrice = textAreaInput[i].price;
      let inpDecFactor = textAreaInput[i].decFactor;
      let inpImage = textAreaInput[i].img;

      let table = document.querySelector('table');
      let tbody = document.querySelector('tbody');
      let tr = document.createElement('tr');

      let tdImage = document.createElement('td');
      let imgImage = document.createElement('img');
      imgImage.src = inpImage;
      tdImage.appendChild(imgImage);
      tr.appendChild(tdImage);

      let tdName = document.createElement('td');
      let pName = document.createElement('p');
      pName.textContent = inpName;
      tdName.appendChild(pName);
      tr.appendChild(tdName);

      let tdPrice = document.createElement('td');
      let pPrice = document.createElement('p');
      pPrice.textContent = inpPrice;
      tdPrice.appendChild(pPrice);
      tr.appendChild(tdPrice);

      let tdDecFactor = document.createElement('td');
      let pDecFactor = document.createElement('p');
      pDecFactor.textContent = inpDecFactor;
      tdDecFactor.appendChild(pDecFactor);
      tr.appendChild(tdDecFactor);

      let tdMark = document.createElement('td');
      let inpMark = document.createElement('input');
      inpMark.type = 'checkbox';
      //inpMark.disabled = true;
      tdMark.appendChild(inpMark);
      tr.appendChild(tdMark);

      tbody.appendChild(tr);
      table.appendChild(tbody);
    }

  }
  function buy(event) {
    let products = Array.from(document.querySelectorAll('tr'));
    let bought = {
      name: [],
      totalSum: 0,
      decFactor: [],
      avgDecFactor: 0
    }
    for (let i = 1; i < products.length; i++) {
      let isChecked = products[i].querySelector('input').checked
      if (isChecked) {
        let product = Array.from(products[i].querySelectorAll('td'));
        bought.name.push(product[1].innerText);
        bought.totalSum += Number(product[2].innerText);
        bought.decFactor.push(Number(product[3].innerText));
      }
    }
    bought.avgDecFactor = (bought.decFactor.reduce((a, b) => a + b, 0) / bought.decFactor.length);
    let result = `Bought furniture: ${bought.name.join(', ')}\nTotal price: ${bought.totalSum.toFixed(2)}\nAverage decoration factor: ${bought.avgDecFactor}`

    document.querySelectorAll('textarea')[1].value = result;
  }
}