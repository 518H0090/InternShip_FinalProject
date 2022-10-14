// Fetch All Restaurant Information 
let fetchAllRestaurants = async () => {

    const url = 'http://localhost:49071/api/Restaurant/GetAllRestaurants';

    const fetchUrl = await fetch(url, {
        method : "GET",
        headers : {
            "Content-Type" : "application/json"
        }
    });

    if (fetchUrl.status !== 200) {
        throw new Error();
    }
    
    const dataJson = await fetchUrl.json();

    return dataJson;
}

// Fetch Restaurant By Title 
let fetchRestaurantByTitle = async (title) => {
    const url = "http://localhost:49071/api/Restaurant/GetRestaurantByTitle/";

    const fetchUrl = await fetch(url+title, {
        method: "GET",
        headers : {
            "Content-Type" : "application/json"
        }
    });

    if (fetchUrl.status !== 200) {
        throw new Error();
    } else {
        const dataJson = await fetchUrl.json();

        return dataJson;
    }
   
}

// Fetch All Category Combine With RestaurantId 
let fetchAllCategoryWithResId = async (restaurantId) => {
    const url = "http://localhost:49071/api/Category/GetAllCategoriesWithRestaurant/";

    const fetchUrl = await fetch(url+restaurantId, {
        method: "GET",
        headers : {
            "Content-Type" : "application/json"
        }
    });

    if (fetchUrl.status !== 200) {
        throw new Error();
    } else {
        const dataJson = await fetchUrl.json();

        return dataJson;
    }
}

// Fetch All Category Combine With It Food In Restaurant
async function FetchAllCategoryCombineFood(restaurantId) {
    const url = "http://localhost:49071/api/CategoryFood/GetAllCategoryCombineFood/";

    const fetchUrl = await fetch(url+restaurantId, {
        method: "GET",
        headers : {
            "Content-Type" : "application/json"
        }
    });

    const dataJson = await fetchUrl.json();

    return dataJson;
}