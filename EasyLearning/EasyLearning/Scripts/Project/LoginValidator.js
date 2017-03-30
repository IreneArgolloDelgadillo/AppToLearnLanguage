/**
 * It represents the login validator
 */
$(document).ready(function () {

    $("#loginButton").prop("disabled", true);
    $("#loginButton").css("background", "grey");

    ///Show and hide error message for email.
    $("#Email").on("blur", function () {
        if ($(this).val().trim().length == 0) {
            $("#emailError").show();
        }
        else {
            $("#emailError").hide();
        }
    });

    ///Show and hide password message for email.
    $("#Password").on("blur", function () {
        if ($(this).val().trim().length == 0) {
            $("#passwordError").show();
        }
        else {
            $("#passwordError").hide();
        }
    });

    ///Disable the login button as default.
    $('html').bind('input', function () {
        $("#loginButton").prop("disabled", false);
        $("#loginButton").css("background", "#009688");
    });

    ///Validate when password and email are not null.
    $('html').bind('input', function () {
        var password = $("#Password").val();
        var email = $("#Password").val();
        if (password.length >= 6 && email.length != 0) {
            $("#loginButton").prop("disabled", false);
            $("#loginButton").css("background", "#009688");
        }
        else {
            $("#loginButton").prop("disabled", true);
            $("#loginButton").css("background", "grey");
        }
    });
});