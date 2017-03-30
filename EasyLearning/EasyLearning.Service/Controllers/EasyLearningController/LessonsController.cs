using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using EasyLearning.Service.Models;
using EasyLearning.Service.Models.DataBaseModels;
using System.Collections.Generic;
using EasyLearning.Service.Models.ServiceModels;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Net;

namespace EasyLearning.Service.Controllers.EasyLearningControllers
{
    public class LessonsController : ApiController
    {
        // GET: api/Lessons
        public IQueryable<Lesson> GetLessonsByLevel()
        {
            return DB.Lessons;
        }

        public IHttpActionResult GetLessonsByLevel(int levelId)
        {
            IList<LessonModel> lessons = new List<LessonModel>();
            var lessonsByLevel = DB.Levels.
                Join(DB.Lessons,
                le => le.LevelId,
                ls => ls.Level.LevelId,
                (le, ls) => new LessonModel
                {
                    LessonId = ls.LessonId,
                    Title = ls.Title,
                    OrderByLevel = ls.OrderByLevel,
                    LevelId = le.LevelId
                }
                )
                .Where(le => le.LevelId.Equals(levelId)).ToList();
            foreach (LessonModel lesson in lessonsByLevel)
            {
                lessons.Add(lesson);
            }
            return Ok(lessons);
        }

        // GET: api/Lessons/5
        [ResponseType(typeof(Lesson))]
        public async Task<IHttpActionResult> GetLesson(int id)
        {
            Lesson lesson = await DB.Lessons.FindAsync(id);
            if (lesson == null)
            {
                return NotFound();
            }
            return Ok(lesson);
        }

        // PUT: api/Lessons/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLesson(int id, Lesson lesson)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lesson.LessonId)
            {
                return BadRequest();
            }

            DB.Entry(lesson).State = EntityState.Modified;

            try
            {
                await DB.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LessonExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Lessons
        [ResponseType(typeof(Lesson))]
        public async Task<IHttpActionResult> PostLesson(Lesson lesson)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DB.Lessons.Add(lesson);
            await DB.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = lesson.LessonId }, lesson);
        }

        // DELETE: api/Lessons/5
        [ResponseType(typeof(Lesson))]
        public async Task<IHttpActionResult> DeleteLesson(int id)
        {
            Lesson lesson = await DB.Lessons.FindAsync(id);
            if (lesson == null)
            {
                return NotFound();
            }

            DB.Lessons.Remove(lesson);
            await DB.SaveChangesAsync();

            return Ok(lesson);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                DB.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private bool LessonExists(int id)
        {
            return DB.Lessons.Count(e => e.LessonId == id) > 0;
        }

        private ApplicationDbContext DB = new ApplicationDbContext();
    }
}