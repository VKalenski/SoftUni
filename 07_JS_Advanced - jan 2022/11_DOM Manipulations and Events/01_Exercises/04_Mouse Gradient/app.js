function attachGradientEvents() {
    let gradientElement = document.getElementById('gradient');
    let resultElement = document.getElementById('result');

    const gradientPersent = (e) => {
        let percent = Math.floor((e.offsetX / 300) * 100);
        resultElement.textContent = `${percent}%`;
    }
    gradientElement.addEventListener('mousemove', gradientPersent);
}