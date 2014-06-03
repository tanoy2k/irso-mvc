$(document).ready(function () { iniciar(); });
var iniciar = function(){
$("#login").on("click", function ()
{
    $.getJSON("./Login/Validate", function (data) {
        console.log(JSON.stringify(data));
        });
});
$("#login2").on("click", function () {
    var miUsuario = $("#Usuario").val();
    var miPassword = $("#Password").val();
    
    var queryString = window.document.location.href+"Login/ValidarLogin?usuario=" + miUsuario +"&password=" + miPassword;
    window.location = queryString;


});

$(".need-help").on("click",function () {
    alert("LLamar al 0800-IRSO");
});

$(".new-account").on("click", function () {
    alert("Funcionalidad en Desarrollo");
});

};



