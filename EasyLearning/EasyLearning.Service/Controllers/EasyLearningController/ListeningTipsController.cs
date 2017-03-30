using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using EasyLearning.Service.Models;
using EasyLearning.Service.Models.DataBaseModels;

namespace EasyLearning.Service.Controllers.EasyLearningControllers
{
    public class ListeningTipsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/ListeningTips
        public IQueryable<ListeningTip> GetListeningTips()
        {
            return db.ListeningTips;
        }

        // GET: api/ListeningTips/5
        [ResponseType(typeof(ListeningTip))]
        public async Task<IHttpActionResult> GetListeningTip(int id)
        {
            ListeningTip listeningTip = await db.ListeningTips.FindAsync(id);
            if (listeningTip == null)
            {
                return NotFound();
            }
            return Ok(listeningTip);
        }

        // PUT: api/ListeningTips/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutListeningTip(int id, ListeningTip listeningTip)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != listeningTip.ListeningTipId)
            {
                return BadRequest();
            }

            db.Entry(listeningTip).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListeningTipExists(id))
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

        // POST: api/ListeningTips
        [ResponseType(typeof(ListeningTip))]
        public async Task<IHttpActionResult> PostListeningTip(ListeningTip listeningTip)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ListeningTips.Add(listeningTip);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = listeningTip.ListeningTipId }, listeningTip);
        }

        // DELETE: api/ListeningTips/5
        [ResponseType(typeof(ListeningTip))]
        public async Task<IHttpActionResult> DeleteListeningTip(int id)
        {
            ListeningTip listeningTip = await db.ListeningTips.FindAsync(id);
            if (listeningTip == null)
            {
                return NotFound();
            }

            db.ListeningTips.Remove(listeningTip);
            await db.SaveChangesAsync();

            return Ok(listeningTip);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ListeningTipExists(int id)
        {
            return db.ListeningTips.Count(e => e.ListeningTipId == id) > 0;
        }
    }
}