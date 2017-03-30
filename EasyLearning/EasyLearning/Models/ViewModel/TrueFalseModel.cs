namespace EasyLearning.Models.ViewModel
{
    public class TrueFalseModel : IExercise
    {
        /// <summary>
        /// The exercise identifier
        /// </summary>
        private int exerciseId;

        /// <summary>
        /// Gets or sets the exercise identifier.
        /// </summary>
        /// <value>
        /// The exercise identifier.
        /// </value>
        /// 
        public int ExerciseId
        {
            get
            {
                return exerciseId;
            }

            set
            {
                exerciseId = value;
            }
        }

        /// <summary>
        /// The header
        /// </summary>
        private HeaderExerciseModel header;

        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        /// <value>
        /// The header.
        /// </value>
        public HeaderExerciseModel Header
        {
            get
            {
                return header;
            }

            set
            {
                header = value;
            }
        }

        /// <summary>
        /// The lesson content identifier
        /// </summary>
        private int lessonContentId;

        /// <summary>
        /// Gets or sets the lesson content identifier.
        /// </summary>
        /// <value>
        /// The lesson content identifier.
        /// </value>
        /// 
        public int LessonContentId
        {
            get
            {
                return lessonContentId;
            }

            set
            {
                lessonContentId = value;
            }
        }

        /// <summary>
        /// Gets or sets the affirmation.
        /// </summary>
        /// <value>
        /// The affirmation.
        /// </value>
        public string Affirmation { get; set; }

        /// <summary>
        /// Gets or sets the options.
        /// </summary>
        /// <value>
        /// The options.
        /// </value>
        public string Answer { set; get; }

        /// <summary>
        /// Gets or sets the puntuation.
        /// </summary>
        /// <value>
        /// The puntuation.
        /// </value>
        public int Puntuation { get; set; }
    }
}