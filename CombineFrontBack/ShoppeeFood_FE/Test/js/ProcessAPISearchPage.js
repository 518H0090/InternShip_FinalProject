const searchPaginationList = document.querySelector(
  ".searchpagination__list:nth-child(1)"
);
const searchPaginationListSelect = document.querySelector(
  ".searchpagination__list:nth-child(2)"
);

let keysearch = window.location.search;

const searchMenuList = document.querySelector(".searchmenu__list");

var indexSelect = 1;

window.addEventListener("load", (e) => {

  if (keysearch === "") {
    getTotalIndexFood()
    .then((data) => {
      SelectNavigation(data);
      FetchInMenuSearchBarList(indexSelect);

      const searchPaginationItem = document.querySelectorAll(
        ".searchpagination__item"
      );

      searchPaginationItem.forEach((element) => {
        element.firstElementChild.addEventListener("click", (e) => {
          var changeValueIndexPage = Number(e.target.textContent);

          if (changeValueIndexPage > 0) {
            this.indexSelect = changeValueIndexPage;

            actualSelectIndex(indexSelect);
          } else {
            if (
              e.target.classList.contains("searchpagination__item-link--left")
            ) {
              if (indexSelect > 1) {
                this.indexSelect = indexSelect - 1;
              } else if (indexSelect <= 0) {
                this.indexSelect = 1;
              }

              actualSelectIndex(indexSelect);
            } else if (
              e.target.classList.contains("searchpagination__item-link--right")
            ) {
              if (indexSelect >= 1 && indexSelect < data) {
                indexSelect = indexSelect + 1;
              } else if (indexSelect > data) {
                indexSelect = indexSelect - 1;
              }

              actualSelectIndex(indexSelect);
            }
          }

          FetchInMenuSearchBarList(indexSelect);
        });
      });
    })
    .catch((error) => {
      console.log(error);
      searchPaginationList.innerHTML = `<h1 style="height:10rem;transform:translate(20%,140%);color:red;">Not Found Any Value</h1>`;
      searchPaginationListSelect.style.display = "none";
      searchMenuList.style.display = "none";
    });
  } 
  
  else {

    let checkHaveResType = keysearch.indexOf("restype");


    if (checkHaveResType === -1) {
      let keyWordsForSearch = decodeURIComponent(keysearch.split("?")[1].split("=")[1]);

      getTotalIndexFoodWithKeywords(keyWordsForSearch)
      .then((data) => {
        SelectNavigation(data);
        FetchInMenuSearchBarListWithKeyWords(indexSelect,keyWordsForSearch);
  
        const searchPaginationItem = document.querySelectorAll(
          ".searchpagination__item"
        );
  
        searchPaginationItem.forEach((element) => {
          element.firstElementChild.addEventListener("click", (e) => {
            var changeValueIndexPage = Number(e.target.textContent);
  
            if (changeValueIndexPage > 0) {
              this.indexSelect = changeValueIndexPage;
  
              actualSelectIndex(indexSelect);
            } else {
              if (
                e.target.classList.contains("searchpagination__item-link--left")
              ) {
                if (indexSelect > 1) {
                  this.indexSelect = indexSelect - 1;
                } else if (indexSelect <= 0) {
                  this.indexSelect = 1;
                }
  
                actualSelectIndex(indexSelect);
              } else if (
                e.target.classList.contains("searchpagination__item-link--right")
              ) {
                if (indexSelect >= 1 && indexSelect < data) {
                  indexSelect = indexSelect + 1;
                } else if (indexSelect > data) {
                  indexSelect = indexSelect - 1;
                }
  
                actualSelectIndex(indexSelect);
              }
            }
  
            FetchInMenuSearchBarListWithKeyWords(indexSelect,keyWordsForSearch);
          });
        });
      })
      .catch((error) => {
        console.log(error);
        searchPaginationList.innerHTML = `<h1 style="height:10rem;transform:translate(20%,140%);color:red;">${error}</h1>`;
        searchPaginationListSelect.style.display = "none";
        searchMenuList.style.display = "none";
      });
    }

    else {
      let keyWordsForSearch = decodeURIComponent(keysearch.split("?")[1].split("=")[1]);

      console.log(keyWordsForSearch)

      getTotalIndexFoodWithRestaurantType(keyWordsForSearch)
      .then((data) => {
        SelectNavigation(data);
        FetchInMenuSearchBarListWithResType(indexSelect,keyWordsForSearch);
  
        const searchPaginationItem = document.querySelectorAll(
          ".searchpagination__item"
        );
  
        searchPaginationItem.forEach((element) => {
          element.firstElementChild.addEventListener("click", (e) => {
            var changeValueIndexPage = Number(e.target.textContent);
  
            if (changeValueIndexPage > 0) {
              this.indexSelect = changeValueIndexPage;
  
              actualSelectIndex(indexSelect);
            } else {
              if (
                e.target.classList.contains("searchpagination__item-link--left")
              ) {
                if (indexSelect > 1) {
                  this.indexSelect = indexSelect - 1;
                } else if (indexSelect <= 0) {
                  this.indexSelect = 1;
                }
  
                actualSelectIndex(indexSelect);
              } else if (
                e.target.classList.contains("searchpagination__item-link--right")
              ) {
                if (indexSelect >= 1 && indexSelect < data) {
                  indexSelect = indexSelect + 1;
                } else if (indexSelect > data) {
                  indexSelect = indexSelect - 1;
                }
  
                actualSelectIndex(indexSelect);
              }
            }
  
            FetchInMenuSearchBarListWithResType(indexSelect,keyWordsForSearch);
          });
        });
      })
      .catch((error) => {
        console.log(error);
        searchPaginationList.innerHTML = `<h1 style="height:10rem;transform:translate(20%,140%);color:red;">${error}</h1>`;
        searchPaginationListSelect.style.display = "none";
        searchMenuList.style.display = "none";
      });
    }
   
  }
 
});

function actualSelectIndex(indexSelect) {
  searchPaginationListSelect.innerHTML = `
    <!-- Pagination List -->
    <ul class="searchpagination__list">
        <li class="searchpagination__item searchpagination__item--select">
            <a href="#" class="searchpagination__item-link">${indexSelect}</a>
        </li>
    </ul>
    `;
}

function SelectNavigation(data) {
  let newPagination = `
    <!-- Item -->
    <li class="searchpagination__item">
        <a href="#" class="searchpagination__item-link
                searchpagination__item-link--left">
            <i class="fa-solid fa-arrow-left-long"></i>
        </a>
    </li>

    ${SelectNumberIndexPage(data)}
    
    <li class="searchpagination__item">
    <a href="#" class="searchpagination__item-link
            searchpagination__item-link--right">
        <i class="fa-solid fa-arrow-right"></i>
    </a>
    </li>
    `;

  searchPaginationList.innerHTML = newPagination;
}

function SelectNumberIndexPage(params) {
  let indexShowInLayout = [];

  for (let i = 1; i <= params; i++) {
    let dataGet = `
            <li class="searchpagination__item">
                <a href="#"  class="searchpagination__item-link">${i}</a>
            </li>
            `;

    indexShowInLayout.push(dataGet);
  }

  return indexShowInLayout.join(" ");
}

function FetchInMenuSearchBarList(params) {
  FetchFoodIndexPage(params)
    .then((data) => {
      let listFoodFollowIndexPage = data.data;
      let newList = listFoodFollowIndexPage.map((element) => {
        var estimateFoodTitle =
          element.foodTitle.length > 14
            ? element.foodTitle.slice(0, 14) + "..."
            : element.foodTitle;

        var estimateFoodDescription =
          element.foodDescription.length > 14
            ? element.foodDescription.slice(0, 14) + "..."
            : element.foodDescription;

        var existDescription =
          estimateFoodDescription === ""
            ? `Not Found`
            : estimateFoodDescription;

        var foodPrice =
          element.foodPriceLess > 0 ? element.foodPriceLess : element.foodPrice;

        return `
            <!-- Menu Item -->
            <div class="searchmenu__item">
                <a href="./detailfood.html?restaurantId=${element.restaurantId}" class="searchmenu__item-link">
                    <!-- Item Image -->
                    <div class="searchitem__image">
                        <img src="${element.foodImageUrl}" alt="" class="searchitem__img">
                    </div>

                    <!-- Item Content -->
                    <div class="searchitem__content">
                        <i class="fa-solid fa-worm
                                searchitem__content-icon"></i>

                        <h3 class="searchitem__content-title">
                            ${estimateFoodTitle}
                        </h3>

                        <p class="searchitem__content-subtitle">
                            ${existDescription}
                        </p>
                    </div>

                    <!-- Item  Promotion-->
                    <div class="searchitem__promotion">
                        <i class="fa-solid fa-tag
                                searchitem__promotion-icon"></i>

                        <p class="searchitem__promotion-content">${foodPrice}</p>
                    </div>

                    <!-- Open Status -->
                    <div class="opentime-status">
                        <i class="fa-solid fa-circle
                                opentime-status-icon"></i>
                    </div>

                </a>
            </div>
            `;
      });

      searchMenuList.innerHTML = newList;
    })
    .catch((error) => {
      console.log(error);
      searchMenuList.innerHTML = "Not Found Any Value";
    });
}

function FetchInMenuSearchBarListWithKeyWords(params,keywords) {
  FetchFoodIndexPageWithKeywords(params, keywords)
    .then((data) => {
      let listFoodFollowIndexPage = data.data;
      let newList = listFoodFollowIndexPage.map((element) => {
        var estimateFoodTitle =
          element.foodTitle.length > 14
            ? element.foodTitle.slice(0, 14) + "..."
            : element.foodTitle;

        var estimateFoodDescription =
          element.foodDescription.length > 14
            ? element.foodDescription.slice(0, 14) + "..."
            : element.foodDescription;

        var existDescription =
          estimateFoodDescription === ""
            ? `Not Found`
            : estimateFoodDescription;

        var foodPrice =
          element.foodPriceLess > 0 ? element.foodPriceLess : element.foodPrice;

        return `
            <!-- Menu Item -->
            <div class="searchmenu__item">
                <a href="./detailfood.html?restaurantId=${element.restaurantId}" class="searchmenu__item-link">
                    <!-- Item Image -->
                    <div class="searchitem__image">
                        <img src="${element.foodImageUrl}" alt="" class="searchitem__img">
                    </div>

                    <!-- Item Content -->
                    <div class="searchitem__content">
                        <i class="fa-solid fa-worm
                                searchitem__content-icon"></i>

                        <h3 class="searchitem__content-title">
                            ${estimateFoodTitle}
                        </h3>

                        <p class="searchitem__content-subtitle">
                            ${existDescription}
                        </p>
                    </div>

                    <!-- Item  Promotion-->
                    <div class="searchitem__promotion">
                        <i class="fa-solid fa-tag
                                searchitem__promotion-icon"></i>

                        <p class="searchitem__promotion-content">${foodPrice}</p>
                    </div>

                    <!-- Open Status -->
                    <div class="opentime-status">
                        <i class="fa-solid fa-circle
                                opentime-status-icon"></i>
                    </div>

                </a>
            </div>
            `;
      });

      searchMenuList.innerHTML = newList;
    })
    .catch((error) => {
      console.log(error);
      searchMenuList.innerHTML = "Not Found Any Value";
    });
}

function FetchInMenuSearchBarListWithResType(params,keywords) {
  FetchFoodIndexPageWithRestaurantType(params, keywords)
    .then((data) => {
      let listFoodFollowIndexPage = data.data;
      let newList = listFoodFollowIndexPage.map((element) => {
        var estimateFoodTitle =
          element.foodTitle.length > 14
            ? element.foodTitle.slice(0, 14) + "..."
            : element.foodTitle;

        var estimateFoodDescription =
          element.foodDescription.length > 14
            ? element.foodDescription.slice(0, 14) + "..."
            : element.foodDescription;

        var existDescription =
          estimateFoodDescription === ""
            ? `Not Found`
            : estimateFoodDescription;

        var foodPrice =
          element.foodPriceLess > 0 ? element.foodPriceLess : element.foodPrice;

        return `
            <!-- Menu Item -->
            <div class="searchmenu__item">
                <a href="./detailfood.html?restaurantId=${element.restaurantId}" class="searchmenu__item-link">
                    <!-- Item Image -->
                    <div class="searchitem__image">
                        <img src="${element.foodImageUrl}" alt="" class="searchitem__img">
                    </div>

                    <!-- Item Content -->
                    <div class="searchitem__content">
                        <i class="fa-solid fa-worm
                                searchitem__content-icon"></i>

                        <h3 class="searchitem__content-title">
                            ${estimateFoodTitle}
                        </h3>

                        <p class="searchitem__content-subtitle">
                            ${existDescription}
                        </p>
                    </div>

                    <!-- Item  Promotion-->
                    <div class="searchitem__promotion">
                        <i class="fa-solid fa-tag
                                searchitem__promotion-icon"></i>

                        <p class="searchitem__promotion-content">${foodPrice}</p>
                    </div>

                    <!-- Open Status -->
                    <div class="opentime-status">
                        <i class="fa-solid fa-circle
                                opentime-status-icon"></i>
                    </div>

                </a>
            </div>
            `;
      });

      searchMenuList.innerHTML = newList;
    })
    .catch((error) => {
      console.log(error);
      searchMenuList.innerHTML = "Not Found Any Value";
    });
}