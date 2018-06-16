/// <reference path="F:\Final Project\ShareMarket_Game\ShareMarket_Game\Views/Home/Index.cshtml" />
/// <reference path="F:\Final Project\ShareMarket_Game\ShareMarket_Game\Views/Home/Index.cshtml" />
$(document).ready(function () {
    Game();
});

function Game() {
    $("#btnShareCancel").click(Gamepage);
    $("#btnShareCancel1").click(Gamepage);

};


function Gamepage() {
    location.replace("/Game/index");
}