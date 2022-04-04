function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      let listElements = document.querySelectorAll('tbody tr');
      let list = Array.from(listElements);

      let searchElement = document.getElementById('searchField');
      let searchInput = searchElement.value;

      list.forEach(element => {
         if (element.textContent.includes(searchInput)) {
            element.setAttribute('class', 'select');
         }
         else {
            element.setAttribute('class', '');
            searchElement.value = '';
         }
      });
   }
}