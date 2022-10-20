const querySearch = window.location.search.split("?")[1].split("=")[1];
const layoutShoppinglist = document.querySelector('.layout__shoppinglist');
const layoutContainer = document.querySelector('.layout .layout__container');
const layoutProcessBillBtn = document.querySelector('.layout__processbill button[type="button"]')


window.addEventListener('load',(e) => {
    GetAllItemInShoppingCart(querySearch)
.then(data => {
    let listItemInShoppingCard = data.data;

    let newList = listItemInShoppingCard.map(element => {

        return `
        <!-- Shopping Item -->
        <div class="layout__shoppingitem" data-recordid="${element.recordId}">

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

    const layoutShoppingItem = document.querySelectorAll('.layout__shoppingitem');

    layoutShoppingItem.forEach(element => {
        element.firstElementChild.nextElementSibling.nextElementSibling.nextElementSibling
            .firstElementChild.addEventListener('click',(e) => {
                let foodPrice = e.target.parentElement.previousElementSibling.firstElementChild.innerText.split(" ")[0]

                let foodTitle = e.target.parentElement.previousElementSibling.previousElementSibling
                    .firstElementChild.innerText
                    
                let foodDescription = e.target.parentElement.previousElementSibling.previousElementSibling
                    .lastElementChild.innerText
                    
                let foodImage = e.target.parentElement.previousElementSibling.previousElementSibling.previousElementSibling.firstElementChild.getAttribute("src")

                let foodInfo = {
                    foodImageUrl : foodImage,
                    foodTitle : foodTitle,
                    foodDescription : foodDescription,
                    foodPrice : foodPrice
                }

                let username = localStorage.getItem("username");

                AddNewItemInShoppingCart(username,foodInfo)
                .then(data => {
                    window.location.reload();
                }).catch(error => {
                    window.alert(error)
                })
        })

        element.firstElementChild.nextElementSibling.nextElementSibling.nextElementSibling
            .lastElementChild.addEventListener('click',(e) => {
                let recordId = e.target.parentElement.parentElement.getAttribute("data-recordid")
                let username = localStorage.getItem("username")

                let readyDelete = confirm("haha")

                if (readyDelete) {
                    DeleteNewItemInShoppingCart(username,recordId)
                    .then(data => {
                        window.location.reload();
                        window.alert(data.data)
                    }).catch(error => {
                        window.alert(error);
                    })
                } 
                
                else {
                    window.alert("Cancel Command")
                }

               
        })
    })
    

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


})



layoutProcessBillBtn.addEventListener('click',(e) => {
    const totalCost =  e.target.previousElementSibling.lastElementChild.innerText

    const acceptPayment = window.confirm("Pay For This Bill ?");

    if (acceptPayment) { 
        const username = localStorage.getItem("username")

        let processbill = {
            totalCost : totalCost,
            username : username
        }

        console.log(processbill)

        NewBillInShoppingCart(username,totalCost)
        .then(data => {
            window.alert("Create Succesful" + "\n" + data.data.billId);
            window.location.href = "./index.html";
        })
        .catch(error => {
            window.alert(error.message);
        })
    } 

    else {
        window.alert('Not Accept Process')
        window.location.reload()
    }
})
