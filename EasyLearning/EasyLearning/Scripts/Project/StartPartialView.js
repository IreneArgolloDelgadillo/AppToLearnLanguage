$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: '/PartialViewBuilder/GetPartialView/',
        error: function () {
            alert("An error occurred.");
        },
        success: function (data) {
            $("#exercises").html(data);
        }
    });
});
