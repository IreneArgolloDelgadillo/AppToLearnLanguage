/**
*Evaluator of a simple selection exercise
*/
var simpleSelectionEvaluator = (function () {
    var correctAnswer;
    var correctScore = 1;
    var incorrectScore = 0;


    /**
     *Function to evaluate the chosen option
    */
    var evaluateChosenOption = function (chosenButton) {
        var url = "http://localhost:1893/Api/SimpleSelection/" + simpleSelectionId;
        var ExerciseUrl = "http://localhost:1893/Api/Exercise/" + simpleSelectionId;

        $.get(url, function (answer) {
            correctAnswer = answer;
            var userAnswer = $(chosenButton).text();
            if (isCorrectAnswer(userAnswer)) {
                $(chosenButton).addClass('green');
                var puntuation = { "puntuation": correctScore };
                lessonProgress.updateProgress(ExerciseUrl, puntuation);
                setProgress.getAmountOfExercises();
                var optionButtons = $('div.card-action button');
                optionButtons.each(function () {
                    $(this).prop('disabled', true);
                });
            }
            else {
                findCorrectOption();
                var puntuation = { "puntuation": incorrectScore };
                lessonProgress.updateProgress(ExerciseUrl, puntuation);
                setProgress.getAmountOfExercises();
            }
        });
        $("#nextButton").show();
    }

    /**
     *Returns if it is the correct answer
    */
    var isCorrectAnswer = function (answerUser) {
        return correctAnswer === answerUser;
    }

    /**
    *Function to find the correct option
    */
    var findCorrectOption = function () {
        var optionButtons = $('div.card-action button');
        optionButtons.each(function () {
            var text = $(this).text();
            if (isCorrectAnswer(text)) {
                $(this).addClass('green');
            }
            else {
                $(this).addClass('red');
            }
            $(this).prop('disabled', true);
        });
    }

    return {
        evaluateChosenOption: evaluateChosenOption
    };

})();