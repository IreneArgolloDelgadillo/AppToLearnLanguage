var vocabularyController = (function () {

    var language = '';

    function setLanguage(LanguageId) {
        switch (LanguageId) {
            case '1':
                language = "US English Female";
                break;
            case '2':
                language = "Spanish Latin American Female";
                break;
            case '3':
                language = "Italian Female";
                break;
            default:
                language = "US English Female";
        }
        return language
    }
    function publicReproductionWord() {
        setLanguage(sessionStorage.getItem('userLearnLanguage'));
        responsiveVoice.speak(document.getElementById('word').innerText, language, { rate: 1 });
        return responsiveVoice.isPlaying();
    }
    function publicSlowPlaybackWord() {
        setLanguage(sessionStorage.getItem('userLearnLanguage'));
        responsiveVoice.speak(document.getElementById('word').innerText, language, { rate: 0.5 });
        return responsiveVoice.isPlaying();
    }

    return {
        WordReproduction: publicReproductionWord,
        WordSlowPlayback: publicSlowPlaybackWord,
        language: setLanguage(),
    };
})();