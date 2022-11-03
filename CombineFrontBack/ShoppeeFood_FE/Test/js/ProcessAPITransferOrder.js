const username =  localStorage.getItem("username")
const layoutShoppingList = document.querySelector(".layout__shoppinglist");



window.addEventListener("load",(e) => {
    if (username) {
        ProcessLayoutInTransferOrder(username)
    }

    else {
        alert("Missing User Please Refresh Again");
        layoutShoppingList.innerHTML = ""
        window.location.reload()
    }
})

function ProcessLayoutInTransferOrder(username) {
    FetchAllTransferOrder(username)
    .then(data => {
        let dataInTransferOrder = data.data


        let newLayout = dataInTransferOrder.map(x => {

            let newDatetime = new Date(x.createdOn)

            let dateReturn = ` ${newDatetime.getDate()}/${(newDatetime.getMonth() + 1)}/${newDatetime.getFullYear()}`

            let buttonPayment = x.orderstatus === "FINISH" ? 
            `
            <!-- Options -->
                <div class="layout__item-options">
                    <button class="layout-item__btnprocess">
                        xóa
                    </button>
                </div>
            `
            :
            `
            <!-- Options -->
            <div class="layout__item-options">
                <button class="layout-item__btnprocess">
                    thanh toán
                </button>
            </div>
            `

            return `
            <!-- Shopping Item -->
            <div class="layout__shoppingitem">

                <!-- Orderid -->
                <div class="layout__item-orderid">
                   <p>${x.orderId}</p>
                </div>

                <!-- Content -->
                <div class="layout__item-content">
                    <p class="layout-item__count">Tổng số lượng vật phẩm : ${x.numberItem} món</p>

                    <p class="layout-item__distance">Khoảng cách giao hàng : ${x.orderDistance} km</p>

                    <p class="layout-item__dateorder">Ngày yêu cầu : ${dateReturn}</p>
                </div>

                <!-- Cost -->
                <div class="layout__item-cost">
                    <p>${x.totalMoney} <sup>đ</sup></p>
                </div>

               
                ${buttonPayment}

            </div>
            `
        })

        layoutShoppingList.innerHTML = newLayout

        let totalMoneyProcess = dataInTransferOrder.reduce( (total, currentvalue) => {
            return total + currentvalue.totalMoney
        },0);

        const layoutBillTotalcost = document.querySelector(".layout-bill__totalcost");
        layoutBillTotalcost.textContent = totalMoneyProcess;

        ProcessPaymentTransferOrder()
    })
    .catch(error => {
        console.log(error.message)
        layoutShoppingList.innerHTML = ""
    })
}


function ProcessPaymentTransferOrder() {
    const layoutShoppingItemAll = document.querySelectorAll(".layout__shoppingitem");
}