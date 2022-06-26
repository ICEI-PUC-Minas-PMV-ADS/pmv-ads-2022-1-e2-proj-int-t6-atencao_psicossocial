// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// máscara para cpf

function maskCpf(mask, input) {
    const cpf = document.getElementById('cpf')
    if (cpf.value.length == 3 || cpf.value.length == 7) {
        cpf.value += "."
    } else if (cpf.value.length == 11) {
        cpf.value += "-"
    }
}
//máscara para cep

function maskcep(mask, input) {
    const cep = document.getElementById('cep')
    if (cep.value.length == 5) { cep.value+= '-' }
}

//máscara telefone

function masktel(mask, input){
    const tel = document.getElementById("tel")
    if (tel.value.length == 0) { tel.value += '(' }
    else if (tel.value.length == 3) { tel.value += ')' }

    else if (tel.value.length == 9) {
        tel.value += "-"
    }
    }


// Força da senha
function ForcaSenha() {
    var numeros = /([0-9])/;
    var alfabeto = /([a-zA-Z])/;
    var chEspeciais = /([~,!,@,#,$,%,^,&,*,-,_,+,=,?,>,<])/;

    if ($('#password').val().length < 6) {
        $('#password-status').html("<span style='color:red'>Senha fraca</span>");
    } else {
        if ($('#password').val().match(numeros) && $('#password').val().match(alfabeto) && $('#password').val().match(chEspeciais)) {
            $('#password-status').html("<span style='color:green'><b>Senha Forte</b></span>");
        } else {
            $('#password-status').html("<span style='color:orange'>Médio, insira um caracter especial</span>");
        }
    }
}


// spinner funcionamento



var i = setInterval(function () {

    clearInterval(i);

    // O código 
    document.getElementById("loading").style.display = "none";

}, 2000);

//Validação troca de senha

    var password = document.getElementById("password")
        , confirm_password = document.getElementById("confirm_password");

    function validatePassword() {
        if (password.value != confirm_password.value) {
            confirm_password.setCustomValidity("Senhas diferentes!");
        } else {
            confirm_password.setCustomValidity('');
        }
    }

    password.onchange = validatePassword;
    confirm_password.onkeyup = validatePassword;




