namespace EasyLearning.Service.Models.ServiceModels
{
    /// <summary>
    /// Represents the commun atributes of exercises
    /// </summary>
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
        /// Gets or sets the enunciate.
        /// </summary>
        /// <value>
        /// The enunciate.
        /// </value>
        string Enunciate { get; set; }

        /// <summary>
        /// Gets or sets the path image.
        /// </summary>
        /// <value>
        /// The path image.
        /// </value>
        string PathImage { get; set; }

        /// <summary>
        /// Gets or sets the type exercise.
        /// </summary>
        /// <value>
        /// The type exercise.
        /// </value>
        int Type { get; set; }

        /// <summary>
        /// Gets or sets the lesson content identifier.
        /// </summary>
        /// <value>
        /// The lesson content identifier.
        /// </value>
        int LessonContentId { get; set; }
    }
}