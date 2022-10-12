// Test Fetch Data In Console

fetch('http://localhost:49071/api/Restaurant/GetAllRestaurants')
.then(response => response.json())
.then(data => {
    data.data.forEach(element => {
        console.log(element)
    });
});

