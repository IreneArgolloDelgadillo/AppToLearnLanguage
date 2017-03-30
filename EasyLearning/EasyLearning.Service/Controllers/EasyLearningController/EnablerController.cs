using System.Web.Http;

namespace EasyLearning.Service.Controllers.EasyLearningController
{
    //TODO: Class provitional Integrate with progressController
    public class EnablerController : ApiController
    {
        // GET: Enabler
        [HttpGet]
        public IHttpActionResult GetCurrentProgress(int id)
        {
            //TODO: get from database 
            int currentProgress = 81;
            return Ok(currentProgress);
        }
    }
}