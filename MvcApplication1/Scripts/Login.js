$(document).ready(function () { iniciar(); });
var iniciar = function(){
$("#login").on("click", function ()
{
    $.getJSON("./Login/Validate", function (data) {
        console.log(JSON.stringify(data));
        });
});
    // si llega un redirect, el amigo getjson no sabe manejarlo, por eso modificamos la rutina ajax...
    // a vos, amigo ;)
$('body').ajaxComplete(function (e, xhr, settings) {
    if (xhr.status == 200) {
        var redirect = null;
        try {
            redirect = $.parseJSON(xhr.responseText).redirect;
            if (redirect) {
                alert("Su sesión ha caducado. Debe volver a indentificarse.");
                window.location.href = redirect.replace(/\?.*$/, "?next=" + window.location.pathname);
            }
        } catch (e) {
            return;
        }
    }
});
$("#login2").on("click", function () {
    var miUsuario = $("#Usuario").val();
    var miPassword = $("#Password").val();
    
    var queryString = "./Login/ValidarLogin?usuario=" + miUsuario +"&password=" + miPassword;
    $.getJSON(queryString, function (data) {
        console.log(JSON.stringify(data));
        if (data.ok == "OK") {
            window.location.href = "./Home";
        } else {
            alert(data.msg);
        }
        
    })
});

$(".need-help").on("click",function () {
    alert("LLamar al 0800-IRSO");
});

$(".new-account").on("click", function () {
    alert("Funcionalidad en Desarrollo");
});

};



