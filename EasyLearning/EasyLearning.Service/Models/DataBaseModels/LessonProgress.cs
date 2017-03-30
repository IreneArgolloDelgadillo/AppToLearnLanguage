namespace EasyLearning.Service.Models.DataBaseModels
{
    /// <summary>
    /// Represent the porcentage of progress that the user have for each lesson
    /// </summary>
    public class LessonProgress
    {
        /// <summary>
        /// Gets or sets the lesson progress identifier.
        /// </summary>
        /// <value>
        /// The lesson progress identifier.
        /// </value>
        public int LessonProgressId { get; set; }

        /// <summary>
        /// Gets or sets the percentage.
        /// </summary>
        /// <value>
        /// The percentage.
        /// </value>
        public double Percentage { get; set; }

        /// <summary>
        /// Gets or sets the exercise solved quantity.
        /// </summary>
        /// <value>
        /// The exercise solved quantity.
        /// </value>
        public int ExerciseSolvedQuantity { get; set; }

        /// <summary>
        /// Gets or sets the total exercise quantity.
        /// </summary>
        /// <value>
        /// The total exercise quantity.
        /// </value>
        public int TotalExerciseQuantity { get; set; }

        /// <summary>
        /// Gets or sets the lesson.
        /// </summary>
        /// <value>
        /// The lesson.
        /// </value>
        public virtual Lesson Lesson { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        public virtual ApplicationUser User { get; set; }
    }
}