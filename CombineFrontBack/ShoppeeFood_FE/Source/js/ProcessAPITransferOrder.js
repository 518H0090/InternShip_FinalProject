const username =  localStorage.getItem("username")
const layoutShoppingList = document.querySelector(".layout__shoppinglist");



window.addEventListener("load",(e) => {
    if (username) {
        ProcessLayoutInTransferOrder(username)
    }

    else {
        layoutShoppingList.innerHTML = ""
        alert("Không tìm thấy thông tin người dùng nên trang web sẽ chuyển về trang chính");
        window.location.href = "./index.html"
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
                   <p>${x.orderCode}</p>
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

        ProcessPaymentTransferOrder(dataInTransferOrder)
        ProcessPaymentTotalTransferOrder()
    })
    .catch(error => {
        console.log(error.message)
        layoutShoppingList.innerHTML = ""
        const layoutBillTotalcost = document.querySelector(".layout-bill__totalcost");
        layoutBillTotalcost.textContent = "0";
    })
}


function ProcessPaymentTransferOrder(data) {
    const layoutShoppingItemAll = document.querySelectorAll(".layout__shoppingitem");

    console.log(data)

    layoutShoppingItemAll.forEach(element => {
        element.lastElementChild.firstElementChild.addEventListener("click",(e) => {
            let textInnerElement =  e.target.innerText

            if (textInnerElement === "THANH TOÁN") {
                swal({
                    title: "Bạn có chắc muốn thanh toán hóa đơn?",
                    text: "Vui lòng xác nhận thanh toán hóa đơn",
                    icon: "info",
                    buttons: true,
                    dangerMode: true,
                  })
                  .then((willDelete) => {
                    if (willDelete) {
                     
                        if (localStorage.getItem("username")) {

                            let orderId;
    
                            let orderCode =  e.target.parentElement.parentElement.firstElementChild.innerText
    
                            data.forEach(element => {
                                if (orderCode === element.orderCode) {
                                    orderId = element.orderId;
                                }
                            })
    
                            let totalMoney = e.target.parentElement.previousElementSibling.firstElementChild.innerText.split(" ")[0]
    
                            let billOptions = {
                                "orderId": orderId,
                                "createdBy": localStorage.getItem("username"),
                                "totalMoney": totalMoney
                              }
    
                              FetchNewBillOrder(billOptions)
                              .then(data => {

                                swal("Thanh toán hóa đơn thành công", {
                                    icon : "success"
                                  }).then(() => {
                                      window.location.reload();
                                  });

                              })
                              .catch(error => {
                                swal("Có lỗi xảy ra vui lòng thử lại", {
                                    icon : "error"
                                  })
                              })
    
                        }
    
                        else {
                            swal("Mất Thông tin người dùng trang web sẽ tải lại", {
                                icon : "warning"
                              }).then(() => {
                                  window.location.reload();
                              })
                        }

                    } else {
                      swal("Hủy tiến trình", {
                        icon : "info"
                      });
                    }
                  });

            }

            else if (textInnerElement === "XÓA") {

                swal({
                    title: "Xác nhận xóa thông tin hóa đơn?",
                    text: "Vui lòng bấm xác nhận để xóa hóa đơn",
                    icon: "warning",
                    buttons: true,
                    dangerMode: true,
                  })
                  .then((willDelete) => {
                    if (willDelete) {
                        if (localStorage.getItem("username")) {

                            let orderId;
    
                            let orderCode =  e.target.parentElement.parentElement.firstElementChild.innerText
    
                            data.forEach(element => {
                                if (orderCode === element.orderCode) {
                                    orderId = element.orderId;
                                }
                            })
    
                            let orderOptions = {
                                "orderId": orderId,
                                "username": localStorage.getItem("username")
                              }
    
                              FetchDeleteTransferOrder(orderOptions)
                              .then(data => {
                                swal("Xóa hóa đơn thành công", {
                                    icon : "success"
                                  }).then(() => {
                                      window.location.reload();
                                  })
                              })
                              .catch(error => {
                                swal("Có lỗi xảy ra vui lòng thử lại lần nữa", {
                                    icon : "error"
                                  })
                              })
    
                        }
    
                        else {
                            swal("Mất Thông tin người dùng trang web sẽ tải lại", {
                                icon : "warning"
                              }).then(() => {
                                  window.location.reload();
                              })
                        }

                    } else {
                        swal("Hủy tiến trình", {
                            icon : "info"
                          })
                    }
                  });
            }

            else {
                swal("Có lỗi xãy ra nên trang web sẽ tải lại", {
                    icon : "warning"
                  }).then(() => {
                      window.location.reload();
                  })
            }
        })
    })
}

function ProcessPaymentTotalTransferOrder() {
    const layoutBillPurchase = document.querySelector(".layout-bill_purchase");

    layoutBillPurchase.addEventListener("click",(e) => {

        swal({
            title: "Thanh toán hết tất cả đơn hàng trong tài khoản?",
            text: "Vui lòng xác nhận thanh toán hết đơn hàng",
            icon: "info",
            buttons: true,
            dangerMode: true,
          })
          .then((willDelete) => {
            if (willDelete) {
                if(localStorage.getItem("username")) {
                    FetchNewBillAllTransferOrder(localStorage.getItem("username"))
                    .then(data => {
                        swal("Thanh Toán Hoàn Tất Hóa Đơn", {
                            icon : "success"
                          }).then(() => {
                            window.location.reload();
                          });

                    })
                    .catch(error => {

                        swal("Có lỗi xảy ra vui lòng thử lại", {
                            icon : "error"
                          });
                    })
                }
        
                else {
                    window.alert("Có lỗi trang web sẽ tải lại");
                    window.location.reload();
                }
            } else {
              swal("Hủy tiến trình", {
                icon : "info"
              });
            }
          });
      
    })
}