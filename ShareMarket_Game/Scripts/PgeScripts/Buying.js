/// <reference path="F:\Final Project\ShareMarket_Game\ShareMarket_Game\Views/Home/Index.cshtml" />
/// <reference path="F:\Final Project\ShareMarket_Game\ShareMarket_Game\Views/Home/Index.cshtml" />
$(document).ready(function () {
    Buying();
});

function Buying() {
    $("#btnBuying").click(Buyingpage);
    $("#btnBuying1").click(Buyingpage);
    
};


function Buyingpage() {
    location.replace("/Buying/index");
}