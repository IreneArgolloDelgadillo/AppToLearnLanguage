using EasyLearning.Service.Models.ServiceModels.ExerciseModel;
using System.Collections.Generic;

namespace EasyLearning.Service.Models.ServiceModels
{
    public class SimpleSelectionModel : IExercise
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

            set
            {
                exerciseId = value;
            }
            get
            {
                return exerciseId;
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

        private string enunciate;

        /// <summary>
        /// Gets or sets the enunciate.
        /// </summary>
        /// <value>
        /// The enunciate.
        /// </value>
        public string Enunciate
        {
            get
            {
                return enunciate;
            }

            set
            {
                enunciate = value;
            }
        }

        private string pathImage;

        /// <summary>
        /// Gets or sets the path image.
        /// </summary>
        /// <value>
        /// The path image.
        /// </value>
        public string PathImage
        {
            get
            {
                return pathImage;
            }

            set
            {
                pathImage = value;
            }
        }

        private int typeExercise;

        /// <summary>
        /// Gets or sets the type exercise.
        /// </summary>
        /// <value>
        /// The type exercise.
        /// </value>
        public int Type
        {
            get
            {
                return typeExercise;
            }

            set
            {
                typeExercise = value;
            }
        }

        /// <summary>
        /// Gets or sets the options.
        /// </summary>
        /// <value>
        /// The options.
        /// </value>
        public IList<string> Options { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the puntuation.
        /// </summary>
        /// <value>
        /// The puntuation.
        /// </value>
        public int Puntuation { get; set; }
    }
}