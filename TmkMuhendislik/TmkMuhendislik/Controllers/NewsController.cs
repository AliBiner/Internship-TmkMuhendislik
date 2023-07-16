using System.Web.Mvc;
using TmkMuhendislik.Bussiness;

namespace TmkMuhendislik.Controllers
{
    public class NewsController : Controller
    {
        private readonly CRUD c = new CRUD();

        // GET: News
        public ActionResult Index()
        {
            var model = c.ReadNews();

            return View(model);
        }

        public ActionResult Detail(int id)
        {
            var model = c.ReadNewsById(id);
            return View(model);
        }
    }
}