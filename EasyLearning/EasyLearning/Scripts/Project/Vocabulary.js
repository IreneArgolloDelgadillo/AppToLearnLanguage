var vocabulary = (function () {
    var word ="",
    sentence="";
    function publicGetWord() {
        return word;
    }
    function publicGetSentence() {
        return sentence;
    }
    function publicSetWord(newWord) {
        word = newWord;
    }
    function publicSetSentence(newSentence) {
        sentence = newSentence
    }
    return {
        getWord: publicGetWord,
        getsentence: publicGetSentence,
        setword: publicSetWord,
        setsentence: publicSetSentence
    };
})();
model = new vocabulary;
