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

    var xhttp = new XMLHttpRequest();
    xhttp.open("GET", url, false);
    xhttp.send();

    valor = xhttp.responseText;

    console.log(valor);
    json = JSON.parse(JSON.parse(valor));
    console.log(json);
    
    //"{'nome':'Tavares', 'email':'Tavas@gmail.com', 'comentario':'Teste Web', 'assunto':'Teste Web'}"
}