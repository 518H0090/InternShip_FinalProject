const username =  localStorage.getItem("username")
const layoutShoppingList = document.querySelector(".layout__shoppinglist");



window.addEventListener("load",(e) => {
    if (username) {
        ProcessLayoutInTransferOrder(username)
    }

    else {

        i = 0;

        while (true) {

            if ( i > 0 ) {
                alert("Không tìm thấy thông tin người dùng nên trang web sẽ chuyển về trang chính");
                window.location.href = "./index.html"
                break;
            }

            alert("Mất Thông tin người dùng nên trang web sẽ tải lại");
            layoutShoppingList.innerHTML = ""

            window.location.reload()
            i++;
        }
        
    }
})

function ProcessLayoutInTransferOrder(username) {
    FetchAllTransferOrder(username)
    .then(data => {
        let dataInTransferOrder = data.data

        console.log(dataInTransferOrder)

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

            if (currentvalue.orderstatus === "PROCESS") {
                return total + currentvalue.totalMoney
            }

            return total
        },0);

        const layoutBillTotalcost = document.querySelector(".layout-bill__totalcost");
        layoutBillTotalcost.textContent = totalMoneyProcess;

        ProcessPaymentTransferOrder()
        ProcessPaymentTotalTransferOrder()
    })
    .catch(error => {
        console.log(error.message)
        layoutShoppingList.innerHTML = ""
        const layoutBillTotalcost = document.querySelector(".layout-bill__totalcost");
        layoutBillTotalcost.textContent = "0";
    })
}


function ProcessPaymentTransferOrder() {
    const layoutShoppingItemAll = document.querySelectorAll(".layout__shoppingitem");

    layoutShoppingItemAll.forEach(element => {
        element.lastElementChild.firstElementChild.addEventListener("click",(e) => {
            let textInnerElement =  e.target.innerText

            if (textInnerElement === "THANH TOÁN") {
                const acceptPayment = confirm("Xác nhận thanh toán ?")

                if (acceptPayment) {
                    if (localStorage.getItem("username")) {
                        let orderId =  e.target.parentElement.parentElement.firstElementChild.innerText

                        let totalMoney = e.target.parentElement.previousElementSibling.firstElementChild.innerText.split(" ")[0]

                        let billOptions = {
                            "orderId": orderId,
                            "createdBy": localStorage.getItem("username"),
                            "totalMoney": totalMoney
                          }

                          FetchNewBillOrder(billOptions)
                          .then(data => {
                            window.alert(`Thanh toán hóa đơn thành công`);
                            window.location.reload();
                          })
                          .catch(error => {
                            window.FlashMessage.error('Có lỗi xảy ra vui lòng thử lại');
                          })

                    }

                    else {
                        window.alert("Mất Thông tin người dùng trang web sẽ tải lại")
                        window.location.reload();
                    }
                }

                else {
                    window.FlashMessage.info('Hủy tiến trình');
                }

            }

            else if (textInnerElement === "XÓA") {
                const acceptDelete = confirm("Xác nhận xóa thông tin hóa đơn ?")

                if (acceptDelete) {
                    if (localStorage.getItem("username")) {
                        let orderId =  e.target.parentElement.parentElement.firstElementChild.innerText

                        let orderOptions = {
                            "orderId": orderId,
                            "username": localStorage.getItem("username")
                          }

                          FetchDeleteTransferOrder(orderOptions)
                          .then(data => {
                            window.alert("Xóa hóa đơn thành công");
                            window.location.reload();
                          })
                          .catch(error => {
                            console.log(error.message)
                            window.FlashMessage.error('Có lỗi xảy ra vui lòng thử lại');
                          })

                    }

                    else {
                        window.alert("Mất Thông tin người dùng trang web sẽ tải lại")
                        window.location.reload();
                    }
                }

                else {
                    window.FlashMessage.info('Hủy tiến trình');
                }
            }

            else {
                window.alert("Có lỗi xảy ra trang web sẽ tải lại")
                window.location.reload()
            }
        })
    })
}

function ProcessPaymentTotalTransferOrder() {
    const layoutBillPurchase = document.querySelector(".layout-bill_purchase");

    layoutBillPurchase.addEventListener("click",(e) => {

        const acceptPayment = window.confirm("Xác nhận thanh toán hết hóa đơn ?")

        if (acceptPayment) {
            if(localStorage.getItem("username")) {
                FetchNewBillAllTransferOrder(localStorage.getItem("username"))
                .then(data => {
                    window.alert(`Thanh Toán Hoàn Tất Hóa Đơn`);
                    window.location.reload();
                })
                .catch(error => {
                    console.log(error.message)
                    window.FlashMessage.error('Có lỗi xảy ra vui lòng thử lại');
                })
            }
    
            else {
                window.alert("Có lỗi trang web sẽ tải lại");
                window.location.reload();
            }
        }

        else {
            window.FlashMessage.info("Hủy tiến trình");
        }
      
    })
}