using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using EasyLearning.Service.Models;
using EasyLearning.Service.Models.DataBaseModels;
using EasyLearning.Service.Models.ServiceModels;
using Microsoft.AspNet.Identity;

namespace EasyLearning.Service.Controllers
{
    public class UserLanguagesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/UserLanguages/5
        public IHttpActionResult GetUserLanguages(string userId)
        {
            UserLanguages userLanguages = GetLanguagesOf(userId);
            if (userLanguages == null)
            {
                return NotFound();
            }

            return Ok(GetUserLanguagesModel(userLanguages));
        }

        // POST: api/UserLanguages
        [ResponseType(typeof(UserLanguageModel))]
        [HttpPost]
        public IHttpActionResult PostUserLanguages([FromBody]UserLanguageModel newUserLanguages)
        {
            string userId = newUserLanguages.User;
            UserLanguages userLanguages = GetLanguagesOf(userId);
            Language newlanguageToLearn = db.Languages.FirstOrDefault(l => l.LanguageId == newUserLanguages.LanguageTolearnId);
            if (userLanguages == null || newlanguageToLearn == null)
            {
                return NotFound();
            }
            userLanguages.LanguageToLearn = newlanguageToLearn;
            db.SaveChanges();

            return Ok(GetUserLanguagesModel(userLanguages));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserLanguagesExists(int id)
        {
            return db.UsersLanguages.Count(e => e.UserLanguagesId == id) > 0;
        }

        /// <summary>
        /// Gets the user languages model.
        /// </summary>
        /// <param name="userLanguages">The user languages.</param>
        /// <returns></returns>
        private UserLanguageModel GetUserLanguagesModel(UserLanguages userLanguages)
        {
            return new UserLanguageModel()
            {
                UserLanguageModelId = userLanguages.UserLanguagesId,
                NativeLanguage = userLanguages.NativeLanguage.Name,
                NativeLanguageId = userLanguages.NativeLanguage.LanguageId,
                LanguageTolearn = userLanguages.LanguageToLearn.Name
            };
        }

        /// <summary>
        /// Gets the languages of.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        private UserLanguages GetLanguagesOf(string userId)
        {
            return db.UsersLanguages.FirstOrDefault(ul => ul.User.Id == userId);
        }
    }
}