$(document).ready(function () 
{
    consultar(document.getElementById("assunto").value)
});

function postar(a){
    var Nome = document.querySelector("#recipient-name");

    var Email = document.querySelector("#recipient-email");

    var Comentario = document.querySelector("#message-text");

    var url = `https://localhost:44333/api/Comentario?Nome=${Nome.value}&Email=${Email.value}&Comentario=${Comentario.value}&Assunto=${a}`;

    var xhttp = new XMLHttpRequest();
    xhttp.open("POST", url, false);
    xhttp.send();

    console.log(xhttp.responseText);

    consultar(document.getElementById("assunto").value)
}

function consultar(a){
    var url = `https://localhost:44333/api/Comentario?Assunto=${a}`;

    $.get(url,data =>{
        dados = JSON.parse(data)
        var div = '';

        $(dados).each(function (index) {
            
            div += `<div class="d-flex">
                <div class="flex-shrink-0"><img class="rounded-circle" src="./img/perfil.jpg" weight="50px" height="50px" alt="..." /></div>
                <div class="ms-3">
                    <div class="fw-bold">${dados[index].nome}</div>
                        &nbsp;&nbsp${dados[index].comentario}<br>
                    <a href="mailto:${dados[index].email}" class="small">Responder</a>
                </div>
            </div><br>`
        });

        document.getElementById("comentario").innerHTML =div;
    })
    //json = JSON.parse(JSON.parse(valor));
    //console.log(json);
 
    

    //"{'nome':'Tavares', 'email':'Tavas@gmail.com', 'comentario':'Teste Web', 'assunto':'Teste Web'}"t
}

