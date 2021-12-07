

function pegar(){
    var url = "https://localhost:44333/api/Login";//Sua URL

    var xhttp = new XMLHttpRequest();
    xhttp.open("GET", url, false);
    xhttp.send();//A execução do script pára aqui até a requisição retornar do servidor

    console.log(xhttp.responseText);
}

function postar(){
    var input_cpf = document.querySelector("#cpf");
    var CPF =input_cpf.value;

    var input_senha = document.querySelector("#senha");
    var Senha =input_senha.value;

    var url = "https://localhost:44333/api/Login?CPF='" + CPF + "'&Senha='" + Senha + "'";

    var xhttp = new XMLHttpRequest();
    xhttp.open("POST", url, false);
    xhttp.send();

    console.log(xhttp.responseText);
}


function Verificar(){
    var input_cpf = document.querySelector("#cpf");
    var CPF = input_cpf.value;

    var input_senha = document.querySelector("#senha");
    var Senha = input_senha.value;

    var url = "https://localhost:44333/api/Login?CPF='" + CPF + "'&Senha='" + Senha + "'";

    var xhttp = new XMLHttpRequest();
    xhttp.open("POST", url, false);
    xhttp.send();

    valor = xhttp.responseText;

    console.log(valor);
    json = JSON.parse(JSON.parse(valor));
    console.log(json);

    if (json['acesso'] == 'VAZIO'){
        document.getElementsById("status").values = "Sem Acesso";
    } 
    else if (json['acesso'] == 'INVALIDO'){
        document.getElementById("status").innerHTML = "CPF ou Senha Invalido";    
    }
    else if (json['acesso'] == 'RUIM'){
        document.getElementsById("status").values = "Digite o Cpf e a Senha";    
    }
    else{
        window.location.replace("blog.html")
    }
}