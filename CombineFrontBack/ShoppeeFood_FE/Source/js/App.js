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