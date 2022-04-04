function extract(content) {
    let elementToExtract = document.getElementById(content);
    let textElementToExtract = elementToExtract.textContent;

    let regex = /\(([^)]+)\)/g;
    let match = textElementToExtract.match(regex);

    return match.join('; ');
}