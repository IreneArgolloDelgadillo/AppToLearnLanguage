using System.Collections.Generic;

namespace EasyLearning.Service.Models.DataBaseModels
{
    /// <summary>
    /// Represent a leccion that contains instruccions or tips for the lesson
    /// </summary>
    public class GrammarTip
    {
        /// <summary>
        /// Gets or sets the grammar tip identifier.
        /// </summary>
        /// <value>
        /// The grammar tip identifier.
        /// </value>
        public int GrammarTipId { get; set; }

        /// <summary>
        /// Gets or sets the tip interpretation.
        /// </summary>
        /// <value>
        /// The tip interpretation.
        /// </value>
        public virtual Enunciate TipInterpretation { get; set; }

        /// <summary>
        /// Gets or sets the translation sets.
        /// </summary>
        /// <value>
        /// The translation sets.
        /// </value>
        public ICollection<TranslationSet> TranslationSets { get; set; }

        /// <summary>
        /// Gets or sets the content of the lesson.
        /// </summary>
        /// <value>
        /// The content of the lesson.
        /// </value>
        public virtual LessonContent LessonContent { get; set; }

    }
}