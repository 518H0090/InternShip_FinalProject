const layoutFormInputUser = document.querySelector('.layout-form__input-user');
const layoutFormInputPwd = document.querySelector('.layout-form__input-pwd');
const btnLoginInSystem = document.querySelector(`button[type='submit'].btn-login`)
const layoutFormShowprocess = document.querySelector('.layout-form__showprocess')


btnLoginInSystem.addEventListener('click',(e) => {
    e.preventDefault();

    let userGet = layoutFormInputUser.value;
    let passwordGet = layoutFormInputPwd.value;

    if (userGet === "" || passwordGet === "") {
        layoutFormShowprocess.innerHTML = 
        `<p class="layout-form__showprocess">
            Không được để trổng bất kì thông tin nào 
        </p>`;

        layoutFormShowprocess.style.display = "block";
        window.FlashMessage.warning(' Không được để trổng bất kì thông tin nào  !');
    } 

    else {
        AuthenAccount(userGet,passwordGet)
        .then(data => {
            layoutFormShowprocess.innerHTML = 
            `<p class="layout-form__showprocess">
                Đăng nhập thành công
            </p>`;

            window.FlashMessage.success(' Đăng nhập thành công !');

        layoutFormShowprocess.style.display = "block";
        layoutFormShowprocess.style.color = "green";


        localStorage.setItem("jwttoken",data.data);

        window.location.href = "./index.html";

        })
        .catch(error => {
            layoutFormShowprocess.innerHTML = 
            `<p class="layout-form__showprocess">
                ${error}
            </p>`;

        layoutFormShowprocess.style.display = "block";
        })
    }
    
})