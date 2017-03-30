/// <var>The put lesson progress</var>
var putLessonProgress = (function () {
    var url = "http://localhost:1893/api/LessonProgress";

    /// <summary>
    /// s this instance.
    /// </summary>
    /// <returns>the lesson progress</returns>
    var createLessonProgress = function (lessonProgress) {
        $.ajax({
            type: 'POST',
            url: url,
            contentType: "application/json",
            data: JSON.stringify(lessonProgress),
            dataType: 'json',
            success: function (result) {
                currentLessonId = result.lessonProgressId;
                console.log(currentLessonId);
            }
        });
    };

    /// <summary>
    /// s this instance.
    /// </summary>
    /// <returns>update the lesson progress</returns>
    var updateLessonProgress = function (lessonProgress, VariableForSetTheLessonProgressId) {
        if (VariableForSetTheLessonProgressId > 0) {
            Url = url + "/" + lessonProgressId;
        } else {
            Url = url + "/" + currentLessonId;
        }
        $.ajax({
            type: 'PUT',
            url: Url,
            contentType: "application/json",
            data: JSON.stringify(lessonProgress),
            dataType: 'json',
            success: function (result) {
            }
        });
    };

    /// <summary>
    /// s this instance.
    /// </summary>
    /// <returns>get the lesson progress</returns>
    var getLessonProgress = function (lessonId, userId) {
        var hasProgress = 'hasProgress';
        $.ajax({
            type: 'GET',
            url: 'http://localhost:1893/api/LessonProgress',
            data: {
                lessonId: lessonId,
                UserId: userId
            },
            crossDomain: true,
            headers: {
                'Access-Control-Allow-Origin': '*',
                'Authorization': 'bearer ' + sessionStorage.getItem('accessToken'),
            },
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            success: function (lessonProgress) {
                sessionStorage.setItem(hasProgress, '1');
                lessonProgressId = lessonProgress.lessonProgressId;
                setProgress.setProgressForScore(lessonProgress.percentage, lessonProgress.lessonId);
            }
        });
    };

    return {
        createLessonProgress: createLessonProgress,
        updateLessonProgress: updateLessonProgress,
        getLessonProgress: getLessonProgress
    };

})();