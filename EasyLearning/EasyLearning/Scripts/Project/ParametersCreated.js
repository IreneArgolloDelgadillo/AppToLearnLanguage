/**
*Function to set values to url parameters 
*/
function createUrlParameters(lessonContentId, levelId) {
    var parameters;
    var nameProcedure = "GetContentLesson";
    var nameParameter;
    if (lessonContentId == 0 && levelId > 0) {
        nameParameter = "@LessonId";
        parameters = [levelId, nameParameter, nameProcedure];
    } else {
        nameParameter = "@CurrentContentLessonId";
        parameters = [lessonContentId, nameParameter, nameProcedure];
    }
    return parameters;
}

/**
*Function to set values to url by type of exercise parameters 
*/
function createUrlParametersByExercise(typeExercise, lessonContentId) {
    var simpleSelectionType = 1;
    var trueFalse = 2;
    var grammarTip = 4;
    var parameters;
    var nameParameter;
    var nameProcedure;
    if (typeExercise == simpleSelectionType) {
        nameParameter = "@SExerciseId";
        nameProcedure = "GetSimpleSelectionOptions";
    } else if (typeExercise == trueFalse) {
        nameParameter = "@ExerciseId";
        nameProcedure = "GetTrueFalseAffirmation";
    } else if (typeExercise == grammarTip) {
        nameParameter = "@LessonContentId";
        nameProcedure = "GetGrammarTipContent";
    }
    parameters = [lessonContentId, nameParameter, nameProcedure]
    return parameters;
}

/**
*Function to create values for url tips
*/
function createUrlParametersForExampleTip(tipId, userId, type) {
    var parameters;
    var firtParameter = tipId;
    var secondParameter = userId;
    var grammar = 4;
    if (type == grammar) {
        var firstParameterName = "@GrammarTipId";
        var secondParameterName = "@UserId";
        var procedureName = "GetGrammarExamples";
    } else {
        var firstParameterName = "@TranslationSetId";
        var secondParameterName = "@UserId";
        var procedureName = "GetListeningTipWords";
    }
    parameters = [firtParameter, secondParameter, firstParameterName, secondParameterName, procedureName];
    return parameters;
}