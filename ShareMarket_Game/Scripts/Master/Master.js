$(document).ready(function () {
    refreshNavLinks();
});


function postServerData(url, data, success, error) {
    $.ajax({
        url: url,
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(data),
        success: function (data) {
            success(data);
        },
        error: function (response, textStatus, errorThrown) {
            error(response, textStatus, errorThrown);
        }
    });
}

 function refreshNavLinks () {
    $('a[href="' + window.location.pathname + '"]').parent("li").addClass("active")
        .parent("ul").css("display", "block")
        .parent(".treeview").addClass("active ");
};