using EasyLearning.Models.ViewModel;
using System;

namespace EasyLearning.Factory
{
    public static class ExerciseFactory
    {
        /// <summary>
        /// Creates the exercise.
        /// </summary>
        /// <param name="exerciseId">The exercise identifier.</param>
        /// <param name="enunciate">The enunciate.</param>
        /// <param name="pathImage">The path image.</param>
        /// <param name="typeExercise">The type exercise.</param>
        /// <param name="lessonContentId">The lesson content identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public static IExercise CreateExercise(int exerciseId, string enunciate, string pathImage, int typeExercise, int lessonContentId)
        {
            switch (typeExercise)
            {
                case (int)ContentType.SimpleSelection:
                    return CreateSimpleSelectionExercise(exerciseId, enunciate, pathImage, lessonContentId);
                case (int)ContentType.TrueFalse:
                    return CreateTrueFalseExercise(exerciseId, enunciate, pathImage, lessonContentId);
                default:
                    throw new NotSupportedException();
            }
        }

        /// <summary>
        /// Creates the name view.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public static string CreateNameView(int type)
        {
            switch (type)
            {
                case (int)ContentType.SimpleSelection:
                    return ContentType.SimpleSelection.ToString();
                case (int)ContentType.TrueFalse:
                    return ContentType.TrueFalse.ToString();
                default:
                    throw new NotSupportedException();
            }
        }

        /// <summary>
        /// Creates the simple exercise.
        /// </summary>
        /// <param name="exercise">The exercise.</param>
        /// <param name="answers">The answers.</param>
        /// <returns></returns>
        public static SimpleSelectionModel CreateSimpleExercise(IExercise exercise, string answers)
        {
            SimpleSelectionModel simpleSelection = (SimpleSelectionModel)exercise;
            var answerValues = answers.Split(',');
            for (int i = FirstPosition; i < ArraySize; i = i + NextPosition)
            {
                Answer answer = new Answer();
                answer.AnswerId = Convert.ToInt32(answerValues[i]);
                answer.AnswerWord = answerValues[i + 1].ToString();
                simpleSelection.Options.Add(answer);
            }
            return simpleSelection;
        }

        /// <summary>
        /// Creates the true false exercise.
        /// </summary>
        /// <param name="exercise">The exercise.</param>
        /// <param name="affirmation">The affirmation.</param>
        /// <returns></returns>
        public static TrueFalseModel CreateTrueFalseExercise(IExercise exercise, string affirmation)
        {
            TrueFalseModel trueFalse = (TrueFalseModel)exercise;
            trueFalse.Affirmation = affirmation;
            return trueFalse;
        }

        /// <summary>
        /// Creates the simple selection exercise.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="enunciate">The enunciate.</param>
        /// <param name="pathImage">The path image.</param>
        /// <param name="lessonContentId">The lesson content identifier.</param>
        /// <returns></returns>
        private static SimpleSelectionModel CreateSimpleSelectionExercise(int id, string enunciate, string pathImage, int lessonContentId)
        {
            SimpleSelectionModel simpleSelection = new SimpleSelectionModel();
            HeaderExerciseModel headerModel = new HeaderExerciseModel();
            headerModel.PathImage = pathImage;
            headerModel.Question = enunciate;
            simpleSelection.ExerciseId = id;
            simpleSelection.Header = headerModel;
            simpleSelection.LessonContentId = lessonContentId;
            return simpleSelection;
        }

        /// <summary>
        /// Creates the true false exercise.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="enunciate">The enunciate.</param>
        /// <param name="pathImage">The path image.</param>
        /// <param name="lessonContentId">The lesson content identifier.</param>
        /// <returns></returns>
        private static TrueFalseModel CreateTrueFalseExercise(int id, string enunciate, string pathImage, int lessonContentId)
        {
            TrueFalseModel trueFalse = new TrueFalseModel();
            HeaderExerciseModel headerModel = new HeaderExerciseModel();
            headerModel.PathImage = pathImage;
            headerModel.Question = enunciate;
            trueFalse.ExerciseId = id;
            trueFalse.Header = headerModel;
            trueFalse.LessonContentId = lessonContentId;
            return trueFalse;
        }

        private const int NextPosition = 2;
        private const int ArraySize = 6;
        private const int FirstPosition = 0;
    }
}