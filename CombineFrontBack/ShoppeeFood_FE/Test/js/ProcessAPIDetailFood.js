var locationSearch = decodeURIComponent(
  window.location.search.split("?")[1].split("=")[1]
);

window.addEventListener("load", (e) => {
  e.preventDefault();

  FetchDataInDetailFood(locationSearch);
});

function FetchDataInDetailFood(locationSearch) {
  let checkNumber = Number(locationSearch);

  if (isNaN(checkNumber)) {
    fetchRestaurantByTitle(locationSearch)
      .then((data) => {
        const layoutFoodDetail = document.querySelector(".layout-fooddetail");

        const itemValue = data.data;

        FetchCategoryInRestaurant(itemValue.rsId);
        FetchCategoryFollowFood(itemValue.rsId);

        const itemValueLikeReferences =
          itemValue.rsRefeLike == true
            ? `<!-- Type Shop -->
        <div class="fooddetail__kind">
          <!-- Preference Type -->
          <div class="fooddetail__type-pref">
            <i class="fa-solid fa-thumbs-up fooddetail__type-pref-icon"></i>
            <p class="fooddetail__type-pref-paragraph">Yêu thích</p>
          </div>`
            : `
            <!-- Type Shop -->
            <div class="fooddetail__kind">
            <!-- Preference Type -->
            <div class="fooddetail__type-pref fooddetail__type-prefnone">
            </div>
          `;

        const itemValueReviews =
          Number(itemValue.rsReviews) <= 999
            ? `
        <!-- Number Review -->
        <p class="fooddetail__rating-countreview">
          ${itemValue.rsReviews}
        </p>
        `
            : `
        <!-- Number Review -->
        <p class="fooddetail__rating-countreview">
          999+
        </p>
        `;

        let newInfo = `<!-- Container -->
        <div class="container fooddetail__container">
          <!-- Food Detail Image -->
          <div class="fooddetail__image">
            <img src="${itemValue.rsImageUrl}" alt=""
              class="fooddetail__img">
          </div>
    
          <!-- Food Detail Information -->
          <div class="fooddetail__info">
            <!-- Breadcrumb -->
            <ul class="fooddetail__breadcrumb-list">
              <li class="fooddetail__breadcrumb-item">
                <a href="#">Home</a>
              </li>
    
              <li class="fooddetail__breadcrumb-item">
                <i class="fa-sharp fa-solid fa-arrow-right-to-bracket"></i>
              </li>
    
              <li class="fooddetail__breadcrumb-item">
                <a href="#">${itemValue.rsProvince}</a>
              </li>
    
              <li class="fooddetail__breadcrumb-item">
                <i class="fa-sharp fa-solid fa-arrow-right-to-bracket"></i>
              </li>
    
              <li class="fooddetail__breadcrumb-item">
                <a href="#">${itemValue.rsTitle}</a>
              </li>
            </ul>
    
            ${itemValueLikeReferences}
    
              <!-- Name Type -->
              <div class="fooddetail__type-name">
                <p>${itemValue.rsType}</p>
              </div>
            </div>
    
            <!-- Shop  Name -->
            <h3 class="fooddetail__shopname">${itemValue.rsTitle}</h3>
    
            <!-- Shop Address -->
            <p class="fooddetail__address">${itemValue.rsAddress}</p>
    
            <!-- Shop Rating -->
            <div class="fooddetail__rating">
              <!-- Rating Stars -->
              <div class="fooddetail__rating-stars">
                ${checkStarts(itemValue.rsStar)}
              </div>
    
              ${itemValueReviews}
    
              <!-- Description -->
              <p class="fooddetail__rating-desc">đánh giá từ trên ShopeeFood</p>
    
              <!-- View More Rating -->
              <div class="fooddetail__morerating">
                <a href="#" class="fooddetail__morerating-link">Xem thêm lượt đánh giá từ Foody</a>
              </div>
    
            </div>
    
            <!-- Shop Status -->
            <div class="fooddetail__status">
              <!-- Status Open -->
              <div class="fooddetail__status-open" title="Mở cửa">
                <i class="fa-solid fa-circle"></i>
                <span>Mở cửa</span>
              </div>
    
              <!-- Time Work -->
              <div class="fooddetail__status-work">
                <i class="fa-solid fa-clock"></i>
                <span>${itemValue.rsOpenTime}</span>
              </div>
            </div>
    
            <!-- Shop Cost -->
            <div class="fooddetail__cost">
              <i class="fa-solid fa-money-check-dollar"></i>
              <span>${itemValue.rsPrinceRange}</span>
            </div>
    
            <!-- Underline -->
            <hr class="fooddetail__underline">
    
            <!-- Utility -->
            <div class="fooddetail__utility">
              <!-- Utility Item -->
              <div class="fooddetail__utility-item">
                <!-- Title -->
                <h3 class="fooddetail__utility-title">phí dịch vụ</h3>
                <!-- Content -->
                <p class="fooddetail__utility-content">0.0% Phí phục vụ</p>
    
                <!-- Utility Partner -->
                <div class="fooddetail__utility-partner">
                  <a href="#" class="fooddetail__utility-partner-link">
                    <i class="fa-sharp fa-solid fa-shield"></i>
                    <span>Quán Đối Tác</span>
                  </a>
                </div>
              </div>
    
              <!-- Utility Item -->
              <div class="fooddetail__utility-item">
                <!-- Title -->
                <h3 class="fooddetail__utility-title">dịch vụ bởi</h3>
                <!-- Content -->
                <p class="fooddetail__utility-content">ShopeeFood</p>
              </div>
    
    
            </div>
    
          </div>
        </div>`;

        layoutFoodDetail.innerHTML = newInfo;
      })
      .catch((errorValue) => {
        console.log(errorValue.message);
        layoutFoodDetail.innerHTML = "Not Found Ok";
      });
  } else {
    FetchRestaurantById(checkNumber)
      .then((data) => {
        const layoutFoodDetail = document.querySelector(".layout-fooddetail");

        const itemValue = data.data;

        FetchCategoryInRestaurant(checkNumber);
        FetchCategoryFollowFood(checkNumber);

        const itemValueLikeReferences =
          itemValue.rsRefeLike == true
            ? `<!-- Type Shop -->
        <div class="fooddetail__kind">
          <!-- Preference Type -->
          <div class="fooddetail__type-pref">
            <i class="fa-solid fa-thumbs-up fooddetail__type-pref-icon"></i>
            <p class="fooddetail__type-pref-paragraph">Yêu thích</p>
          </div>`
            : `
            <!-- Type Shop -->
            <div class="fooddetail__kind">
            <!-- Preference Type -->
            <div class="fooddetail__type-pref fooddetail__type-prefnone">
            </div>
          `;

        const itemValueReviews =
          Number(itemValue.rsReviews) <= 999
            ? `
        <!-- Number Review -->
        <p class="fooddetail__rating-countreview">
          ${itemValue.rsReviews}
        </p>
        `
            : `
        <!-- Number Review -->
        <p class="fooddetail__rating-countreview">
          999+
        </p>
        `;

        let newInfo = `<!-- Container -->
        <div class="container fooddetail__container">
          <!-- Food Detail Image -->
          <div class="fooddetail__image">
            <img src="${itemValue.rsImageUrl}" alt=""
              class="fooddetail__img">
          </div>
    
          <!-- Food Detail Information -->
          <div class="fooddetail__info">
            <!-- Breadcrumb -->
            <ul class="fooddetail__breadcrumb-list">
              <li class="fooddetail__breadcrumb-item">
                <a href="#">Home</a>
              </li>
    
              <li class="fooddetail__breadcrumb-item">
                <i class="fa-sharp fa-solid fa-arrow-right-to-bracket"></i>
              </li>
    
              <li class="fooddetail__breadcrumb-item">
                <a href="#">${itemValue.rsProvince}</a>
              </li>
    
              <li class="fooddetail__breadcrumb-item">
                <i class="fa-sharp fa-solid fa-arrow-right-to-bracket"></i>
              </li>
    
              <li class="fooddetail__breadcrumb-item">
                <a href="#">${itemValue.rsTitle}</a>
              </li>
            </ul>
    
            ${itemValueLikeReferences}
    
              <!-- Name Type -->
              <div class="fooddetail__type-name">
                <p>${itemValue.rsType}</p>
              </div>
            </div>
    
            <!-- Shop  Name -->
            <h3 class="fooddetail__shopname">${itemValue.rsTitle}</h3>
    
            <!-- Shop Address -->
            <p class="fooddetail__address">${itemValue.rsAddress}</p>
    
            <!-- Shop Rating -->
            <div class="fooddetail__rating">
              <!-- Rating Stars -->
              <div class="fooddetail__rating-stars">
                ${checkStarts(itemValue.rsStar)}
              </div>
    
              ${itemValueReviews}
    
              <!-- Description -->
              <p class="fooddetail__rating-desc">đánh giá từ trên ShopeeFood</p>
    
              <!-- View More Rating -->
              <div class="fooddetail__morerating">
                <a href="#" class="fooddetail__morerating-link">Xem thêm lượt đánh giá từ Foody</a>
              </div>
    
            </div>
    
            <!-- Shop Status -->
            <div class="fooddetail__status">
              <!-- Status Open -->
              <div class="fooddetail__status-open" title="Mở cửa">
                <i class="fa-solid fa-circle"></i>
                <span>Mở cửa</span>
              </div>
    
              <!-- Time Work -->
              <div class="fooddetail__status-work">
                <i class="fa-solid fa-clock"></i>
                <span>${itemValue.rsOpenTime}</span>
              </div>
            </div>
    
            <!-- Shop Cost -->
            <div class="fooddetail__cost">
              <i class="fa-solid fa-money-check-dollar"></i>
              <span>${itemValue.rsPrinceRange}</span>
            </div>
    
            <!-- Underline -->
            <hr class="fooddetail__underline">
    
            <!-- Utility -->
            <div class="fooddetail__utility">
              <!-- Utility Item -->
              <div class="fooddetail__utility-item">
                <!-- Title -->
                <h3 class="fooddetail__utility-title">phí dịch vụ</h3>
                <!-- Content -->
                <p class="fooddetail__utility-content">0.0% Phí phục vụ</p>
    
                <!-- Utility Partner -->
                <div class="fooddetail__utility-partner">
                  <a href="#" class="fooddetail__utility-partner-link">
                    <i class="fa-sharp fa-solid fa-shield"></i>
                    <span>Quán Đối Tác</span>
                  </a>
                </div>
              </div>
    
              <!-- Utility Item -->
              <div class="fooddetail__utility-item">
                <!-- Title -->
                <h3 class="fooddetail__utility-title">dịch vụ bởi</h3>
                <!-- Content -->
                <p class="fooddetail__utility-content">ShopeeFood</p>
              </div>
    
    
            </div>
    
          </div>
        </div>`;

        layoutFoodDetail.innerHTML = newInfo;
      })
      .catch((errorValue) => {
        console.log(errorValue.message);
        layoutFoodDetail.innerHTML = "Not Found Ok";
      });
  }
}

function checkStarts(number) {
  let generateStar = `<div class="full-star">
        <i class="fa-solid fa-star"></i>
      </div>`;

  let generateHalfStar = `
        <div class="half-star">
        <i class="fa-sharp fa-solid fa-star-half-stroke"></i>
      </div>
        `;

  let generateNoneStar = `
        <div class="none-star">
        <i class="fa-regular fa-star"></i>
      </div>
        `;

  let generateStarInHtml = [];

  switch (Number(number)) {
    case 5:
      generateStarInHtml.push(
        generateStar,
        generateStar,
        generateStar,
        generateStar,
        generateStar
      );
      break;
    case 4.5:
      generateStarInHtml.push(
        generateStar,
        generateStar,
        generateStar,
        generateStar,
        generateHalfStar
      );
      break;
    case 4:
      generateStarInHtml.push(
        generateStar,
        generateStar,
        generateStar,
        generateStar,
        generateNoneStar
      );
      break;
    case 3.5:
      generateStarInHtml.push(
        generateStar,
        generateStar,
        generateStar,
        generateHalfStar,
        generateNoneStar
      );
      break;
    case 3:
      generateStarInHtml.push(
        generateStar,
        generateStar,
        generateStar,
        generateNoneStar,
        generateNoneStar
      );
      break;
    case 2.5:
      generateStarInHtml.push(
        generateStar,
        generateStar,
        generateHalfStar,
        generateNoneStar,
        generateNoneStar
      );
      break;
    case 2:
      generateStarInHtml.push(
        generateStar,
        generateStar,
        generateNoneStar,
        generateNoneStar,
        generateNoneStar
      );
      break;
    case 1.5:
      generateStarInHtml.push(
        generateStar,
        generateHalfStar,
        generateNoneStar,
        generateNoneStar,
        generateNoneStar
      );
      break;
    case 1:
      generateStarInHtml.push(
        generateStar,
        generateNoneStar,
        generateNoneStar,
        generateNoneStar,
        generateNoneStar
      );
      break;

    default:
      generateStarInHtml.push(
        generateNoneStar,
        generateNoneStar,
        generateNoneStar,
        generateNoneStar,
        generateNoneStar
      );
      break;
  }

  return generateStarInHtml.join(" ");
}

function FetchCategoryInRestaurant(params) {
  const foodOptionsList = document.querySelector(".foodoptions__list");

  fetchAllCategoryWithResId(params)
    .then((data) => {
      let listCategory = data.data;

      let newList = listCategory
        .map((element) => {
          let setCategoryName =
            element.categoryName.length > 22
              ? element.categoryName.slice(0, 22) + "..."
              : element.categoryName;

          return ` <!-- Category Item -->
    <li class="foodoptions__item">
      <a href="#${element.categoryTag}" style="text-decoration:none;color:#333;">
        <span>${setCategoryName}</span>
      </a>
    </li>`;
        })
        .join(" ");

      foodOptionsList.innerHTML = newList;
    })
    .catch((error) => {
      console.log(error);
      foodOptionsList.innerHTML = "Not Found Ok";
    });
}

function FetchCategoryFollowFood(params) {
  const foodOptionsDetailMenulist = document.querySelector(
    ".foodoptions__detail-menulist"
  );

  FetchAllCategoryCombineFood(params)
    .then((data) => {
      let listCategoryCombineFood = data.data;

      let newList = listCategoryCombineFood.map((element) => {
        let listFoodInCategory = element.foods.map((food) => {
          let havePricesLess = food.foodPriceLess > 0 ? true : false;

          if (havePricesLess) {
            return `
        <!-- Item -->
        <div class="foodoptions__menulist-item foodoptions__menulist-item--costless">
          <!-- Image -->
          <div class="foodoptions__menuitem-image">
            <img src="${food.foodImageUrl}" alt=""
              class="foodoptions__menuitem-img">
          </div>

          <!-- Content -->
          <div class="foodoptions__menuitem-content">
            <h4 class="foodoptions__menuitem-title">${food.foodTitle}</h4>
            <p class="foodoptions__menuitem-subtitle">${food.foodDescription}</p>
          </div>

          <!-- More -->
          <div class="foodoptions__menuitem-more">
            <p class="foodoptions__menuitem-costactual">
              ${food.foodPrice} <sup>đ</sup>
            </p>

            <p class="foodoptions__menuitem-cost">
              ${food.foodPriceLess} <sup>đ</sup>
            </p>

            <button type="button" class="foodoptions__menuitem-btn">
              <i class="fa-solid fa-plus foodoptions__menuitem-icon"></i>
            </button>
          </div>

        </div>
      `;
          } else {
            return `
        <!-- Item -->
        <div class="foodoptions__menulist-item">
          <!-- Image -->
          <div class="foodoptions__menuitem-image">
            <img src="${food.foodImageUrl}" alt=""
              class="foodoptions__menuitem-img">
          </div>

          <!-- Content -->
          <div class="foodoptions__menuitem-content">
            <h4 class="foodoptions__menuitem-title">${food.foodTitle}</h4>
            <p class="foodoptions__menuitem-subtitle">${food.foodDescription}</p>
          </div>

          <!-- More -->
          <div class="foodoptions__menuitem-more">

            <p class="foodoptions__menuitem-cost">
              ${food.foodPrice} <sup>đ</sup>
            </p>

            <button type="button" class="foodoptions__menuitem-btn">
              <i class="fa-solid fa-plus foodoptions__menuitem-icon"></i>
            </button>
          </div>

        </div>
      `;
          }
        });

        return ` 
    <!-- Title -->
    <div class="foodoptions__menulist-title">
        <span id="${element.categoryTag}">${element.categoryName}</span>
    </div>

    <!-- List Food  -->
    <div class="foodoptions__menulist-foodlist">
    ${listFoodInCategory}
    </div>
    `;
      });

      foodOptionsDetailMenulist.innerHTML = newList.join(" ");


      // click
      const foodoptionsMenuitemBtn = document.querySelectorAll('.foodoptions__menulist-item');

      foodoptionsMenuitemBtn.forEach(element => {
        element.lastElementChild.lastElementChild.addEventListener('click',(e) => {

          let checkContainsLess = e.target.parentElement.parentElement.parentElement.classList
          .contains("foodoptions__menulist-item--costless");

          let foodInfo = ""

          if (checkContainsLess) {
            foodInfo = {
            foodImageUrl : e.target.parentElement.parentElement.parentElement.firstElementChild
            .firstElementChild.getAttribute("src"),
            foodTitle : e.target.parentElement.parentElement.parentElement.firstElementChild.nextElementSibling.firstElementChild.innerText,
            foodDescription: e.target.parentElement.parentElement.parentElement.firstElementChild.nextElementSibling.lastElementChild.innerText,
            foodPrice : e.target.parentElement.parentElement.firstElementChild.nextElementSibling
            .innerText.split(" ")[0]
            }  
          } else {
            foodInfo = {
              foodImageUrl : e.target.parentElement.parentElement.parentElement.firstElementChild
              .firstElementChild.getAttribute("src"),
              foodTitle : e.target.parentElement.parentElement.parentElement.firstElementChild.nextElementSibling.firstElementChild.innerText,
              foodDescription: e.target.parentElement.parentElement.parentElement.firstElementChild.nextElementSibling.lastElementChild.innerText,
              foodPrice : e.target.parentElement.parentElement.firstElementChild.innerText.split(" ")[0]
              }  
          }


          if (localStorage.getItem("username") === null) {
            window.location.reload();
          } else {
            AddNewItemInShoppingCart(localStorage.getItem("username"), foodInfo)
            .then(data => {
              console.log(data.data)
              window.location.reload();
            }).catch(error => {
              console.log(error)
            })
            ;
          }

        })
      })

    })
    .catch((error) => {
      console.log(error);
      foodOptionsDetailMenulist.innerHTML = "Not Found Ok";
    });
}
