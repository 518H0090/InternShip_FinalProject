const bannerSearchFormInput = document.querySelector('.banner-search__form-input');
const bannerSearchFormBtn = document.querySelector('.banner-search__form-btn');

bannerSearchFormBtn.addEventListener('click',(e) => {

  if (bannerSearchFormInput.value !== "") {

    let urlChange = './searchfood.html?keywords=' + encodeURIComponent(bannerSearchFormInput.value);

    window.location.href = urlChange;

  } else {
    e.preventDefault();
  }
  
})

window.addEventListener('load',(e) => {

    fetchMenuDeal();
    
    fetchMenuListRestaurant();
})


function fetchMenuDeal() {
    const bannerMenuDeallist = document.querySelector('.banner-menu__deallist')

    fetchAllRestaurants().then(data => {
        let listRestaurants = data.data
        var newList = fetchDataInLayout(listRestaurants)

        bannerMenuDeallist.innerHTML = newList
    }).catch(error => {
        console.log(error)
        bannerMenuDeallist.innerHTML = `<h1 style="margin: 20rem; color : red">Not Found Any Value Please Refresh Again</h1>`;
    })
    .catch(error => {
        console.log(error.message)
    })
    ;

    const fetchDataInLayout = function (listRestaurants) {

        let layoutGenerate = listRestaurants.map(element => {
    
            let isLikeReferences = element.rsRefeLike;
            let processTitle = element.rsTitle.length > 20 ? element.rsTitle.slice(0,20) + "..." : element.rsTitle;
            let processSubTitle = element.rsAddress.length > 25 ? element.rsAddress.slice(0,25) + "..." :
            element.rsAddress;
    
            if (isLikeReferences) {
                return ` <!-- List Item -->
                <div class="banner-menu__dealitem
                  banner-menu__dealitem--like">
                  <!-- Item Link -->
                  <a href="./detailfood.html?restitle=${element.rsTitle}"
                    class="banner-menu__dealitem-link">
                    <!-- Image -->
                    <div class="banner-menu__dealitem-image">
                      <img
                        src="${element.rsImageUrl}"
                        alt="" class="banner-menu__dealitem-img">
                    </div>
    
                    <!-- Content -->
                    <div class="banner-menu__dealitem-content">
                      <!-- Title -->
                      <h3 class="banner-menu__dealitem-title">${processTitle}</h3>
                      <!-- Subtitle -->
                      <p class="banner-menu__dealitem-subtitle">${processSubTitle}</p>
                    </div>
    
                    <!-- Promotion -->
                    <div class="banner-menu__promotion">
                      <i class="fa-solid fa-tag
                        banner-menu__promotion-icon"></i>
                      <span class="banner-menu__promotion-desc">${element.rsPromotion}</span>
                    </div>
    
                    <!-- OpenStatus  -->
                    <div class="banner-menu__openstatus">
                      <i class="fa-solid fa-circle"></i>
                    </div>
    
                    <!-- Tag Like -->
                    <div class="banner-menu__taglike">
                      <i class="fa-solid fa-thumbs-up
                        banner-menu__taglike-icon"></i>
                      <span class="banner-menu__taglike-content">Yêu thích</span>
                    </div>
                  </a>
                </div>`;
            }
    
            else {
                return ` <!-- List Item -->
                <div class="banner-menu__dealitem">
                  <!-- Item Link -->
                  <a href="./detailfood.html?restitle=${element.rsTitle}"
                    class="banner-menu__dealitem-link">
                    <!-- Image -->
                    <div class="banner-menu__dealitem-image">
                      <img
                        src="${element.rsImageUrl}"
                        alt="" class="banner-menu__dealitem-img">
                    </div>
    
                    <!-- Content -->
                    <div class="banner-menu__dealitem-content">
                      <!-- Title -->
                      <h3 class="banner-menu__dealitem-title">${processTitle}</h3>
                      <!-- Subtitle -->
                      <p class="banner-menu__dealitem-subtitle">${processSubTitle}</p>
                    </div>
    
                    <!-- Promotion -->
                    <div class="banner-menu__promotion">
                      <i class="fa-solid fa-tag
                        banner-menu__promotion-icon"></i>
                      <span class="banner-menu__promotion-desc">${element.rsPromotion}</span>
                    </div>
    
                    <!-- OpenStatus  -->
                    <div class="banner-menu__openstatus">
                      <i class="fa-solid fa-circle"></i>
                    </div>
    
                    <!-- Tag Like -->
                    <div class="banner-menu__taglike">
                      <i class="fa-solid fa-thumbs-up
                        banner-menu__taglike-icon"></i>
                      <span class="banner-menu__taglike-content">Yêu thích</span>
                    </div>
                  </a>
                </div>`
            }
        });
    
        return layoutGenerate.join(" ");
    }
}

function fetchMenuListRestaurant() {
    const bannerMenuListresFoodlist = document.querySelector('.banner-menu__listres-foodlist');

    fetchAllRestaurants().then(data => {
        const listValue = data.data

        var newList = listValue.map(element => {
            return `
            <!-- Food Item -->
                    <div class="banner-menu__listres-fooditem">
                      <!-- Food Item Link -->
                      <a href="#" class="banner-menu__listres-foodlink">
                        <!-- Image -->
                        <div class="banner-menu__fooditem-image">
                          <img
                            src="${element.rsImageUrl}"
                            alt="" class="banner-menu__fooditem-img">
                        </div>

                        <!-- Food Content -->
                        <div class="banner-menu__listres-content">
                          <!-- Title -->
                          <h3 class="banner-menu__listres-title">${element.rsTitle}</h3>

                          <!-- Location -->
                          <p class="banner-menu__listres-location">${element.rsAddress}</p>

                          <!-- Promotion -->
                          <div class="banner-menu__listres-promotion">
                            <i class="fa-solid fa-tag banner-menu__listres-promotion-icon"></i>

                            <span class="banner-menu__listres-promotion-text">${element.rsPrinceRange.split(" - ")[0]}</span>

                            <i class="fa-solid fa-money-bill banner-menu__listres-promotion-icon"></i>

                            <span class="banner-menu__listres-promotion-text">${element.rsPrinceRange.split(" - ")[1]}</span>
                          </div>

                          <!-- Type -->
                          <p class="banner-menu__listres-type">${element.rsType}</p>

                        </div>
                      </a>
                    </div>
            `
        }).join(" ");

        bannerMenuListresFoodlist.innerHTML = newList  
    }).catch(error => {
      console.error(error.message)
      bannerMenuListresFoodlist.innerHTML = `<h1 style="margin: 20rem; color : red">Not Found Any Value Please Refresh Again</h1>`
    })
}


    


