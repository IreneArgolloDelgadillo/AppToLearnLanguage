using EasyLearning.Service.Models;
using EasyLearning.Service.Models.DataBaseModels;
using System.Linq;
using System.Web.Http;

namespace EasyLearning.Service.Controllers.EasyLearningController
{
    public class LessonContentController : ApiController
    {
        /// <summary>
        /// Gets the number of content lessons by lesson.
        /// </summary>
        /// <param name="lessonId">The lesson identifier.</param>
        /// <returns></returns>
        public IHttpActionResult GetNumberOfContentLessonsByLesson(int lessonId)
        {
            var contentLessons = DB.LessonContents.Where(l => l.Lesson.LessonId.Equals(lessonId)).ToList();
            return Ok(contentLessons.Count);
        }

        private ApplicationDbContext DB = new ApplicationDbContext();
    }
}