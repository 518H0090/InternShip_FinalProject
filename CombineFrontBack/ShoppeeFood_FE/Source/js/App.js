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

  const fetchUrl = await fetch(url+keywords);


  if (fetchUrl.ok) {
    const dataJson = await fetchUrl.json();

    return dataJson;
  }

  throw new Error('Not Match Value');
 
}

// Get Food In IndexPage With Keywords
async function FetchFoodIndexPageWithKeywords(indexPage,keywords) {
  let url = `http://localhost:49071/api/Food/food-with-index-and-title`;

  let fetchUrl = await fetch(url, {
    method : "POST",
    headers: {
      "Content-Type" : "application/json"
    },
    body: JSON.stringify({
        "indexpage": indexPage,
        "keywords": keywords
    })
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
    method : "POST",
    headers: {
      "Content-Type" : "application/json"
    },
    body: JSON.stringify({
        "userName": userName,
        "password": password,
        "rePassword": rePassword
    })
  });

  if(fetchUrl.ok) {
    let dataJson = await fetchUrl.json();

    return dataJson;
  }

  throw new Error('Exist Account')
 
}

// Fetch API Login
async function AuthenAccount(userName, password) {
  let url = "http://localhost:49071/api/User/authen-login";

  let fetchUrl = await fetch(url, {
    method : "POST",
    headers: {
      "Content-Type" : "application/json"
    },
    body: JSON.stringify({
        "userName": userName,
        "password": password,
    })
  });

  if(fetchUrl.ok) {
    let dataJson = await fetchUrl.json();

    return dataJson;
  }

  throw new Error(`Can't Login`)
 
}

// Check User Info
async function CheckUserInfo(jwtToken) {
   let url = "http://localhost:49071/api/User/view-user-info?jwtToken="

   let fetchUrl = await fetch(url+jwtToken, {
    method : "GET",
    headers: {
      "Content-Type" : "application/json",
    },
  });

  if(fetchUrl.ok) {
    let dataJson = await fetchUrl.json();

    return dataJson;
  }

  throw new Error(`Can't Find Account`)
}

// Get Count Number item in Shopping Cart Follow Username
async function countItemInShoppingCart(username) {
  let url = "http://localhost:49071/api/FoodRecord/count-number-record-follow-user/"

  let fetchUrl = await fetch(url+username, {
   method : "GET",
   headers: {
     "Content-Type" : "application/json"
   },
 });

 if(fetchUrl.ok) {
   let dataJson = await fetchUrl.json();

   return dataJson;
 }

 throw new Error(`Doesn't Have Any value`)
}

// Get 6 item in Shopping Cart Follow Username
async function Get6ItemInShoppingCart(username) {
  let url = "http://localhost:49071/api/FoodRecord/GetTop6Record/"

  let fetchUrl = await fetch(url+username, {
   method : "GET",
   headers: {
     "Content-Type" : "application/json"
   },
 });

 if(fetchUrl.ok) {
   let dataJson = await fetchUrl.json();

   return dataJson;
 }

 throw new Error(`Doesn't Have Any value`)
}

// Get All item in Shopping Cart Follow Username
async function GetAllItemInShoppingCart(username) {
  let url = "http://localhost:49071/api/FoodRecord/GetAllRecord/"

  let fetchUrl = await fetch(url+username, {
   method : "GET",
   headers: {
     "Content-Type" : "application/json"
   },
 });

 if(fetchUrl.ok) {
   let dataJson = await fetchUrl.json();

   return dataJson;
 }

 throw new Error(`Doesn't Have Any value`)
}

// Get Total Price in Shopping Cart Follow Username
async function GetTotalPriceInShoppingCart(username) {
  let url = "http://localhost:49071/api/FoodRecord/GetTotalPriceBill/"

  let fetchUrl = await fetch(url+username, {
   method : "GET",
   headers: {
     "Content-Type" : "application/json"
   },
 });

 if(fetchUrl.ok) {
   let dataJson = await fetchUrl.json();

   return dataJson;
 }

 throw new Error(`Can't Add Item`)
}


// Add item in Shopping Cart Follow Username
async function AddNewItemInShoppingCart(username,foodInfo) {
  let url = "http://localhost:49071/api/FoodRecord/AddNewItemInShoppingCart/"

  let fetchUrl = await fetch(url+username, {
   method : "POST",
   headers: {
     "Content-Type" : "application/json"
   },
   body : JSON.stringify({
    "foodImageUrl": foodInfo.foodImageUrl,
    "foodTitle": foodInfo.foodTitle,
    "foodDescription": foodInfo.foodDescription,
    "foodPrice": foodInfo.foodPrice
   })
 });

 if(fetchUrl.ok) {
   let dataJson = await fetchUrl.json();

   return dataJson;
 }

 throw new Error(`Doesn't Have Any value`)
}

// Delete item in Shopping Cart Follow Username
async function DeleteNewItemInShoppingCart(username,recordId) {
  let url = "http://localhost:49071/api/FoodRecord/DeleteItemInShoppingCart"

  let fetchUrl = await fetch(url, {
   method : "Delete",
   headers: {
     "Content-Type" : "application/json"
   },
   body : JSON.stringify({
    "recordId": recordId,
    "username": username
    })
 });

 if(fetchUrl.ok) {
   let dataJson = await fetchUrl.json();

   return dataJson;
 }

 throw new Error(`Can't Delete Item`)
}

// Create Bill in Shopping Cart Follow Username
async function NewBillInShoppingCart(username,totalCost) {
  let url = "http://localhost:49071/api/Bill/CreateNewBill"

  let fetchUrl = await fetch(url, {
   method : "POST",
   headers: {
     "Content-Type" : "application/json"
   },
   body : JSON.stringify(
    {
      "totalPayment": totalCost,
      "useName": username
    }
   )
 });

 if(fetchUrl.ok) {
   let dataJson = await fetchUrl.json();

   return dataJson;
 }

 throw new Error(`Can't Process Bill`)
}

window.addEventListener("load",(e) => {
  let jwtToken =  localStorage.getItem("jwttoken");
  const navbarSearch = document.querySelector('.navbar-search');
  const navbarLogin = document.querySelector('.navbar-login');

  if (jwtToken !== null) {
    CheckUserInfo(jwtToken)
    .then(data => {
      navbarSearch.classList.add("navbar-iflogin")
      navbarLogin.classList.add("navbar-iflogin")

      let userNameReduce = data.userName.length > 10 ? data.userName.slice(0,10) + "..." : data.userName;
      localStorage.setItem("username",data.userName)

        let newLayoutNavbar = `
          <p title="${data.userName}">${userNameReduce}</p>
          <button type="button" class="btn btn-login btn-logout">Đăng xuất</button>
          <div class="navbar-login__shoppingcart">
            <i class="fa-sharp fa-solid fa-cart-plus"></i>
            <p class="navbar-shoppingcart__countitem">0</p>
          </div>
        `

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
              </div>`

        countItemInShoppingCart(data.userName)
        .then(countItem => {
          newLayoutNavbar = `
          <p title="${data.userName}">${userNameReduce}</p>
          <button type="button" class="btn btn-login btn-logout">Đăng xuất</button>
          <div class="navbar-login__shoppingcart">
            <i class="fa-sharp fa-solid fa-cart-plus"></i>
            <p class="navbar-shoppingcart__countitem">${countItem}</p>
          </div>
        `

        navbarLogin.innerHTML = newLayoutNavbar + viewListShoppingCart;
        ProcessEventShoppingDropdown();

        Logout();

        }).catch(error => {
          console.log(error);
          
          newLayoutNavbar = `
          <p title="${data.userName}">${userNameReduce}</p>
          <button type="button" class="btn btn-login btn-logout">Đăng xuất</button>
          <div class="navbar-login__shoppingcart">
            <i class="fa-sharp fa-solid fa-cart-plus"></i>
            <p class="navbar-shoppingcart__countitem">0</p>
          </div>
        `

        navbarLogin.innerHTML = newLayoutNavbar + viewListShoppingCart;
        ProcessEventShoppingDropdown();
        })

        Get6ItemInShoppingCart(data.userName)
        .then(itemlist => {
          let listItemShoppingCart = itemlist.data;

          const navbarShoppingList = document.querySelector('.navbar-login.navbar-iflogin .navbar-shopping__list')

          let newListItem = listItemShoppingCart.map(element => {

            let reduceFoodTitle = element.foodTitle.length > 14 ? element.foodTitle.slice(0,14) + "..." : element.foodTitle;

            return `  <!-- Item -->
            <li class="navbar-shopping__item">
              <!-- Image -->
              <div class="navbar-shopping__image">
                <img src="${element.foodImageUrl}" alt="" class="navbar-shopping__img">
              </div>

              <!-- Content -->
              <div class="navbar-shopping__content">
                <h3 class="navbar-shopping__content-title">${reduceFoodTitle}</h3>
                <p class="navbar-shopping__content-cost">${element.foodPrice} <sup>đ</sup> </p>
              </div>
            </li>`
          });
                

          navbarShoppingList.innerHTML = newListItem
         

         
          Logout();
        }).catch(error => {
          console.log(error)
          const navbarShoppingList = document.querySelector('.navbar-login.navbar-iflogin .navbar-shopping__list')
        })

        navbarLogin.innerHTML = newLayoutNavbar + viewListShoppingCart;

        ProcessEventShoppingDropdown();
        Logout();

      const btnLogout = document.querySelector(".navbar-login button[type='button']")

      if(btnLogout.value !== null) {
        btnLogout.addEventListener('click',(e) => {
          localStorage.removeItem("jwttoken")
          localStorage.removeItem("username")
          window.location.reload();
        })
      }
    })
    .catch(error => {
      console.log(error)
      navbarSearch.classList.remove("navbar-iflogin")
      navbarLogin.classList.remove("navbar-iflogin")
    })
  }
})


function ProcessEventShoppingDropdown() {
  // Move To Shopping Cart Page
  const navbarShoppingViewmore = document.querySelector('.navbar-shopping__viewmore');
  const navbarLoginShoppingcartViewlistitemValue = document.querySelector('.navbar-login__shoppingcart-viewlistitem .navbar-shopping__list')

  navbarShoppingViewmore.addEventListener('click',(e) => {
    window.location.href = "./shoppingcard.html?username=" + localStorage.getItem("username")
  })

  // Toggle Shopping Cart View
  const navbarLoginShoppingcart = document.querySelector('.navbar-login__shoppingcart');
  const navbarLoginShoppingcartViewlistitem = document.querySelector('.navbar-login .navbar-login__shoppingcart-viewlistitem');

  navbarLoginShoppingcart.addEventListener('click',(e) => {
    navbarLoginShoppingcartViewlistitem.classList.toggle('show')

      if (navbarLoginShoppingcartViewlistitem.firstElementChild.innerText === '') {
        
        window.alert("You Must Have Item In Shopping Cart \n Or Maybe System Is Lagging so It Will Refresh Later \n Please Wait");
        navbarLoginShoppingcartViewlistitem.classList.remove("show");
        window.location.reload();

      }
  })
}

function Logout() {
  const btnLogout = document.querySelector(".navbar-login button[type='button']")

      if(btnLogout.value !== null) {
        btnLogout.addEventListener('click',(e) => {
          localStorage.removeItem("jwttoken")
          localStorage.removeItem("username")
          window.location.reload();
        })
      }
}

