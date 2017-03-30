namespace EasyLearning.Service.Models.ServiceModels
{
    public class VocabularyTipModel
    {
        /// <summary>
        /// Gets or sets the exercise identifier.
        /// </summary>
        /// <value>
        /// The exercise identifier.
        /// </value>
        public int ExerciseId { get; set; }

        /// <summary>
        /// Gets or sets the translation set identifier.
        /// </summary>
        /// <value>
        /// The translation set identifier.
        /// </value>
        public int TranslationSetId { set; get; }

        /// <summary>
        /// Gets or sets the path image.
        /// </summary>
        /// <value>
        /// The path image.
        /// </value>
        public string PathImage { set; get; }

        /// <summary>
        /// Gets or sets the lesson content identifier.
        /// </summary>
        /// <value>
        /// The lesson content identifier.
        /// </value>
        public int LessonContentId { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public int Type { get; set; }

        /// <summary>
        /// Gets or sets the example.
        /// </summary>
        /// <value>
        /// The example.
        /// </value>
        public ExampleModel Example { set; get; }
    }
}