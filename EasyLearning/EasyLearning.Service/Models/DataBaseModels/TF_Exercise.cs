namespace EasyLearning.Service.Models.DataBaseModels
{
    /// <summary>
    /// Represent a exercise whe the answer is a true or false
    /// </summary>
    public class TF_Exercise
    {
        /// <summary>
        /// Gets or sets the tf exercise identifier.
        /// </summary>
        /// <value>
        /// The tf exercise identifier.
        /// </value>
        public int TF_ExerciseId { get; set; }

        /// <summary>
        /// Gets or sets the enunciate.
        /// </summary>
        /// <value>
        /// The enunciate.
        /// </value>
        public virtual Enunciate Enunciate { get; set; }

        /// <summary>
        /// Gets or sets the affirmation.
        /// </summary>
        /// <value>
        /// The affirmation.
        /// </value>
        public virtual Sentence Affirmation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is true.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is true; otherwise, <c>false</c>.
        /// </value>
        public bool IsTrue { get; set; }

        /// <summary>
        /// Gets or sets the puntuation.
        /// </summary>
        /// <value>
        /// The puntuation.
        /// </value>
        public int Puntuation { get; set; }

        /// <summary>
        /// Gets or sets the content of the lesson.
        /// </summary>
        /// <value>
        /// The content of the lesson.
        /// </value>
        public virtual LessonContent LessonContent { get; set; }
    }
}