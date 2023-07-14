using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TmkMuhendislik.Bussiness;

namespace TmkMuhendislik.Controllers
{
    
    public class NewsController : Controller
    {
        private CRUD c = new CRUD();
        // GET: News
        public ActionResult Index()
        {
            var model = c.Control();

            return View(model);
        }

        public ActionResult Detail()
        {
            return View();
        }


    }
}