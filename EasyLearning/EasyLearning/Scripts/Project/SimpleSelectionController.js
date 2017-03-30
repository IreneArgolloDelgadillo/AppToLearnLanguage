/**
 * The main class for Simple Selection Exersice
*/
(function () {
    var optionButtons = $('div.card-action button');
    optionButtons.each(function () {
        $(this).bind('click', function () {
            SimpleSelectionEvaluator.evaluateChosenOption(this);
        });
    });
})();