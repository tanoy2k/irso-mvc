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



