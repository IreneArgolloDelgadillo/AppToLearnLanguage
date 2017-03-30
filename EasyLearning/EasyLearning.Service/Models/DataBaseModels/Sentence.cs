using System.Collections.Generic;

namespace EasyLearning.Service.Models.DataBaseModels
{
    /// <summary>
    /// Represent a word or phrase in specify language
    /// </summary>
    public class Sentence
    {
        /// <summary>
        /// Gets or sets the sentence identifier.
        /// </summary>
        /// <value>
        /// The sentence identifier.
        /// </value>
        public int SentenceId { get; set; }

        /// <summary>
        /// Gets or sets the grammar of sentence.
        /// </summary>
        /// <value>
        /// The grammar of sentence.
        /// </value>
        public string GrammarOfSentence { get; set; }

        /// <summary>
        /// Gets or sets the belongs language.
        /// </summary>
        /// <value>
        /// The belongs language.
        /// </value>
        public virtual Language BelongsLanguage { get; set; }

        /// <summary>
        /// Gets or sets the translation set.
        /// </summary>
        /// <value>
        /// The translation set.
        /// </value>
        public virtual TranslationSet TranslationSet { get; set; }

    }
}