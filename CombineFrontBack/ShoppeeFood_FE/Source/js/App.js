// Fetch All Restaurant Information
let fetchAllRestaurants = async () => {
  const url = "http://localhost:49071/api/Restaurant/GetAllRestaurants";

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
  const url = "http://localhost:49071/api/Restaurant/GetRestaurantByTitle/";

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
    "http://localhost:49071/api/Category/GetAllCategoriesWithRestaurant/";

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
    "http://localhost:49071/api/CategoryFood/GetAllCategoryCombineFood/";

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
  const url = "http://localhost:49071/api/Food/GetTotalIndex";

  const fetchUrl = await fetch(url);

  const dataJson = await fetchUrl.json();

  return dataJson;
}

// Get Food In IndexPage
async function FetchFoodIndexPage(indexPage) {
  let url = "http://localhost:49071/api/Food/GetFoodWithIndex/";

  let fetchUrl = await fetch(url + indexPage);

  let dataJson = await fetchUrl.json();

  return dataJson;
}

// Get Restaurant By Id
async function FetchRestaurantById(restaurantId) {
  let url = "http://localhost:49071/api/Restaurant/GetRestaurantById/";

  let fetchUrl = await fetch(url + restaurantId);

  let dataJson = await fetchUrl.json();

  return dataJson;
}

// Post Register Account
async function RegisterAccount(userName, password, rePassword) {
  let url = "http://localhost:49071/api/User/Register";

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
async function RegisterAccount(userName, password) {
  let url = "http://localhost:49071/api/User/AuthenLogin";

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
   let url = "http://localhost:49071/api/User/ViewUserInfo?jwtToken="

   let fetchUrl = await fetch(url+jwtToken, {
    method : "GET",
    headers: {
      "Content-Type" : "application/json"
    },
  });

  if(fetchUrl.ok) {
    let dataJson = await fetchUrl.json();

    return dataJson;
  }

  throw new Error(`Can't Find Account`)
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

      let newLayoutNavbar = `
        <p title="${data.userName}">${userNameReduce}</p>
        <button type="button" class="btn btn-login btn-logout">Đăng xuất</button>
        <div class="navbar-login__shoppingcart">
          <i class="fa-sharp fa-solid fa-cart-plus"></i>
          <p class="navbar-shoppingcart__countitem">0</p>
        </div>
      `

      navbarLogin.innerHTML = newLayoutNavbar;  

      const btnLogout = document.querySelector(".navbar-login button[type='button']")

      if(btnLogout.value !== null) {
        btnLogout.addEventListener('click',(e) => {
          localStorage.removeItem("jwttoken")
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