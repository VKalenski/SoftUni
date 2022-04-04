function solve() {
  let textArea = document.getElementById('input').value;
  let inputAsArray = textArea.split('.').filter((x) => x.length >= 1);

  let divElement = document.getElementById('output');

  while (inputAsArray.length > 0) {
    let senteces = inputAsArray.splice(0, 3).join('. ') + '.';
    let p = document.createElement('p');
    p.appendChild(document.createTextNode(senteces));
    divElement.appendChild(p);
  }
}