/**
* Function to show the view of lessons
*/
var lessons = (function () {

    /**
    *Function to get data lesson
    */
    var getLessons = function (lessonId) {
        ClientExerciseAndTip.resetVariables();
        $.ajax({
            type: "GET",
            url: "http://localhost:1893/Api/Lessons",
            data: { levelId: lessonId },
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (lessons) {
                if (lessons != null) {
                    callLessonsView(lessons);
                    putLessonProgress.getLessonProgress(lessonId, sessionStorage.getItem('userId'));
                    setProgress.showLessonProgress(lessonId);
                    lessonEnabler.enableNextLesson(lessons);
                }
            }
        });
    }

    /**
    *Function to get a view of Lessons
    */
    var callLessonsView = function (lessons) {
        $("#lessons").empty();
        $("#exercises").empty();
        var index;
        for (index = 0; index < lessons.length; index++) {
            $("#lessons").append(
                '<li class="collection-item dismissable"><div><div class ="progress" id="progressLesson'
                + lessons[index].lessonId + '" style="height:20px"><div class="determinate" id="progressBarLesson'
                + lessons[index].lessonId + '" ><label class="center-align" style="color:#000000" id="textProgress'
                + lessons[index].lessonId + '"></label></div></div>'
                + '<div>' + '<button onclick=ClientExerciseAndTip.nextPartialView('
                + lessons[index].lessonId + ',' + lessons[index].levelId + ') class="secondary-content">'
                + lessons[index].title + ' </button></div></li><hr>');
        }
        lessonEnabler.defaultLessons();
        $("#bodyContainer").hide();
        $("#exercisesAndTips").hide();
        $("#lessonByLevel").show();

    }

    return {
        getLessons: getLessons
    };
})();