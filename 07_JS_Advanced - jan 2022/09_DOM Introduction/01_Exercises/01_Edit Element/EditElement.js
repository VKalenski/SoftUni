function editElement(element, match, replacer) {
    while (element.textContent.includes(match)) {
        element.textContent = element.textContent.replace(match, replacer);
    }
    //console.log(element.textContent);
}