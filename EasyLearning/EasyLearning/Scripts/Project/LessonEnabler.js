/**
*Enabler to lessons
*/
var lessonEnabler = function () {
    var scoreToEnable = 80;

    /*
    *Function to enable the lesson for default
    */
    var defaultLessons = function () {
        var lessonButtons = $('div.card-content button');
        for (index = 0; index <= lessonButtons.length; index++) {
            if (index === 0) {
                $(lessonButtons[index]).prop('disabled', false);
            } else {
                $(lessonButtons[index]).prop('disabled', true);
            }
        }
    }

    /*
    * function to enable the next lesson
    */
    var enableNextLesson = function (lessons) {
        var lessonButtons = $('div.card-content button');
        var finalPosition = lessons.length - 1;

        for (i = 0; i <= finalPosition; i++) {
            var currentLessonId = lessons[i].lessonId;
            var nextLessonButton = lessonButtons[i + 1];
            checkCurrentProgress(currentLessonId, nextLessonButton, function (currentProgressLesson, nextLessonButton) {
                if (currentProgressLesson >= scoreToEnable) {
                    $(nextLessonButton).prop('disabled', false);
                } else {
                    $(nextLessonButton).prop('disabled', true);
                }
            });
        }
    }

    /*
    *Returns the progress of a current lesson
    */
    var checkCurrentProgress = function (currentLessonId, nextLessonButton, callbackFunction) {
        var currentProgressLesson = 0;
        var lessonProgressUrl = "http://localhost:1893/Api/Enabler/" + currentLessonId;
        $.get(lessonProgressUrl, function (progress) {
            currentProgressLesson = progress;
            callbackFunction(currentProgressLesson, nextLessonButton);
        });
    }

    return {
        defaultLessons: defaultLessons,
        enableNextLesson: enableNextLesson
    };
}();