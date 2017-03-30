using EasyLearning.ClientRest;
using EasyLearning.Models.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EasyLearning.Controllers
{
    public class UserLanguagesController : Controller
    {
        /// <summary>
        /// The rest client
        /// </summary>
        private Client client = new Client();

        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(string userId)
        {
            UserLanguagesModel userLanguages = client.GetUserLanguages(userId);
            IList<SelectListItem> listItems = new List<SelectListItem>();
            foreach(var language in client.GetLanguagesToLearn(userId))
            {
                listItems.Add(new SelectListItem
                {
                    Text = language.Name,
                    Value = language.LanguageId.ToString()
                });
            }
            ViewBag.Languages = listItems;
            return View("Index", userLanguages);
        }

        /// <summary>
        /// Indexes the specified user languages.
        /// </summary>
        /// <param name="newLanguage">The user languages.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(UserLanguagesModel newLanguage)
        {
            client.SaveUserLanguageChange(newLanguage);
            return View("ChangeSucces");
        }
    }
}