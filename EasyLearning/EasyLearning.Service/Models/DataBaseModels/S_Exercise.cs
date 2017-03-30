using System.Collections.Generic;

namespace EasyLearning.Service.Models.DataBaseModels
{
    /// <summary>
    /// Represent a exercise of simple selection 
    /// </summary>
    public class S_Exercise
    {
        /// <summary>
        /// Gets or sets the s exercise identifier.
        /// </summary>
        /// <value>
        /// The s exercise identifier.
        /// </value>
        public int S_ExerciseId { get; set; }

        /// <summary>
        /// Gets or sets the enunciate.
        /// </summary>
        /// <value>
        /// The enunciate.
        /// </value>
        public virtual Enunciate Enunciate { get; set; }

        /// <summary>
        /// Gets or sets the puntuation.
        /// </summary>
        /// <value>
        /// The puntuation.
        /// </value>
        public int Puntuation { get; set; }

        /// <summary>
        /// Gets or sets the answers.
        /// </summary>
        /// <value>
        /// The answers.
        /// </value>
        public ICollection<Answer> Answers { get; set; }

        /// <summary>
        /// Gets or sets the content of the lesson.
        /// </summary>
        /// <value>
        /// The content of the lesson.
        /// </value>
        public virtual LessonContent LessonContent { get; set; }

    }
}