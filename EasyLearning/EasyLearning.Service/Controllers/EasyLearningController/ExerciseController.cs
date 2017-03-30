using EasyLearning.Service.DAL;
using EasyLearning.Service.Models;
using EasyLearning.Service.Models.DataBaseModels;
using EasyLearning.Service.Models.ServiceModels;
using System.Linq;
using System.Web.Http;

namespace EasyLearning.Service.Controllers.EasyLearningController
{
    public class ExerciseController : ApiController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseController"/> class.
        /// </summary>
        public ExerciseController()
        {
            unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Gets the s exercise.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public IHttpActionResult GetS_Exercise(int id)
        {
            S_Exercise foundExercise = unitOfWork.SimpleSelectionRepository.GetByID(id);

            if (foundExercise == null)
            {
                return NotFound();
            }

            return Ok(exerciseModel(foundExercise));
        }

        /// <summary>
        /// Puts the s exercise.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="trueFalse">The true false.</param>
        /// <returns></returns>
        public IHttpActionResult PutS_Exercise(int id, SimpleSelectionModel trueFalse)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");
            var existingExercise = db.S_Exercies.FirstOrDefault(s => s.S_ExerciseId == id);

            if (existingExercise != null)
            {
                existingExercise.Puntuation = trueFalse.Puntuation;

                db.SaveChanges();
            }
            else
            {
                return NotFound();
            }

            return Ok(trueFalse);
        }

        /// <summary>
        /// Exercises the model.
        /// </summary>
        /// <param name="simpleSelection">The simple selection.</param>
        /// <returns></returns>
        private SimpleSelectionModel exerciseModel(S_Exercise simpleSelection)
        {
            SimpleSelectionModel current = new SimpleSelectionModel()
            {
                Puntuation = simpleSelection.Puntuation,
            };

            return current;
        }

        private UnitOfWork unitOfWork;
        private ApplicationDbContext db = new ApplicationDbContext();

    }
}
