var cpf;

window.onload = function() {
    Cpf = sessionStorage.getItem('cpf');
    if(sessionStorage.getItem('acesso') == 'atendente'){
        consultarNutricionistaN(Cpf);
        consultarTarefasN(Cpf);
    }
    if(sessionStorage.getItem('acesso') == 'nutricionista'){
        consultarNutricionistaN(Cpf);
        consultarTarefasN(Cpf);
    }
    if(sessionStorage.getItem('acesso') == 'paciente'){
        consultarNutricionistaP(Cpf);
        consultarTarefasP(Cpf);
    }
}

function pegar(){
    var url = "https://localhost:44333/api/Login";

    var xhttp = new XMLHttpRequest();
    xhttp.open("GET", url, false);
    xhttp.send();

    console.log(xhttp.responseText);
}

function postar(){
    var input_cpf = document.querySelector("#cpf");
    var CPF =input_cpf.value;

    var input_senha = document.querySelector("#senha");
    var Senha =input_senha.value;

    var url = "https://localhost:44333/api/Login?CPF=" + CPF + "&Senha=" + Senha + "";

    var xhttp = new XMLHttpRequest();
    xhttp.open("POST", url, false);
    xhttp.send();

    console.log(xhttp.responseText);
}


function Verificar(){
    var input_cpf = document.querySelector("#cpf").value;
    console.log(input_cpf);
    cpf = input_cpf;

    var input_senha = document.querySelector("#senha").value;
    console.log(input_senha);

    var url = "https://localhost:44333/api/Login?CPF=" + input_cpf + "&Senha=" + input_senha;

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
        window.location.replace("Index.html")
        sessionStorage.setItem('cpf', cpf);
        sessionStorage.setItem('acesso', json['acesso']);
    }
}

//Tasks

function consultarNutricionistaN(NCpf){
    console.log(NCpf);
    var url = `https://localhost:44333/api/Agenda?NCpf=`+NCpf;
    console.log(url)

    $.get(url,data =>{
        dados = JSON.parse(data)
        console.log(data);
        var div = '';

        $(dados).each(function (index) {
            div += `<li class="events__item">
            <div class="events__item--left">
              <span class="events__name">Atendimento ${dados[index].paciente}</span>
              <span class="events__date">${(dados[index].dt_agenda).slice(0,10)}</span>
            </div>
            <span class="events__tag">${dados[index].horario}</span>
          </li>`
        });
        document.getElementById("eventos").innerHTML =div;
    })
}

function consultarNutricionistaP(PCpf){
    console.log(PCpf);
    var url = `https://localhost:44333/api/Agenda?PCpf=`+PCpf;
    console.log(url)

    $.get(url,data =>{
        dados = JSON.parse(data)
        console.log(data);
        var div = '';

        $(dados).each(function (index) {
            div += `<li class="events__item">
            <div class="events__item--left">
              <span class="events__name">Consulta Dr. ${dados[index].nutricionista}</span>
              <span class="events__date">${(dados[index].dt_agenda).slice(0,10)}</span>
            </div>
            <span class="events__tag">${dados[index].horario}</span>
          </li>`
        });
        document.getElementById("eventos").innerHTML =div;
    })
}

function consultarTarefasN(NCpf){
    console.log(NCpf);
    var url = `https://localhost:44333/api/Rotina?NCpf=`+NCpf;
    console.log(url);
    var nome = "";

    $.get(url,data =>{
        dados = JSON.parse(data)
        console.log(data);
        var div = '';

        $(dados).each(function (index) {
            if(nome != `${dados[index].paciente}`){
                div += `<h6>${dados[index].paciente}</h6>`
            }
            div += `<div class="d-flex align-items-center"><label><input type="checkbox" class="option-input radio"><span class="label-text">${dados[index].item}</span></label></div>`
            nome = `${dados[index].paciente}`
        });
        document.getElementById("tasks").innerHTML =div;
    })
}

function consultarTarefasP(PCpf){
    console.log(PCpf);
    var url = `https://localhost:44333/api/Rotina?PCpf=`+PCpf;
    console.log(url)

    $.get(url,data =>{
        dados = JSON.parse(data)
        console.log(data);
        var div = '';
        $(dados).each(function (index) {
            item = dados[index].item;
            if (dados[index].feito == "True"){
                div += `<div class="d-flex align-items-center"><label><input type="checkbox" checked onclick="updateItem('${PCpf}','${item}')" class="option-input radio"><span class="label-text">${item}</span></label></div>`;
            }
            else{
                div += `<div class="d-flex align-items-center"><label><input type="checkbox" onclick="updateItem('${PCpf}','${item}')" class="option-input radio"><span class="label-text">${item}</span></label></div>`;
            }
        });
        document.getElementById("tasks").innerHTML =div;
    })
}

function updateItem(PCpf, item){
    console.log(PCpf);
    console.log(item);
    var url = `https://localhost:44333/api/Rotina?pcpf=`+PCpf+`&item=`+item;
    console.log(url)
    $.post(url,data =>{
        dados = JSON.parse(data)
        console.log(data);
    })
}