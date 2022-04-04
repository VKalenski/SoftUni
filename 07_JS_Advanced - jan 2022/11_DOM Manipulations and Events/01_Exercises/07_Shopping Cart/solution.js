function solve() {
   //get all Buttons
   let buttonsElements = document.getElementsByTagName('button');
   let allButtons = Array.from(buttonsElements);

   let bag = {};
   let totalSum = 0;

   let textAreaElement = document.querySelector('textarea');

   //for all buttons set an event
   allButtons.forEach(el => {
      el.addEventListener('click', (e) => {
         if (e.target.className == 'add-product') {
            //for pressed button get parent node of the parent node=> div class="product"
            addProduct(el.parentNode.parentNode);
            //console.log(e); button.add-product
         }
         else if (e.target.className == 'checkout') {
            checkoutResult(el.parentNode.parentNode)
            //console.log(e); button.checkout
         }
      })
   });

   function addProduct(parent) {
      //for div class="product" get .product-title and .product-line-price
      let nameOfProduct = parent.querySelector('.product-title').textContent;
      let price = Number(parent.querySelector('.product-line-price').textContent);
      bag[nameOfProduct] = Number(price);

      textAreaElement.value += `Added ${nameOfProduct} for ${price.toFixed(2)} to the cart.\n`;
      totalSum += price;
   }

   function checkoutResult(parent) {
      allButtons.forEach(btn => {
         btn.disabled = 'true';
      });
      textAreaElement.value += `You bought ${Object.keys(bag).join(', ')} for ${totalSum.toFixed(2)}.`;
   }
}