namespace EasyLearning.Service.Models.DataBaseModels
{
    /// <summary>
    /// Represent a lesson to teach the pronuntation 
    /// </summary>
    public class ListeningTip
    {
        /// <summary>
        /// Gets or sets the listening tip identifier.
        /// </summary>
        /// <value>
        /// The listening tip identifier.
        /// </value>
        public int ListeningTipId { get; set; }

        /// <summary>
        /// Gets or sets the transaltion set words.
        /// </summary>
        /// <value>
        /// The transaltion set words.
        /// </value>
        public virtual TranslationSet TransaltionSetWords { get; set; }

        /// <summary>
        /// Gets or sets the content of the lesson.
        /// </summary>
        /// <value>
        /// The content of the lesson.
        /// </value>
        public virtual LessonContent LessonContent { get; set; }
    }
}