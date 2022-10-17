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
            Don't Miss Any Value
        </p>`;

        layoutFormShowprocess.style.display = "block";

    } 

    else {
        RegisterAccount(userGet,passwordGet)
        .then(data => {
            layoutFormShowprocess.innerHTML = 
            `<p class="layout-form__showprocess">
                Login Successful
            </p>`;

        layoutFormShowprocess.style.display = "block";

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