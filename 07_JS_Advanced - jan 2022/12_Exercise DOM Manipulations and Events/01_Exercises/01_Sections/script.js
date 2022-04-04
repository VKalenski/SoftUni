function create(words) {
   let mainDivElement = document.getElementById('content');
   words.forEach(w => {
      let divElement = document.createElement('div');
      let paragraphElement = document.createElement('p');

      paragraphElement.textContent = w;
      paragraphElement.style.display = 'none';

      divElement.appendChild(paragraphElement)
      mainDivElement.appendChild(divElement);

      divElement.addEventListener('click', function (event) {
         let getClickedElement = event.target.children[0];
         getClickedElement.style.display = 'inline-block';
      })
   });
}