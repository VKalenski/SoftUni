function solve() {
  let inputStr = document.getElementById('text').value.toLowerCase();
  let namingConvention = document.getElementById('naming-convention').value;

  let resultSpan = document.getElementById('result');
  let result = '';

  let arrayInput = inputStr.split(' ');

  if (namingConvention === 'Camel Case') {
    result += arrayInput[0];
    for (let i = 1; i < arrayInput.length; i++) {
      result += arrayInput[i].charAt(0).toUpperCase() + arrayInput[i].slice(1).toLowerCase();
    }
  }
  else if (namingConvention === 'Pascal Case') {
    for (let i = 0; i < arrayInput.length; i++) {
      result += arrayInput[i].charAt(0).toUpperCase() + arrayInput[i].slice(1).toLowerCase();
    }
  }
  else {
    result = 'Error!';
  }
  document.getElementById('text').value = ' ';
  document.getElementById('naming-convention').value = ' ';
  resultSpan.textContent = result;
}