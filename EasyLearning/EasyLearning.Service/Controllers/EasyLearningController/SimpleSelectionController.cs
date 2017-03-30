using EasyLearning.Service.DAL;
using EasyLearning.Service.Models;
using EasyLearning.Service.Models.ServiceModels.ExerciseModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace EasyLearning.Service.Controllers.EasyLearningController
{
    public class SimpleSelectionController : ApiController
    {

        /// <summary>
        /// Gets the correct answer.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public IHttpActionResult GetCorrectAnswer(int id)
        {
            Command command = new Command(id, SExerciseId, StoredProcedureGetAnswers);
            Answers = command.ExecuteStoredProcedureAnswers();

            foreach (Answer answer in Answers)
            {
                //TODO: Refactor with factory
                var correctAnswer = DB.Answers.FirstOrDefault(a => a.AnswerId == answer.AnswerId);
                if (correctAnswer.State)
                {
                    CorrectAnswer = correctAnswer.Sentence.GrammarOfSentence;
                    return Ok(CorrectAnswer);
                }
            }
            return null;
        }

        private IList<Answer> Answers = new List<Answer>();
        private ApplicationDbContext DB = new ApplicationDbContext();
        private string CorrectAnswer = "";
        private const string SExerciseId = "@SExerciseId";
        private const string StoredProcedureGetAnswers = "GetSimpleSelectionOptions";
    }
}