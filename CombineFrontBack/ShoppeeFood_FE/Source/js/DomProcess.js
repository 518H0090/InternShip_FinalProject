// DropDown Location Toggle

const navbarDropDownToggle = document.querySelector(
  ".navbar .navbar-dropdown__toggle"
);
const navbarDropDownMenu = document.querySelector(".navbar-dropdown__menu");

navbarDropDownToggle.addEventListener("click", (e) => {
  navbarDropDownMenu.classList.toggle("show");
});

// Show Navbar Search Modal
const navbarSearchBtn = document.querySelector(".navbar-search__btn");
const modalNavbarSearch = document.querySelector(".modal-navbarsearch");

navbarSearchBtn.addEventListener("click", (e) => {
  modalNavbarSearch.classList.add("showModals");
});

// Close Navbar Search Modal
const modalNavBarSearchOverlay = document.querySelector(
  ".modal-navbarsearch__overlay"
);

modalNavBarSearchOverlay.addEventListener("click", (e) => {
  modalNavbarSearch.classList.remove("showModals");
});

const modalNavbarSearchCloseIcon = document.querySelector(
  ".modal-navbarsearch__close-icon"
);

modalNavbarSearchCloseIcon.addEventListener("click", (e) => {
  modalNavbarSearch.classList.remove("showModals");
});

// Add Switch Language
const dropdownSwitchToggle = document.querySelector(".dropdown-switch__toggle");
const dropdownSwitchMenu = document.querySelector(".dropdown-switch__menu ");

dropdownSwitchToggle.addEventListener("click", (e) => {
  dropdownSwitchMenu.classList.toggle("showSwitch");
});

// Move To Login Page
const navbarLogin = document.querySelector(".navbar-login button[type='button']");

navbarLogin.addEventListener("click", (e) => {
  window.location.href = "./login.html";
});

// Move To Index Page
const navbarLogo = document.querySelector(".navbar-logo");

navbarLogo.addEventListener("click", (e) => {
  window.location.href = "./index.html";
});

// Move To Search 
const modalNavbarSearchSearchInput = document.querySelector('.modal-navbarsearch__search-input');


modalNavbarSearchSearchInput.addEventListener('keyup', function(event) {

  try {
      if (event.keyCode == 13 || e.key === 'Enter') {
          let keywords = event.target.value;

          if (keywords === "") {
            throw new Error('Must Type Keywords');

            event.preventDefault();
          } 
          
          else {
            let urlChange = './searchfood.html?keywords=' + encodeURIComponent(keywords);

            window.location.href = urlChange;
          }
      }
      false;
  } catch (e) { 
    console.log(`Can't Process`)
  };
  return true
})


// modalNavbarSearchSearchInput.addEventListener('click',(e) => {

//   if (bannerSearchFormInput.value !== "") {

//     let urlChange = './searchfood.html?keywords=' + encodeURIComponent(bannerSearchFormInput.value);

//     window.location.href = urlChange;

//   } else {
//     e.preventDefault();
//   }
  
// })
