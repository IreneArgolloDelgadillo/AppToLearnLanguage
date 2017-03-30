using System.Collections.Generic;

namespace EasyLearning.Models.ViewModel
{
    public class SimpleSelectionModel: IExercise
    {
        private int exerciseId;

        /// <summary>
        /// Gets or sets the exercise identifier.
        /// </summary>
        /// <value>
        /// The exercise identifier.
        /// </value>
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
        
        private int lessonContentId;

        /// <summary>
        /// Gets or sets the lesson content identifier.
        /// </summary>
        /// <value>
        /// The lesson content identifier.
        /// </value>
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
        /// Gets or sets the options.
        /// </summary>
        /// <value>
        /// The options.
        /// </value>
        public IList<Answer> Options { set; get; } = new List<Answer>();
    }
}