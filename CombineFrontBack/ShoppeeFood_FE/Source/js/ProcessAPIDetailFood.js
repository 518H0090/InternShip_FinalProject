var locationSearch = decodeURIComponent(window.location.search.split("?")[1].split("=")[1])

console.log(locationSearch)

window.addEventListener('load',(e) => {
    e.preventDefault();

    FetchDataInDetailFood(locationSearch)
})

function FetchDataInDetailFood(locationSearch) {
    fetchRestaurantByTitle(locationSearch).then(data => {
        const layoutFoodDetail = document.querySelector('.layout-fooddetail');
    
        const itemValue = data.data
    
        const itemValueLikeReferences = itemValue.rsRefeLike == true?
        `<!-- Type Shop -->
        <div class="fooddetail__kind">
          <!-- Preference Type -->
          <div class="fooddetail__type-pref">
            <i class="fa-solid fa-thumbs-up fooddetail__type-pref-icon"></i>
            <p class="fooddetail__type-pref-paragraph">Yêu thích</p>
          </div>`: 
          `
            <!-- Type Shop -->
            <div class="fooddetail__kind">
            <!-- Preference Type -->
            <div class="fooddetail__type-pref fooddetail__type-prefnone">
            </div>
          `; 
    
        const itemValueReviews = Number(itemValue.rsReviews) <= 999 ?  
        `
        <!-- Number Review -->
        <p class="fooddetail__rating-countreview">
          ${itemValue.rsReviews}
        </p>
        ` :
        `
        <!-- Number Review -->
        <p class="fooddetail__rating-countreview">
          999+
        </p>
        `
    
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
    
        layoutFoodDetail.innerHTML = newInfo
    
    }).catch(errorValue => {
        console.log(errorValue.message)
    })

    function checkStarts(number) {
        let generateStar = `<div class="full-star">
        <i class="fa-solid fa-star"></i>
      </div>`
    
        let generateHalfStar = `
        <div class="half-star">
        <i class="fa-sharp fa-solid fa-star-half-stroke"></i>
      </div>
        `
    
        let generateNoneStar = `
        <div class="none-star">
        <i class="fa-regular fa-star"></i>
      </div>
        `
    
        let generateStarInHtml = [];
    
        switch (Number(number)) {
            case 5:
                generateStarInHtml.push(generateStar,generateStar,generateStar,generateStar,generateStar)
                break;
            case 4.5:    
                generateStarInHtml.push(generateStar,generateStar,generateStar,generateStar,generateHalfStar)
                break;
            case 4:    
                generateStarInHtml.push(generateStar,generateStar,generateStar,generateStar,generateNoneStar)
                break;
            case 3.5:
                generateStarInHtml.push(generateStar,generateStar,generateStar,generateHalfStar,generateNoneStar)
                break;    
            case 3:
                generateStarInHtml.push(generateStar,generateStar,generateStar,generateNoneStar,generateNoneStar)
                break;   
            case 2.5:
                generateStarInHtml.push(generateStar,generateStar,generateHalfStar,generateNoneStar,generateNoneStar)
                break;   
            case 2:
                generateStarInHtml.push(generateStar,generateStar,generateNoneStar,generateNoneStar,generateNoneStar)
                break;  
            case 1.5:
                    generateStarInHtml.push(generateStar,generateHalfStar,generateNoneStar,generateNoneStar,generateNoneStar)
                    break;      
            case 1:
                generateStarInHtml.push(generateStar,generateNoneStar,generateNoneStar,generateNoneStar,generateNoneStar)
                break;    
    
            default:
                generateStarInHtml.push(generateNoneStar,generateNoneStar,generateNoneStar,generateNoneStar,generateNoneStar)
                break;
        }
    
        return generateStarInHtml.join(" ");
    }
}




