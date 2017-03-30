/**
*Function to set the percentage of progress bar
*/
var percentajeExercisesProgressBar = function () {
    var currentLessonId;
    var totalExercises;
    var solvedExercisesCount = 0;

    /**
    *Function to change the percentage of progress bar
    */
    var setPercentageToProgressBar = function (totalExercises) {
        var percentage = 100;
        var total = (solvedExercisesCount * percentage) / totalExercises;
        $("#progressBar").width(total.toString() + "%");
        $('#progressHidden').show();
    }

    /**
    * Function to get number of exercises in the lesson
    */
    var getTotalOfExercises = function (lessonId) {
        if (lessonId > 0) {
            currentLessonId = lessonId
            $.ajax({
                type: "GET",
                url: "http://localhost:1893/Api/LessonContent",
                data: {
                    lessonId: currentLessonId
                },
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (currentTotalExercises) {
                    totalExercises = currentTotalExercises;
                    setPercentageToProgressBar(currentTotalExercises);
                }
            });
        } else {
            setPercentageToProgressBar(totalExercises);
        }
    }

    /**
    * Function to add the count of exercises
    */
    var addExerciseResolved = function () {
        solvedExercisesCount = solvedExercisesCount + 1;
    }

    /**
    *Function to reset count of exercises
    */
    var resetExercisesCount = function () {
        solvedExercisesCount = 0;
        $("#progressBar").width(solvedExercisesCount+ "%");
    }

    return {
        getTotalOfExercises: getTotalOfExercises,
        addExerciseResolved: addExerciseResolved,
        resetExercisesCount: resetExercisesCount

    }
}();
