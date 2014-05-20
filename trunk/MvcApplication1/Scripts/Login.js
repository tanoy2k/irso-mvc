$(document).ready(function () { iniciar(); });
var iniciar = function(){
$("#login").on("click", function ()
{
    $.getJSON("./Login/Validate", function (data) {
        console.log(JSON.stringify(data));
        });
}); 
};



