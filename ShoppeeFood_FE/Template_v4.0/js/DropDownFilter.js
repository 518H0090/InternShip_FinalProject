// Show DropDown Location And Category In Search Food Detail
const searchFilterFirstItem = document.querySelector('.searchfilter__item:nth-child(1)');
const searchFilterFirstToggle = document.querySelector('.searchfilter__item:nth-child(1) .searchfilter__toggle');
const searchFilterFirstBoxlist = document.querySelector('.searchfilter__item:nth-child(1) .searchfilter__boxlist'); 

const searchFilterSecondItem = document.querySelector('.searchfilter__item:nth-child(2)');
const searchFilterSecondToggle = document.querySelector('.searchfilter__item:nth-child(2) .searchfilter__toggle');
const searchFilterSecondBoxlist = document.querySelector('.searchfilter__item:nth-child(2) .searchfilter__boxlist'); 

searchFilterFirstItem.firstElementChild.addEventListener('click', (e) => {
    searchFilterFirstToggle.classList.toggle('show')
    searchFilterSecondToggle.classList.remove('show')
    searchFilterSecondToggle.classList.remove('active')
    if (searchFilterFirstToggle.classList.contains('active')) {
        searchFilterFirstToggle.classList.remove('active')
    } else {
        searchFilterFirstToggle.classList.add('active')
    }
});

searchFilterFirstBoxlist.addEventListener('click',(e) => {
    searchFilterFirstToggle.classList.toggle('show')
    searchFilterSecondToggle.classList.remove('show')
    searchFilterSecondToggle.classList.remove('active')
    if (searchFilterFirstToggle.classList.contains('active')) {
        searchFilterFirstToggle.classList.remove('active')
    } else {
        searchFilterFirstToggle.classList.add('active')
    }
})

searchFilterSecondItem.firstElementChild.addEventListener('click', (e) => {
    searchFilterSecondToggle.classList.toggle('show')
    searchFilterFirstToggle.classList.remove('show')
    searchFilterFirstToggle.classList.remove('active')
    if (searchFilterSecondToggle.classList.contains('active')) {
        searchFilterSecondToggle.classList.remove('active')
    } else {
        searchFilterSecondToggle.classList.add('active')
    }
});

searchFilterSecondBoxlist.addEventListener('click',(e) => {
    searchFilterSecondToggle.classList.toggle('show')
    searchFilterFirstToggle.classList.remove('show')
    searchFilterFirstToggle.classList.remove('active')
    if (searchFilterSecondToggle.classList.contains('active')) {
        searchFilterSecondToggle.classList.remove('active')
    } else {
        searchFilterSecondToggle.classList.add('active')
    }
})