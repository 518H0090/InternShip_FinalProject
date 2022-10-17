const layoutFormProcess = document.querySelector('.layout-form__process');

const layoutFormInputUser = document.querySelector('.layout-form__input-user');
const layoutFormInputPwd = document.querySelector('.layout-form__input:nth-child(2) .layout-form__input-pwd');
const layoutFormInputRepwd = document.querySelector('.layout-form__input:nth-child(3) .layout-form__input-pwd');
const buttonFormRegisterSubmit = document.querySelector('button[type="submit"].btn-login-connect');

buttonFormRegisterSubmit.addEventListener('click',(e) => {
    e.preventDefault();

    ProcessForm(layoutFormInputUser.value, layoutFormInputPwd.value, layoutFormInputRepwd.value);

})

function ProcessForm(userName, password, rePassword) {
    const titleEmpty = "Don't Miss Any Value In this Form";
    const notMatchPassword = `Doesn't match password`;

    if(userName === "" || password === "" || rePassword === "") {
        layoutFormProcess.innerHTML = ` <!-- Form Error Show -->
        <p class="layout-form__process">
           ${titleEmpty}
       </p>`;

       layoutFormProcess.style.display = "block";
    } 

    else if (password !== rePassword) {
        layoutFormProcess.innerHTML = ` <!-- Form Error Show -->
        <p class="layout-form__process">
           ${notMatchPassword}
       </p>`;

       layoutFormProcess.style.display = "block";
    }
   
    else {
        ProcessApiRegister(layoutFormInputUser.value, layoutFormInputPwd.value,layoutFormInputRepwd.value)
    }
}


function ProcessApiRegister(userName, password, rePassword) {
        
       RegisterAccount(userName, password,rePassword)
       .then(data => {
        layoutFormProcess.innerHTML = ` <!-- Form Error Show -->
        <p class="layout-form__process">
           Register Success Account <br> ${data.userName}
       </p>`;

         layoutFormProcess.style.display = "block";
       }).catch(error => {
        layoutFormProcess.innerHTML = ` <!-- Form Error Show -->
        <p class="layout-form__process">
           ${error.message}
       </p>`;

       layoutFormProcess.style.display = "block";
       })
}