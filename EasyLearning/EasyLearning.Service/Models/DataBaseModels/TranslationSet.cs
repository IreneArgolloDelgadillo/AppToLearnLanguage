using System.Collections.Generic;

namespace EasyLearning.Service.Models.DataBaseModels
{
    /// <summary>
    /// Represent a set of sentences that have the same meaning in a different languages
    /// </summary>
    public class TranslationSet
    {
        /// <summary>
        /// Gets or sets the translation set identifier.
        /// </summary>
        /// <value>
        /// The translation set identifier.
        /// </value>
        public int TranslationSetId { get; set; }

        /// <summary>
        /// Gets or sets the image path.
        /// </summary>
        /// <value>
        /// The image path.
        /// </value>
        public string ImagePath { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the sentences.
        /// </summary>
        /// <value>
        /// The sentences.
        /// </value>
        public ICollection<Sentence> Sentences { get; set; }

        /// <summary>
        /// Gets or sets the grammar tips.
        /// </summary>
        /// <value>
        /// The grammar tips.
        /// </value>
        public ICollection<GrammarTip> GrammarTips { get; set; }
    }
}