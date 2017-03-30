/// <var>The set progress</var>
var setProgress = (function () {
    var amountOfLessonExercises = 0;
    var totalScore = 0;
    var amountOfTimesYouRepeatTheLesson = 0;

    /// <summary>
    /// s this instance.
    /// </summary>
    /// <returns> the total score</returns>
    var getProgress = function (data) {

        return totalScore = totalScore + data.puntuation;

    };

    /// <summary>
    /// s this instance.
    /// </summary>
    /// <returns> the amount of exercises</returns>
    var getAmountOfExercises = function () {
        return amountOfLessonExercises = amountOfLessonExercises + 1;
    };

    /// <summary>
    /// s this instance.
    /// </summary>
    /// <returns> the lesson progress</returns>
    var showLessonProgress = function (lessonId) {
        var percentage = 100;
        var progress = (totalScore * percentage) / amountOfLessonExercises;
        if (isNaN(progress)) {
            showTextProgress(progress, lessonId);
            updateValue();
        } else {
            setProgressForScore(progress, lessonId);
            $('#progressLesson' + lessonId).show();
            var lessonProgress = {
                "Percentage": progress,
                "ExerciseSolvedQuantity": totalScore,
                "TotalExerciseQuantity": amountOfLessonExercises,
                "LessonId": lessonId,
                "UserId": sessionStorage.getItem('userId')
            };
            putLessonProgress.getLessonProgress(lessonId, sessionStorage.getItem('userId'));
            if (sessionStorage.getItem('hasProgress') == 1) {
                amountOfTimesYouRepeatTheLesson = amountOfTimesYouRepeatTheLesson + 1;
                verifyIfCreateOrUpdateTheLessonProgress(amountOfTimesYouRepeatTheLesson, lessonProgress);
                updateValue();
            } else {
                verifyIfCreateOrUpdateTheLessonProgress(amountOfTimesYouRepeatTheLesson, lessonProgress);
                updateValue();
                amountOfTimesYouRepeatTheLesson = amountOfTimesYouRepeatTheLesson + 1;
            }

        }
    };

    /// <summary>
    /// s this instance.
    /// </summary>
    /// <returns> the lesson progress</returns>
    var verifyIfCreateOrUpdateTheLessonProgress = function (amountOfTimesYouRepeatTheLesson, lessonProgress) {
        if (amountOfTimesYouRepeatTheLesson > 0 && lessonProgress != null) {
            putLessonProgress.updateLessonProgress(lessonProgress, amountOfTimesYouRepeatTheLesson);
        } else {
            if (lessonProgress != null) {
                putLessonProgress.createLessonProgress(lessonProgress);
            }

        }
    };

    /// <summary>
    /// s this instance.
    /// </summary>
    /// <returns> the set the color progress by score</returns>
    var setProgressForScore = function (progress, lessonId) {
        if (progress >= 0 && progress <= 50) {
            $('#progressBarLesson' + lessonId).width(progress.toString() + "%");
            $('#progressBarLesson' + lessonId).addClass("red");
            showTextProgress(progress, lessonId);
        } else {
            if (progress > 50 && progress <= 70) {
                $('#progressBarLesson' + lessonId).width(progress.toString() + "%");
                $('#progressBarLesson' + lessonId).addClass("yellow accent-2");
                showTextProgress(progress, lessonId);
            } else {
                $('#progressBarLesson' + lessonId).width(progress.toString() + "%");
                showTextProgress(progress, lessonId);
            }
        }
    };

    /// <summary>
    /// s this instance.
    /// </summary>
    /// <returns> the set text progress for score</returns>
    var showTextProgress = function (progress, lessonId) {
        if (isNaN(progress)) {
            progress = 0;
            $('#textProgress' + lessonId).text("");
        }
        else {
            $('#textProgress' + lessonId).text(progress.toString() + "%");
        }

    };

    /// <summary>
    /// s this instance.
    /// </summary>
    /// <returns> update value in total score and amount of exercises</returns>
    var updateValue = function () {
        amountOfLessonExercises = 0;
        totalScore = 0;
    }

    return {
        getAmountOfExercises: getAmountOfExercises,
        getProgress: getProgress,
        showLessonProgress: showLessonProgress,
        setProgressForScore: setProgressForScore
    }
})();
