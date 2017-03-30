using EasyLearning.Service.DAL;
using EasyLearning.Service.Models;
using EasyLearning.Service.Models.DataBaseModels;
using EasyLearning.Service.Models.ServiceModels;
using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;

namespace EasyLearning.Service.Controllers.EasyLearningController
{
    public class LessonProgressController : ApiController
    {
        public LessonProgressController()
        {
            unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Gets the lesson progress.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [ResponseType(typeof(LessonProgress))]
        public IHttpActionResult GetLessonProgress(int id)
        {
            LessonProgress lessonProgressFound = unitOfWork.LessonProgressRepository.GetByID(id);

            if (lessonProgressFound == null)
            {
                return NotFound();
            }

            return Ok(lessonProgressModel(lessonProgressFound));
        }

        /// <summary>
        /// Gets the lesson.
        /// </summary>
        /// <param name="lessonId">The lesson identifier.</param>
        /// <param name="UserId">The user identifier.</param>
        /// <returns></returns>
        [ResponseType(typeof(LessonProgress))]
        [HttpGet]
        public IHttpActionResult GetLessonProgressByUserId(int lessonId, string UserId)
        {
            var foundLessonProgress = db.ProgressByLessons.FirstOrDefault(f => f.Lesson.LessonId == lessonId && f.User.Id.Equals(UserId));

            if (foundLessonProgress == null)
            {
                return NotFound();
            }
            return Ok(lessonProgressModel(foundLessonProgress));
        }

        /// <summary>
        /// Posts the lesson progress.
        /// </summary>
        /// <param name="lessonProgress">The lesson progress.</param>
        /// <returns></returns>
        [ResponseType(typeof(LessonProgress))]
        public IHttpActionResult PostLessonProgress(LessonProgressModel lessonProgress)

        {
            if (!ModelState.IsValid && lessonProgress == null)
            {
                return BadRequest(ModelState);
            }
            var dbLessonProgress = new LessonProgress()
            {
                Percentage = lessonProgress.Percentage,
                TotalExerciseQuantity = lessonProgress.TotalExerciseQuantity,
                ExerciseSolvedQuantity = lessonProgress.ExerciseSolvedQuantity,
                Lesson = FindLanguage(lessonProgress.LessonId),
                User = FindUser(lessonProgress.UserId)
            };
            db.ProgressByLessons.Add(dbLessonProgress);
            db.SaveChanges();
            lessonProgress.LessonProgressId = dbLessonProgress.LessonProgressId;
            return CreatedAtRoute("DefaultApi", new { id = lessonProgress.LessonProgressId }, lessonProgress);
        } 
        
        /// <summary>
          /// Puts the lesson progress.
          /// </summary>
          /// <param name="id">The identifier.</param>
          /// <param name="trueFalse">The true false.</param>
          /// <returns></returns>
        public IHttpActionResult PutLessonProgress(int id, LessonProgressModel trueFalse)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");


            var existingLessonProgress = db.ProgressByLessons.FirstOrDefault(s => s.LessonProgressId == id);

            if (existingLessonProgress != null)
            {
                existingLessonProgress.Percentage = trueFalse.Percentage;
                existingLessonProgress.ExerciseSolvedQuantity = trueFalse.ExerciseSolvedQuantity;
                existingLessonProgress.TotalExerciseQuantity = trueFalse.TotalExerciseQuantity;
                db.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return Ok(trueFalse);
        }

        /// <summary>
        /// Lessons the progress model.
        /// </summary>
        /// <param name="lessonProgress">The lesson progress.</param>
        /// <returns></returns>
        private LessonProgressModel lessonProgressModel(LessonProgress lessonProgress)
        {
            LessonProgressModel current = new LessonProgressModel()
            {
                LessonProgressId = lessonProgress.LessonProgressId,
                Percentage = Convert.ToInt32(lessonProgress.Percentage),
                ExerciseSolvedQuantity = lessonProgress.ExerciseSolvedQuantity,
                TotalExerciseQuantity = lessonProgress.TotalExerciseQuantity,
                LessonId = lessonProgress.Lesson.LessonId,
                UserId = lessonProgress.User.Id
            };

            return current;
        }

        /// <summary>
        /// Finds the language.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        private Lesson FindLanguage(int id)
        {
            return db.Lessons.Find(id);
        }

        /// <summary>
        /// Finds the user.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        private ApplicationUser FindUser(string userId)
        {
            return db.Users.Find(userId);
        }

        private UnitOfWork unitOfWork;
        private ApplicationDbContext db = new ApplicationDbContext();
    }
}
