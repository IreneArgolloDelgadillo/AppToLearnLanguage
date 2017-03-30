(function () {
    var userId = sessionStorage.getItem('userId');

    var link = '<a class="waves-effect waves-light  white-text" href = "/UserLanguages/Index?userId=' + userId + '">' +
                    '<i class="material-icons left">settings</i>Configuraciones</a>';

    document.getElementById("configurationLink").innerHTML = link;
    document.getElementById("configurationLinkMovil").innerHTML = link;

})();