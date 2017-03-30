using EasyLearning.Models.ViewModel;
using System.Web.Mvc;

namespace EasyLearning.Controllers
{
    public class LessonController : Controller
    {
        /// <summary>
        /// Indexes the specified lesson number.
        /// </summary>
        /// <param name="lessonNumber">The lesson number.</param>
        /// <returns></returns>
        public ActionResult Index(LessonModel lesson)
        {
            return View("Lesson", lesson);
        }
    }
}