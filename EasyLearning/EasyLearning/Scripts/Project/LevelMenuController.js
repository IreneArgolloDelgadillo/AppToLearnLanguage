/**
 * It represents the main class for menu levels
 * @class
 */
(function () {
    var userId = sessionStorage.getItem('userId');

    $(document).ready(function () {
        $(".button-collapse").sideNav();
    })

    $.ajax({
        type: 'GET',
        url: 'http://localhost:1893/api/Levels',
        data: { user: userId },
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        success: function (levels) {
            passToView(levels);
        }
    });

    /*
    *Function for pass data to view
    */
    function passToView(levels) {
        $.each(levels, function (index) {
            $("#levels").append('<li> <a onclick=\'lessons.getLessons(' + levels[index].levelId + ')\'>' + levels[index].title + '</a></li>');
        });
        $.each(levels, function (index) {
            $("#levelsMobile").append('<li> <a onclick=\'lessons.getLessons(' + levels[index].levelId + ')\'>' + levels[index].title + '</a></li>');
        });
    }
})();