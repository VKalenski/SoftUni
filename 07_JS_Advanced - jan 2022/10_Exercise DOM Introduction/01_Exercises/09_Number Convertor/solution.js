function solve() {
    let inputNumberElement = document.getElementById('input');
    let result = document.getElementById('result');
    let selectedMenuToElement = document.getElementById('selectMenuTo');

    let optBinary = document.createElement('option');
    optBinary.value = 'binary';
    optBinary.innerHTML = 'Binary';
    selectedMenuToElement.appendChild(optBinary);

    let optHexa = document.createElement('option');
    optHexa.value = 'hexadecimal';
    optHexa.innerHTML = 'Hexadecimal';
    selectedMenuToElement.appendChild(optHexa);

    document.getElementsByTagName('button')[0].addEventListener("click", Converter);

    function Converter() {
        if (selectedMenuToElement.value === 'binary') {
            result.value = Number(inputNumberElement.value).toString(2);
        } else if (selectedMenuToElement.value === 'hexadecimal') {
            result.value = Number(inputNumberElement.value).toString(16).toUpperCase();
        }
    }
}