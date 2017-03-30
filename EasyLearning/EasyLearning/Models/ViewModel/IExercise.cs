namespace EasyLearning.Models.ViewModel
{
    public interface IExercise
    {
        /// <summary>
        /// Gets or sets the exercise identifier.
        /// </summary>
        /// <value>
        /// The exercise identifier.
        /// </value>
        int ExerciseId { get; set; }

        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        /// <value>
        /// The header.
        /// </value>
        HeaderExerciseModel Header { get; set; }

        /// <summary>
        /// Gets or sets the lesson content identifier.
        /// </summary>
        /// <value>
        /// The lesson content identifier.
        /// </value>
        int LessonContentId { set; get; }
    }
}
