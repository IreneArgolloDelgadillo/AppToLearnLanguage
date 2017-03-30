/// <var>This function is to enable the buttons to save the language to learn</var>
var dropDownEnable = (function () {
    var userId = sessionStorage.getItem("userId");
    function showSelected() {

        document.getElementById("User").value = userId;
        
        var cod = document.getElementById("Languages").value;
        if (cod != '') {
            document.getElementById('CancelOption').style.display = 'block';
            document.getElementById('PutInput').innerHTML = '<input id="ChangeLanguage" type = "submit" value = "Cambiar" class = "btn waves-effect waves-light">';
        } else {
            document.getElementById('CancelOption').style.display = 'none';
            document.getElementById('PutInput').innerHTML = '';
        }
    }

    return {
        showSelected: showSelected,
        userId: userId
    };
})();