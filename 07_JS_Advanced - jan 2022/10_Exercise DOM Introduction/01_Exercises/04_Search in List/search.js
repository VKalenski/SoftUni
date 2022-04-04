function search() {
   let listData = document.querySelectorAll('ul li');
   let data = Array.from(listData);

   let searchElement = document.getElementById('searchText');
   let search = searchElement.value;
   let count = 0;

   let resultElement = document.getElementById('result');

   for (let i = 0; i < data.length; i++) {
      let currentData = data[i].textContent;
      if (currentData.includes(search) && search !== '') {
         count++;
         data[i].style.fontWeight = 'bold';
         data[i].style.textDecoration = 'underline';
      }
      else {
         data[i].style.fontWeight = 'normal';
         data[i].style.textDecoration = 'none';
      }
   }

   resultElement.textContent = `${count} matches found`;
   searchElement.value = '';
}