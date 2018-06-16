/// <reference path="F:\Final Project\ShareMarket_Game\ShareMarket_Game\Views/Home/Index.cshtml" />
/// <reference path="F:\Final Project\ShareMarket_Game\ShareMarket_Game\Views/Home/Index.cshtml" />
$(document).ready(function () {
    login();
});

function login() {
    $("#btnLogin").click(loginpage);
};


function loginpage() {
    location.replace("/Home/index");
}