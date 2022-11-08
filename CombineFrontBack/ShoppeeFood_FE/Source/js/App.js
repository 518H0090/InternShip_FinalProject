// Fetch All Restaurant Information
let fetchAllRestaurants = async () => {
  const url = "http://localhost:49071/api/Restaurant/all-restaurants";

  const fetchUrl = await fetch(url, {
    method: "GET",
    headers: {
      "Content-Type": "application/json",
    },
  });

  if (fetchUrl.status !== 200) {
    throw new Error();
  }

  const dataJson = await fetchUrl.json();

  return dataJson;
};

// Fetch Restaurant By Title
let fetchRestaurantByTitle = async (title) => {
  const url = "http://localhost:49071/api/Restaurant/restaurant-by-title/";

  const fetchUrl = await fetch(url + title, {
    method: "GET",
    headers: {
      "Content-Type": "application/json",
    },
  });

  if (fetchUrl.status !== 200) {
    throw new Error();
  } else {
    const dataJson = await fetchUrl.json();

    return dataJson;
  }
};

// Fetch All Category Combine With RestaurantId
let fetchAllCategoryWithResId = async (restaurantId) => {
  const url =
    "http://localhost:49071/api/Category/all-categories-with-restaurantid/";

  const fetchUrl = await fetch(url + restaurantId, {
    method: "GET",
    headers: {
      "Content-Type": "application/json",
    },
  });

  if (fetchUrl.status !== 200) {
    throw new Error();
  } else {
    const dataJson = await fetchUrl.json();

    return dataJson;
  }
};

// Fetch All Category Combine With It Food In Restaurant
async function FetchAllCategoryCombineFood(restaurantId) {
  const url =
    "http://localhost:49071/api/CategoryFood/all-categories-combine-food/";

  const fetchUrl = await fetch(url + restaurantId, {
    method: "GET",
    headers: {
      "Content-Type": "application/json",
    },
  });

  const dataJson = await fetchUrl.json();

  return dataJson;
}

// Get Total Index Food
async function getTotalIndexFood() {
  const url = "http://localhost:49071/api/Food/total-index";

  const fetchUrl = await fetch(url);

  const dataJson = await fetchUrl.json();

  return dataJson;
}

// Get Food In IndexPage
async function FetchFoodIndexPage(indexPage) {
  let url = "http://localhost:49071/api/Food/food-with-index/";

  let fetchUrl = await fetch(url + indexPage);

  let dataJson = await fetchUrl.json();

  return dataJson;
}

// Get Total Index Food With Keywords
async function getTotalIndexFoodWithKeywords(keywords) {
  const url = "http://localhost:49071/api/Food/total-index-with-keywords/";

  const fetchUrl = await fetch(url + keywords);

  if (fetchUrl.ok) {
    const dataJson = await fetchUrl.json();

    return dataJson;
  }

  throw new Error("Not Match Value");
}

// Get Food In IndexPage With Keywords
async function FetchFoodIndexPageWithKeywords(indexPage, keywords) {
  let url = `http://localhost:49071/api/Food/food-with-index-and-title`;

  let fetchUrl = await fetch(url, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify({
      indexpage: indexPage,
      keywords: keywords,
    }),
  });

  let dataJson = await fetchUrl.json();

  return dataJson;
}

// Get Restaurant By Id
async function FetchRestaurantById(restaurantId) {
  let url = "http://localhost:49071/api/Restaurant/restaurant-by-id/";

  let fetchUrl = await fetch(url + restaurantId);

  let dataJson = await fetchUrl.json();

  return dataJson;
}

// Post Register Account
async function RegisterAccount(userName, password, rePassword) {
  let url = "http://localhost:49071/api/User/register";

  let fetchUrl = await fetch(url, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify({
      userName: userName,
      password: password,
      rePassword: rePassword,
    }),
  });

  if (fetchUrl.ok) {
    let dataJson = await fetchUrl.json();

    return dataJson;
  }

  throw new Error("Exist Account");
}

// Fetch API Login
async function AuthenAccount(userName, password) {
  let url = "http://localhost:49071/api/User/authen-login";

  let fetchUrl = await fetch(url, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify({
      userName: userName,
      password: password,
    }),
  });

  if (fetchUrl.ok) {
    let dataJson = await fetchUrl.json();

    return dataJson;
  }

  throw new Error(`Can't Login`);
}

// Check User Info
async function CheckUserInfo(jwtToken) {
  let url = "http://localhost:49071/api/User/view-user-info";

  let fetchUrl = await fetch(url, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
      token: jwtToken,
    },
  });

  if (fetchUrl.ok) {
    let dataJson = await fetchUrl.json();

    return dataJson;
  }

  throw new Error(`Can't Find Account`);
}

// Get Total Index Food With RestaurantType
async function getTotalIndexFoodWithRestaurantType(restype) {
  const url = "http://localhost:49071/api/Food/total-index-with-restype";

  const fetchUrl = await fetch(url, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify({
      restaurantType: restype,
    }),
  });

  if (fetchUrl.ok) {
    const dataJson = await fetchUrl.json();

    return dataJson;
  }

  throw new Error("Not Match Value");
}

// Get Food In IndexPage With RestaurantType
async function FetchFoodIndexPageWithRestaurantType(indexPage, restype) {
  let url = `http://localhost:49071/api/Food/food-with-index-and-restype`;

  let fetchUrl = await fetch(url, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify({
      indexpage: indexPage,
      restype: restype,
    }),
  });

  if (fetchUrl.ok) {
    let dataJson = await fetchUrl.json();

    return dataJson;
  }

  throw new Error("Not Found Any Value");
}

// Get All Food Order In Restaurant
async function FetchAllFoodOrderInRestaurant(username, restaurantId) {
  let url = "http://localhost:49071/api/RestaurantOrder/all-restaurant-order";

  let fetchUrl = await fetch(url, {
    method : "POST",
    headers : {
      "Content-Type" : "application/json"
    },
    body : JSON.stringify({
      "restaurantId": restaurantId,
      "username": username
    })
  });

  if (fetchUrl.ok) {
    const dataJson = await fetchUrl.json();

    return dataJson;
  }

  throw new Error("Not Found Any Value");
}

// Add Restaurant Order Food
async function FetchAddRestaurantOrderFood(orderoptions) {
  let url = "http://localhost:49071/api/RestaurantOrder/new-restaurant-order";

  let fetchUrl = await fetch(url , {
    method : "POST",
    headers : {
      "Content-Type" : "application/json"
    },
    body : JSON.stringify({
      "foodImageUrl": orderoptions.foodImageUrl,
      "foodTitle": orderoptions.foodTitle,
      "foodDescription": orderoptions.foodDescription,
      "foodPrice": orderoptions.foodPrice,
      "restaurantId": orderoptions.restaurantId,
      "userName": orderoptions.userName
    })
  });

  if (fetchUrl.ok) {
    let dataJson = await fetchUrl.json();

    return dataJson;
  }

  throw new Error("Can't Create New Order")
}

// Delete Restaurant Order Food
async function FetchDeleteRestaurantOrderFood(orderoptions) {
  let url = "http://localhost:49071/api/RestaurantOrder/delete-restaurant-order";

  let fetchUrl = await fetch(url , {
    method : "DELETE",
    headers : {
      "Content-Type" : "application/json"
    },
    body : JSON.stringify({
        "foodTitle": orderoptions.foodTitle,
        "userName": orderoptions.userName,
        "restaurantId": orderoptions.restaurantId
    })
  });

  if (fetchUrl.ok) {
    let dataJson = await fetchUrl.json();

    return dataJson;
  }

  throw new Error("Can't Create New Order")
}

// Add Transfer Order
async function FetchAddTransferOrder(orderoptions) {
  let url = "http://localhost:49071/api/TransferOrder/new-transfer-order";

  let fetchUrl = await fetch(url , {
    method : "POST",
    headers : {
      "Content-Type" : "application/json"
    },
    body : JSON.stringify(
      orderoptions
    )
  });

  if (fetchUrl.ok) {
    let dataJson = await fetchUrl.json();

    return dataJson;
  }

  throw new Error("Can't Create New Transfer Order")
}

//  Get All Transfer Order
async function FetchAllTransferOrder(username) {
  let url = "http://localhost:49071/api/TransferOrder/all-transfer-order";

  let fetchUrl = await fetch(url , {
    method : "GET",
    headers : {
      "Content-Type" : "application/json",
      username : username
    },
  });

  if (fetchUrl.ok) {
    let dataJson = await fetchUrl.json();

    return dataJson;
  }

  throw new Error("Can't Find Any Value")
}

//  Get All Transfer Order Process
async function FetchAllTransferOrderProcess(username) {
  let url = "http://localhost:49071/api/TransferOrder/all-transfer-order-process";

  let fetchUrl = await fetch(url , {
    method : "GET",
    headers : {
      "Content-Type" : "application/json",
      username : username
    },
  });

  if (fetchUrl.ok) {
    let dataJson = await fetchUrl.json();

    return dataJson;
  }

  throw new Error("Can't Find Any Value")
}

//  New Bill Order
async function FetchNewBillOrder(billoptions) {
  let url = "http://localhost:49071/api/BillOrder/new-bill-order";

  let fetchUrl = await fetch(url , {
    method : "POST",
    headers : {
      "Content-Type" : "application/json",
    },
    body : JSON.stringify(billoptions)
  });

  if (fetchUrl.ok) {
    let dataJson = await fetchUrl.json();

    return dataJson;
  }

  throw new Error("Can't Create New Bill")
}

//  Delete Transfer Order
async function FetchDeleteTransferOrder(transferoptions) {
  let url = "http://localhost:49071/api/TransferOrder/delete-transfer-order";

  let fetchUrl = await fetch(url , {
    method : "DELETE",
    headers : {
      "Content-Type" : "application/json",
    },
    body : JSON.stringify(transferoptions)
  });

  if (fetchUrl.ok) {
    let dataJson = await fetchUrl.json();

    return dataJson;
  }

  throw new Error("Can't Delete Transfer Order")
}

//  New Bill With All Transfer Order
async function FetchNewBillAllTransferOrder(username) {
  let url = "http://localhost:49071/api/BillOrder/new-bill-transfer-process-order";

  let fetchUrl = await fetch(url , {
    method : "POST",
    headers : {
      "Content-Type" : "application/json",
      "username" : username
    }
  });

  if (fetchUrl.ok) {
    let dataJson = await fetchUrl.json();

    return dataJson;
  }

  throw new Error("Can't Create New Bill")
}

window.addEventListener("load", (e) => {
  let jwtToken = localStorage.getItem("jwttoken");
  const navbarSearch = document.querySelector(".navbar-search");
  const navbarLogin = document.querySelector(".navbar-login");

  if (jwtToken !== null) {
    CheckUserInfo(jwtToken)
      .then((data) => {
        navbarSearch.classList.add("navbar-iflogin");
        navbarLogin.classList.add("navbar-iflogin");
        localStorage.setItem("username", data.userName);

        let userNameReduce =
          data.userName.length > 10
            ? data.userName.slice(0, 10) + "..."
            : data.userName;

        let newLayoutNavbar = `
          <p title="${data.userName}">${userNameReduce}</p>
          <button type="button" class="btn btn-login btn-logout">Đăng xuất</button>
          <div class="navbar-login__shoppingcart">
            <i class="fa-sharp fa-solid fa-cart-plus"></i>
            <p class="navbar-shoppingcart__countitem">0</p>
          </div>
        `;

        let viewListShoppingCart = `
        <!-- Display Dropdown Shopping Cart -->
              <div class="navbar-login__shoppingcart-viewlistitem">
                  
                <!-- List Item -->
                <ul class="navbar-shopping__list">
                 
                </ul>

                <!-- View More Shopping Card -->
                <div class="navbar-shopping__viewmore">
                  <p>Xem thêm</p>
                </div>
              </div>`;

          FetchAllTransferOrderProcess(data.userName)
          .then((countItem) => {

            newLayoutNavbar = `
          <p title="${data.userName}">${userNameReduce}</p>
          <button type="button" class="btn btn-login btn-logout">Đăng xuất</button>
          <div class="navbar-login__shoppingcart">
            <i class="fa-sharp fa-solid fa-cart-plus"></i>
            <p class="navbar-shoppingcart__countitem">${countItem.data.length}</p>
          </div>
        `;

            navbarLogin.innerHTML = newLayoutNavbar + viewListShoppingCart;

            ProcessEventMoveToPayment()

            Logout();
          })
          .catch((error) => {
            console.log(error);

            newLayoutNavbar = `
          <p title="${data.userName}">${userNameReduce}</p>
          <button type="button" class="btn btn-login btn-logout">Đăng xuất</button>
          <div class="navbar-login__shoppingcart">
            <i class="fa-sharp fa-solid fa-cart-plus"></i>
            <p class="navbar-shoppingcart__countitem">0</p>
          </div>
        `;

            navbarLogin.innerHTML = newLayoutNavbar + viewListShoppingCart;

            ProcessEventMoveToPayment()
            Logout();
          });     

        navbarLogin.innerHTML = newLayoutNavbar + viewListShoppingCart;

        Logout();

        const btnLogout = document.querySelector(
          ".navbar-login button[type='button']"
        );

        if (btnLogout.value !== null) {
          btnLogout.addEventListener("click", (e) => {
            localStorage.removeItem("jwttoken");
            localStorage.removeItem("username");
            window.location.reload();
          });
        }
      })
      .catch((error) => {
        console.log(error);
        navbarSearch.classList.remove("navbar-iflogin");
        navbarLogin.classList.remove("navbar-iflogin");
      });
  }
});

function Logout() {
  const btnLogout = document.querySelector(
    ".navbar-login button[type='button']"
  );

  if (btnLogout.value !== null) {
    btnLogout.addEventListener("click", (e) => {
      localStorage.removeItem("jwttoken");
      localStorage.removeItem("username");
      window.location.reload();
    });
  }
}

function ProcessEventMoveToPayment() {
  const navbarLoginShoppingCart = document.querySelector(".navbar-login__shoppingcart");

  navbarLoginShoppingCart.addEventListener('click',(e) => {

    if (localStorage.getItem("username")) {
      window.location.href = "./transferorder.html"
    }

    else {
      window.alert("Have Error Then Website will refresh again");
      window.location.reload();
    }
    
  })

}
