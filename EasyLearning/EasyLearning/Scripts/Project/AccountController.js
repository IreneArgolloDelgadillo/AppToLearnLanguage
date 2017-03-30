/**
 * It represents the account controller for login
 * @class
 */
var account = (function () {

    var tokenKey = 'accessToken';
    var userId = 'userId';
    var errors = [];

    var userEmail = 'userEmail';
    var userLearnLanguage = 'userLearnLanguage';

    function showError(jqXHR) {
        var result = jqXHR.statusText;
        var response = jqXHR.responseJSON;
        var error = response.error_description;
        jQuery("label[for='loginError']").html(error);
    }

    /*
   * Function to Login with email and password
   *@function
   */
    function login() {
        var loginEmail = document.getElementById('Email').value;
        var loginPassword = document.getElementById('Password').value;

        var loginData = {
            grant_type: 'password',
            username: loginEmail,
            password: loginPassword
        };

        $.ajax({
            type: 'POST',
            url: 'http://localhost:1893/Token',
            crossDomain: true,
            headers: {
                'Access-Control-Allow-Origin': '*',
            },
            contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
            data: loginData,
            success: function (data) {
                sessionStorage.setItem(tokenKey, data.access_token);
                getUserID();
            }

        }).fail(showError);
    }

    function getUserID() {
        $.ajax({
            type: 'GET',
            url: 'http://localhost:1893/api/Account/UserInfo',
            crossDomain: true,
            headers: {
                'Access-Control-Allow-Origin': '*',
                'Authorization': 'bearer ' + sessionStorage.getItem('accessToken'),
            },
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            success: function (data) {
                sessionStorage.setItem(userId, data.userID);
                sessionStorage.setItem(userEmail, data.email);
                sessionStorage.setItem(userLearnLanguage, data.learnLanguage);
                var urlHome = $("#RedirectTo").val();
                location.href = urlHome;
            }
        });
    }

    function logout() {
        // Log out from the cookie based logon.
        $.ajax({
            type: 'POST',
            url: 'http://localhost:1893/api/Account/Logout',
            crossDomain: true,
            headers: {
                'Access-Control-Allow-Origin': '*',
                'Authorization': 'bearer ' + sessionStorage.getItem('accessToken'),
            },
            success: function (data) {
                sessionStorage.clear();
                var urlLogin = $("#RedirectTo").val();
                location.href = urlLogin;
            }
        });
    }

    return {
        login: login,
        logout: logout,
    }
})();

