function subtract() {
    let firstNumberInputElement = document.getElementById('firstNumber');
    let secondNumberInputElement = document.getElementById('secondNumber');

    let num1 = Number(firstNumberInputElement.value);
    let num2 = Number(secondNumberInputElement.value);
    let substract = num1 - num2;

    let divElement = document.getElementById('result');
    divElement.textContent = substract;
}