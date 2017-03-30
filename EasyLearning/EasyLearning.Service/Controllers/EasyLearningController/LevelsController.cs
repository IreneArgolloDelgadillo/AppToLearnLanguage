using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using EasyLearning.Service.Models;
using EasyLearning.Service.DAL;
using EasyLearning.Service.Models.DataBaseModels;

namespace EasyLearning.Service.Controllers.EasyLearningControllers
{
    /// <summary>
    /// LevelsController manages the levels and implements the CRUD operations in order to communicate with the database. 
    /// </summary>
    public class LevelsController : ApiController
    {
        public LevelsController()
        {
            unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Gets the levels.
        /// GET: api/Levels
        /// </summary>
        /// <returns>All levels that found in database</returns>
        public IHttpActionResult GetLevels()
        {
            var levels = db.Levels;
            return Ok(levels);
        }

        /// <summary>
        /// Gets the level.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A level by Id of level</returns>
        [ResponseType(typeof(Level))]
        public IHttpActionResult GetLevel(int id)
        {
            return Ok(db.Levels.Find(id));
        }

        /// <summary>
        /// Get the levels by an language.
        /// It needs an languageID.
        /// </summary>
        /// <param name="languageId"></param>
        /// <returns></returns>
        public IHttpActionResult GetLevelsByLanguage(string user)
        {
            UserLanguages ul = db.UsersLanguages.Where(u => u.User.Id == user).FirstOrDefault();
            var foundLevels = db.Levels.Where(l => ((l.BelongsLanguage.LanguageId == ul.NativeLanguage.LanguageId)
                                                    && (l.LanguageToLearn.LanguageId == ul.LanguageToLearn.LanguageId)))
                                                    .OrderBy(l => l.OrderByDifficulty);
            return Ok(foundLevels);
        }

        // PUT: api/Levels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLevel(int id, Level level)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != level.LevelId)
            {
                return BadRequest();
            }

            db.Entry(level).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LevelExists(id))
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

        // POST: api/Levels
        [ResponseType(typeof(Level))]
        public async Task<IHttpActionResult> PostLevel(Level level)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Levels.Add(level);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = level.LevelId }, level);
        }

        // DELETE: api/Levels/5
        [ResponseType(typeof(Level))]
        public async Task<IHttpActionResult> DeleteLevel(int id)
        {
            Level level = await db.Levels.FindAsync(id);
            if (level == null)
            {
                return NotFound();
            }

            db.Levels.Remove(level);
            await db.SaveChangesAsync();

            return Ok(level);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LevelExists(int id)
        {
            return db.Levels.Count(e => e.LevelId == id) > 0;
        }

        private UnitOfWork unitOfWork;
        private ApplicationDbContext db = new ApplicationDbContext();
    }
}