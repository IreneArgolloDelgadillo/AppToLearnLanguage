using EasyLearning.Service.DAL;
using EasyLearning.Service.Models;
using EasyLearning.Service.Models.DataBaseModels;
using EasyLearning.Service.Models.ServiceModels;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;

namespace EasyLearning.Service.Controllers.EasyLearningControllers
{
    public class TrueFalseController : ApiController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrueFalseController"/> class.
        /// </summary>
        public TrueFalseController()
        {
            unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Gets the true false.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [ResponseType(typeof(TF_Exercise))]
        public IHttpActionResult GetTrueFalse(int id)
        {
            TF_Exercise foundTrueFlaseExercise = unitOfWork.TrueFalseRepository.GetByID(id);

            if (foundTrueFlaseExercise == null)
            {
                return NotFound();
            }

            return Ok(trueFalseModel(foundTrueFlaseExercise));
        }

        // PUT: api/Levels/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, TrueFalseModel trueFalse)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");


            var existingTrueFaslse = db.TF_Exercises.FirstOrDefault(s => s.TF_ExerciseId == id);

            if (existingTrueFaslse != null)
            {
                existingTrueFaslse.Puntuation = trueFalse.Puntuation;

                db.SaveChanges();
            }
            else
            {
                return NotFound();
            }


            return Ok(trueFalse);
        }

        private bool TrueFalseExists(int id)
        {
            return db.TF_Exercises.Count(e => e.TF_ExerciseId == id) > 0;
        }
        private TrueFalseModel trueFalseModel(TF_Exercise trueFalse)
        {
            TrueFalseModel current = new TrueFalseModel()
            {
                Puntuation = trueFalse.Puntuation,
                Answer = trueFalse.IsTrue
            };

            return current;
        }

        private UnitOfWork unitOfWork;
        private ApplicationDbContext db = new ApplicationDbContext();
    }
}
