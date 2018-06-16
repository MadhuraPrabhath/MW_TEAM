/// <reference path="F:\Final Project\ShareMarket_Game\ShareMarket_Game\Views/Home/Index.cshtml" />
/// <reference path="F:\Final Project\ShareMarket_Game\ShareMarket_Game\Views/Home/Index.cshtml" />
$(document).ready(function () {
    Game();
});

function Game() {
    $("#btnSelling").click(Sellingpage);
};


function Sellingpage() {
    location.replace("/Selling/index");
}