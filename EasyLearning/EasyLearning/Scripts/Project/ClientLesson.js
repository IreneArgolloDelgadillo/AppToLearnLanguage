/**
* Funtion to get the lesson to show in the view
*/
function getLessonView(lesson) {
    $.ajax({
        type: "POST",
        url: '/Lesson/Index/',
        data: JSON.stringify(lesson),
        error: function () {
            alert("An error occurred.");
        },
        success: function (data) {
            $("#exercisesAndTips").hide();
            $("#viewContainer").html(data);
        }
    });
}