using EasyLearning.Factory;
using EasyLearning.Models.ViewModel;
using System.Web.Mvc;

namespace EasyLearning.Controllers.ViewController
{
    public class PartialViewBuilderController : Controller
    {
        /// <summary>
        /// Gets the exercise.
        /// </summary>
        /// <param name="exerciseId">The exercise identifier.</param>
        /// <param name="enunciate">The enunciate.</param>
        /// <param name="pathImage">The path image.</param>
        /// <param name="typeExercise">The type exercise.</param>
        /// <param name="lessonContentId">The lesson content identifier.</param>
        /// <returns></returns>
        public PartialViewResult GetExercise(int exerciseId, string enunciate, string pathImage, int typeExercise, int lessonContentId)
        {
            return PartialView(ExerciseFactory.CreateNameView(typeExercise), ExerciseFactory.CreateExercise(exerciseId, enunciate, pathImage, typeExercise, lessonContentId));
        }

        /// <summary>
        /// Gets the simple selection exercise parameters.
        /// </summary>
        /// <param name="exerciseId">The exercise identifier.</param>
        /// <param name="enunciate">The enunciate.</param>
        /// <param name="pathImage">The path image.</param>
        /// <param name="typeExercise">The type exercise.</param>
        /// <param name="lessonContentId">The lesson content identifier.</param>
        /// <param name="answersOptions">The answers options.</param>
        /// <returns></returns>
        public PartialViewResult GetSimpleExercise(int exerciseId, string enunciate, string pathImage, int typeExercise, int lessonContentId, string answersOptions)
        {
            IExercise simple = ExerciseFactory.CreateExercise(exerciseId, enunciate, pathImage, typeExercise, lessonContentId);
            return PartialView(ExerciseFactory.CreateNameView(typeExercise), ExerciseFactory.CreateSimpleExercise(simple, answersOptions));
        }

        /// <summary>
        /// Gets the true false exercise.
        /// </summary>
        /// <param name="exerciseId">The exercise identifier.</param>
        /// <param name="enunciate">The enunciate.</param>
        /// <param name="pathImage">The path image.</param>
        /// <param name="typeExercise">The type exercise.</param>
        /// <param name="lessonContentId">The lesson content identifier.</param>
        /// <param name="affirmation">The affirmation.</param>
        /// <returns></returns>
        public PartialViewResult GetTrueFalseExercise(int exerciseId, string enunciate, string pathImage, int typeExercise, int lessonContentId, string affirmation)
        {
            IExercise simple = ExerciseFactory.CreateExercise(exerciseId, enunciate, pathImage, typeExercise, lessonContentId);
            return PartialView(ExerciseFactory.CreateNameView(typeExercise), ExerciseFactory.CreateTrueFalseExercise(simple, affirmation));
        }

        /// <summary>
        /// Gets the grammar tip.
        /// </summary>
        /// <param name="grammarTipId">The grammar tip identifier.</param>
        /// <param name="tip">The tip.</param>
        /// <param name="lessonContentId">The lesson content identifier.</param>
        /// <param name="example">The example.</param>
        /// <returns></returns>
        public PartialViewResult GetGrammarTip(int grammarTipId, string tip, int lessonContentId, string example)
        {
            GrammarTipModel grammarTip = TipFactory.CreateGrammarTip(grammarTipId, tip, lessonContentId, example);
            return PartialView("GrammarTip", grammarTip);
        }

        /// <summary>
        /// Gets the listenning tip.
        /// </summary>
        /// <param name="listeningTipId">The listening tip identifier.</param>
        /// <param name="pathImage">The path image.</param>
        /// <param name="lessonContentId">The lesson content identifier.</param>
        /// <param name="example">The example.</param>
        /// <returns></returns>
        public PartialViewResult GetListenningTip(int listeningTipId, string pathImage, int lessonContentId, string example)
        {
            VocabularyTipModel tip = TipFactory.CreateListenningTip(listeningTipId, pathImage,lessonContentId, example);
            return PartialView("Vocabulary", tip);
        }

        /// <summary>
        /// Gets the partial view.
        /// </summary>
        /// <returns></returns>
        public PartialViewResult GetPartialView()
        {
            return PartialView("PartialView");
        }

        /// <summary>
        /// Gets the final partial view.
        /// </summary>
        /// <returns></returns>
        public PartialViewResult GetFinishPartialView()
        {
            return PartialView("FinishView");
        }
    }
}