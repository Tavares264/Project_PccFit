$(document).ready(function () 
{
    consultar('calcio')
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
}

function consultar(a){
    var url = `https://localhost:44333/api/Comentario?Assunto=${a}`;

    $.get(url,data =>{
        dados = JSON.parse(data)
        var div = '';

        $(dados).each(function (index) {
            
            div += `<div class="d-flex">
                <div class="flex-shrink-0"><img class="rounded-circle" src="https://dummyimage.com/50x50/ced4da/6c757d.jpg" alt="..." /></div>
                <div class="ms-3">
                    <div class="fw-bold">${dados[index].nome}</div>
                    ${dados[index].comentario}
                </div>
            </div><br>`
        });

        document.getElementById("comentario").innerHTML =div;
    })
    
    //json = JSON.parse(JSON.parse(valor));
    //console.log(json);
 
    

    //"{'nome':'Tavares', 'email':'Tavas@gmail.com', 'comentario':'Teste Web', 'assunto':'Teste Web'}"
}

