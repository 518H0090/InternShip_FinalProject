const querySearch = window.location.search.split("?")[1].split("=")[1];
const layoutShoppinglist = document.querySelector('.layout__shoppinglist');
const layoutContainer = document.querySelector('.layout .layout__container');

GetAllItemInShoppingCart(querySearch)
.then(data => {
    let listItemInShoppingCard = data.data;

    let newList = listItemInShoppingCard.map(element => {

        console.log(element)

        return `
        <!-- Shopping Item -->
        <div class="layout__shoppingitem">

            <!-- Image -->
            <div class="layout__item-image">
                <img src="${element.foodImageUrl}" alt="" class="layout__item-img">
            </div>

            <!-- Content -->
            <div class="layout__item-content">
                <h3 class="layout-item__title">${element.foodTitle}</h3>
                <p class="layout-item__description">${element.foodDescription}</p>
            </div>

            <!-- Cost -->
            <div class="layout__item-cost">
                <p>${element.foodPrice} <sup>đ</sup></p>
            </div>

            <!-- Options -->
            <div class="layout__item-options">
                <button class="layout-item__btnup">
                    +
                </button>

                <button class="layout-item__btndown">
                    -
                </button>
            </div>

        </div>
        `

        
    })

    layoutShoppinglist.innerHTML = newList;

})
.catch(error => {
    console.log(error)
    layoutShoppinglist.innerHTML = `<h1 style="margin:5rem 20rem;">Not Found Any value</h1>`
    layoutContainer.style.height = "10rem"
})

GetTotalPriceInShoppingCart(querySearch)
.then(data => {
    const layoutBillTotalcost = document.querySelector('.layout__processbill .layout-bill__totalcost');

    layoutBillTotalcost.innerText = data 
}).catch(error => {
    const layoutBillTotalcost = document.querySelector('.layout__processbill .layout-bill__totalcost');

    layoutBillTotalcost.innerText = "0" 
})