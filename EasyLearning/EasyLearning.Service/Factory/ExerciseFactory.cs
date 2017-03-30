using EasyLearning.Service.Models.ServiceModels;
using EasyLearning.Service.Models.ServiceModels.ExerciseModel;
using System.Collections.Generic;

namespace EasyLearning.Service.Factory
{
    public class ExerciseFactory
    {
        /// <summary>
        /// Gets the answers.
        /// </summary>
        /// <value>
        /// The answers.
        /// </value>
        public IList<Answer> Answers { get; private set; } = new List<Answer>();

        /// <summary>
        /// Creates the exercise.
        /// </summary>
        /// <param name="exerciseId">The exercise identifier.</param>
        /// <param name="enunciate">The enunciate.</param>
        /// <param name="pathImage">The path image.</param>
        /// <param name="typeExercise">The type exercise.</param>
        /// <param name="lessonContentId">The lesson content identifier.</param>
        /// <returns></returns>
        public IExercise CreateExercise(int exerciseId, string enunciate, string pathImage, int typeExercise, int lessonContentId)
        {
            SimpleSelectionModel simple = new SimpleSelectionModel()
            {
                ExerciseId = exerciseId,
                Enunciate = enunciate,
                PathImage = pathImage,
                Type = typeExercise,
                LessonContentId = lessonContentId
            };
            return simple;
        }

        /// <summary>
        /// Creates the answers.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="word">The word.</param>
        public void AddToAnswersList(int id, string word)
        {
            Answer answer = new Answer();
            answer.AnswerId = id;
            answer.AnswerWord = word;
            Answers.Add(answer);
        }

        /// <summary>
        /// Creates the answer.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="word">The word.</param>
        public Answer CreateAnswer(string word)
        {
            Answer answer = new Answer();
            answer.AnswerWord = word;
            return answer;
        }

        /// <summary>
        /// Creates the true false exercise.
        /// </summary>
        /// <param name="exerciseId">The exercise identifier.</param>
        /// <param name="enunciate">The enunciate.</param>
        /// <param name="pathImage">The path image.</param>
        /// <param name="typeExercise">The type exercise.</param>
        /// <param name="lessonContentId">The lesson content identifier.</param>
        /// <param name="affirmations">The affirmations.</param>
        /// <returns></returns>
        public TrueFalseExerciseModel CreateTrueFalseExercise(int exerciseId, string enunciate, string pathImage, int typeExercise, int lessonContentId, string affirmations)
        {
            TrueFalseExerciseModel trueFalse = new TrueFalseExerciseModel();
            trueFalse.ExerciseId = exerciseId;
            trueFalse.Enunciate = enunciate;
            trueFalse.PathImage = pathImage;
            trueFalse.Type = typeExercise;
            trueFalse.LessonContentId = lessonContentId;
            return trueFalse;
        }
    }
}