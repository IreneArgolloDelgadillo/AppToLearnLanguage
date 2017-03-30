using EasyLearning.Models.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EasyLearning.Controllers.ViewController
{
    public class LessonsByLevelController : Controller
    {
        /// <summary>
        /// Indexes the specified level.
        /// </summary>
        /// <param name="level">The level.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult GetLessons(object lessons)
        {
            return View("LessonByLevel", lessons);
        }
    }
}

