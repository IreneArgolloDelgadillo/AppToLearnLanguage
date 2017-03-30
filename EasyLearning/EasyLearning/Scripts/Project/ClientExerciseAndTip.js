/**
*Client of exercises and tips
*/
var ClientExerciseAndTip = function () {
    var simpleSelectionExercise = 1;
    var trueFalseExercise = 2;
    var listenningTip = 3;
    var grammarTip = 4;
    var lessonContentId = 0;
    var userId = sessionStorage.getItem('userId');
    var currentLevelId;
    var currentLessonId;

    /**
    *Function to get the next partial view
    */
    var nextPartialView = function (lessonId, levelId) {
        saveLevel(lessonId, levelId);
        var parameters = createUrlParameters(lessonContentId, lessonId);
        $.ajax({
            type: "GET",
            url: "http://localhost:1893/Api/ExercisesAndTips",
            data: {
                id: parameters[0],
                parameterName: parameters[1],
                procedureName: parameters[2]
            },
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            error: function () {
                getLessonsView();
            },
            success: function (exercise) {
                if (exercise != null) {
                    verifyExercise(exercise);
                    percentajeExercisesProgressBar.getTotalOfExercises(currentLessonId);
                } else {
                    getLessonsView();
                }
            }
        });
    }

    /*
    * Function to save levelId and lessonId
    */
    var saveLevel = function (lessonId, levelId) {
        if (levelId > 0 && lessonId > 0) {
            currentLevelId = levelId;
            currentLessonId = lessonId;
            $("#lessonByLevel").hide();
            $("#bodyContainer").hide();
            $("#exercisesAndTips").show();
        }
    }

    /**
    *Function to verify exercise and send to get the partial view by exercise
    */
    var verifyExercise = function (exercise) {
        percentajeExercisesProgressBar.addExerciseResolved();
        if (exercise.type == simpleSelectionExercise) {
            getSimpleExerciseAnswers(exercise);
        } else if (exercise.type == trueFalseExercise) {
            getTrueFalseExercise(exercise);
        } else if (exercise.type == grammarTip) {
            getGrammarTip(exercise);
        } else if (exercise.type == listenningTip) {
            getListeningTip(exercise);
        } else {
            getResultPartialView();
        }
    }

    /**
    *Function to get View lessons
    */
    var getLessonsView = function () {
        $("#exercises").empty();
        percentajeExercisesProgressBar.resetExercisesCount();
        lessonContentId = 0;
        lessons.getLessons(currentLevelId);
    }

    /**
    *Function to get PartialView of TrueFalseExercise
    */
    var getTrueFalseExercise = function (exercise) {
        var parameters = createUrlParametersByExercise(exercise.type, exercise.exerciseId);
        $.ajax({
            type: "GET",
            url: "http://localhost:1893/Api/ExercisesAndTips",
            data: {
                id: parameters[0],
                parameterName: parameters[1],
                procedureName: parameters[2]
            },
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (affirmation) {
                $.ajax({
                    type: "GET",
                    url: '/PartialViewBuilder/GetTrueFalseExercise/',
                    data: {
                        exerciseId: exercise.exerciseId,
                        enunciate: exercise.enunciate,
                        pathImage: exercise.pathImage,
                        typeExercise: exercise.type,
                        lessonContentId: exercise.lessonContentId,
                        affirmation: affirmation.answerWord
                    },
                    error: function () {
                        alert("An error occurred.");
                    },
                    success: function (data) {
                        lessonContentId = exercise.lessonContentId;
                        $("#exercises").html(data);
                        $("#nextButton").hide();
                    }
                });
            }
        });
    }

    /**
    *Function to get PartialView of GrammarTip
    */
    var getGrammarTip = function (tip) {
        var parameters = createUrlParametersForExampleTip(tip.exerciseId, userId, tip.type);
        $.ajax({
            type: "GET",
            url: "http://localhost:1893/Api/ExercisesAndTips",
            data: {
                tipId: parameters[0],
                userId: parameters[1],
                parameterTipName: parameters[2],
                parameterUserName: parameters[3],
                procedureName: parameters[4]
            },
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (examples) {
                if (examples != null) {
                    $.ajax({
                        type: "GET",
                        url: '/PartialViewBuilder/GetGrammarTip/',
                        data: {
                            grammarTipId: tip.exerciseId,
                            tip: tip.enunciate,
                            lessonContentId: tip.lessonContentId,
                            example: examples[0].exampleOnNativeLanguage + ',' + examples[0].exampleOnLanguageToLearn + ',' + examples[1].exampleOnNativeLanguage + ',' + examples[1].exampleOnLanguageToLearn
                        },
                        error: function (e1, e2, e3) {
                            alert("An error occurred." + e1 + e2 + e3);
                        },
                        success: function (data) {
                            lessonContentId = tip.lessonContentId;
                            $("#exercises").html(data);
                            $("#nextButton").show();
                        }
                    });
                }
            }
        });
    }

    /**
    *Function to get PartialView of Simple exercises
    */
    var getSimpleExerciseAnswers = function (exercise) {
        var parameters = createUrlParametersByExercise(exercise.type, exercise.exerciseId);
        $.ajax({
            type: "GET",
            url: "http://localhost:1893/Api/ExercisesAndTips",
            data: {
                id: parameters[0],
                parameterName: parameters[1],
                procedureName: parameters[2]
            },
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (answers) {
                if (answers != null) {
                    $.ajax({
                        type: "GET",
                        url: '/PartialViewBuilder/GetSimpleExercise',
                        data: {
                            exerciseId: exercise.exerciseId,
                            enunciate: exercise.enunciate,
                            pathImage: exercise.pathImage,
                            typeExercise: exercise.type,
                            lessonContentId: exercise.lessonContentId,
                            answersOptions: answers[0].answerId + ',' + answers[0].answerWord + ',' + answers[1].answerId + ',' + answers[1].answerWord + ',' + answers[2].answerId + ',' + answers[2].answerWord
                        },
                        error: function (e1, e2, e3) {
                            alert("An error occurred." + e1 + e2 + e3);
                        },
                        success: function (data) {
                            lessonContentId = exercise.lessonContentId;
                            $("#exercises").html(data);
                            $("#nextButton").hide();
                        }
                    });
                }
            }
        });
    }

    /**
    *Function to get PartialView of ListeningTip
    */
    var getListeningTip = function (tip) {
        var parameters = createUrlParametersForExampleTip(tip.exerciseId, userId, tip.type);
        $.ajax({
            type: "GET",
            url: "http://localhost:1893/Api/ExercisesAndTips",
            data: {
                tipId: parameters[0],
                userId: parameters[1],
                parameterTipName: parameters[2],
                parameterUserName: parameters[3],
                procedureName: parameters[4]
            },
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (examples) {
                if (examples != null) {
                    $.ajax({
                        type: "GET",
                        url: '/PartialViewBuilder/GetListenningTip/',
                        data: {
                            listeningTipId: tip.exerciseId,
                            pathImage: tip.pathImage,
                            lessonContentId: tip.lessonContentId,
                            example: examples[0].exampleOnNativeLanguage + ',' + examples[0].exampleOnLanguageToLearn
                        },
                        error: function (e1, e2, e3) {
                            alert("An error occurred." + e1 + e2 + e3);
                        },
                        success: function (data) {
                            lessonContentId = tip.lessonContentId;
                            $("#exercises").html(data);
                            $("#nextButton").show();
                            
                        }
                    });
                }
            }
        });
    }

    /**
    * Function to reset values of clientExercise
    */
    var resetVariables = function () {
        percentajeExercisesProgressBar.resetExercisesCount();
        lessonContentId = 0;
    }

    return {
        nextPartialView: nextPartialView,
        resetVariables: resetVariables
    };
}();