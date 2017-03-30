/// <var>The lesson progress</var>
var lessonProgress = (function () {

    /// <summary>
    /// s this instance.
    /// </summary>
    /// <returns></returns>
    var updateProgress = function (url, dataObject) {
        $.ajax({
            url: url,
            type: 'PUT',
            contentType: "application/json",
            data: JSON.stringify(dataObject),
            dataType: 'json',
            success: function () {
                setProgress.getProgress(dataObject);
            }
        });
    };

    return {
        updateProgress: updateProgress,
    }
})();