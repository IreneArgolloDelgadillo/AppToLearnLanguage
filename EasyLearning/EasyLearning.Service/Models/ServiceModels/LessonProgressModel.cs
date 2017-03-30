
namespace EasyLearning.Service.Models.ServiceModels
{
    public class LessonProgressModel
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
        public int Percentage { get; set; }

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
        /// Gets or sets the lesson identifier.
        /// </summary>
        /// <value>
        /// The lesson identifier.
        /// </value>
        public int LessonId { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public string UserId { get; set; }
    }
}