using EasyLearning.Service.DAL;
using System.Web.Http;

namespace EasyLearning.Service.Controllers.EasyLearningControllers
{
    public class ExercisesAndTipsController : ApiController
    {

        /// <summary>
        /// Calls the commands.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="procedureName">Name of the procedure.</param>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult CallCommands(int id, string parameterName, string procedureName)
        {
            Command command = new Command(id, parameterName, procedureName);
            switch (parameterName)
            {
                case SimpleSelectionId:
                    {
                        return Ok(command.ExecuteStoredProcedureAnswers());
                    }
                case Affirmation:
                    {
                        return Ok(command.ExecuteStoredProcedureAnswer());
                    }
                default:
                    {
                        return Ok(command.ExecuteStoredProcedureExercise());
                    }
            }
        }

        /// <summary>
        /// Gets the example for tip.
        /// </summary>
        /// <param name="tipId">The tip identifier.</param>
        /// <param name="userId">The user identifier.</param>
        /// <param name="parameterTipName">Name of the parameter tip.</param>
        /// <param name="parameterUserName">Name of the parameter user.</param>
        /// <param name="procedureName">Name of the procedure.</param>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult GetExampleForTip(int tipId, string userId, string parameterTipName, string parameterUserName, string procedureName)
        {
            Command command = new Command(tipId, userId, parameterTipName, parameterUserName, procedureName);
            return Ok(command.ExecuteStoredProcedureExampleTip());
        }

        private const string SimpleSelectionId = "@SExerciseId";
        private const string Affirmation = "@ExerciseId";
    }
}