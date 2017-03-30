var selectedCorrectWrongAnswer = (function () {

    var correctAnswer;
    var correctScore = 1;
    var incorrectScore = 0;


    /**
    *Function to select the correct option
    */
    var selectTrue = function () {
        var buttonTrue = $('#ButtonTrue');
        var buttonFalse = $('#ButtonFalse');
        selectOption(buttonTrue, buttonFalse, true);
    };

    /**
    *Function to selects the wrong answer
    */
    var selectFalse = function () {
        var buttonTrue = $('#ButtonTrue');
        var buttonFalse = $('#ButtonFalse');
        selectOption(buttonFalse, buttonTrue, false);
    };

    /**
    *Function to select the option
    */
    var selectOption = function (selectedButton, otherButton, userAnswer) {
        var url = "http://localhost:1893/api/TrueFalse/" + exerciseId;
        $.get(url, function (trueFalse) {
            correctAnswer = trueFalse.answer;
            $("#nextButton").show();
            if (isCorrectAnswer(userAnswer)) {
                selectedButton.addClass('green');
                otherButton.prop('disabled', true);
                var puntuation = { "puntuation": correctScore };
                lessonProgress.updateProgress(url, puntuation);
                setProgress.getAmountOfExercises();
            }
            else {
                otherButton.addClass('green');
                selectedButton.prop('disabled', true);
                selectedButton.addClass('red');
                var puntuation = { "puntuation": incorrectScore };
                lessonProgress.updateProgress(url, puntuation);
                setProgress.getAmountOfExercises();
            }

        });
    };

    /**
    *Function that verify the correct answer
    */
    var isCorrectAnswer = function (userAnswer) {
        return correctAnswer === userAnswer;
    };

    return {
        selectTrue: selectTrue,
        selectFalse: selectFalse,
    };

})();