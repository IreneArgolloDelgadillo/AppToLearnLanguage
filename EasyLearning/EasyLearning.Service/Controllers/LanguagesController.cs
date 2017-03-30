using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using EasyLearning.Service.Models;
using EasyLearning.Service.Models.DataBaseModels;

namespace EasyLearning.Service.Controllers
{
    public class LanguagesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Languages
        public IQueryable<Language> GetLanguages()
        {
            return db.Languages;
        }

        /// <summary>
        /// Gets the languages.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        public IQueryable<Language> GetLanguages(string user)
        {
            UserLanguages userLanguages = db.UsersLanguages.Where(ul => ul.User.Id == user).FirstOrDefault();
            return db.Languages.Where(l => (l.LanguageId != userLanguages.NativeLanguage.LanguageId)
                                        && (l.LanguageId != userLanguages.LanguageToLearn.LanguageId));
        }

        // GET: api/Languages/5
        [ResponseType(typeof(Language))]
        public IHttpActionResult GetLanguage(int id)
        {
            Language language = db.Languages.Find(id);
            if (language == null)
            {
                return NotFound();
            }

            return Ok(language);
        }

        // PUT: api/Languages/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLanguage(int id, Language language)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != language.LanguageId)
            {
                return BadRequest();
            }

            db.Entry(language).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LanguageExists(id))
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

        // POST: api/Languages
        [ResponseType(typeof(Language))]
        public IHttpActionResult PostLanguage(Language language)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Languages.Add(language);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = language.LanguageId }, language);
        }

        // DELETE: api/Languages/5
        [ResponseType(typeof(Language))]
        public IHttpActionResult DeleteLanguage(int id)
        {
            Language language = db.Languages.Find(id);
            if (language == null)
            {
                return NotFound();
            }

            db.Languages.Remove(language);
            db.SaveChanges();

            return Ok(language);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LanguageExists(int id)
        {
            return db.Languages.Count(e => e.LanguageId == id) > 0;
        }
    }
}