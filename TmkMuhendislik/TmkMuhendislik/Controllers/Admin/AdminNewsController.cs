using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TmkMuhendislik.Controllers.Admin
{
    public class AdminNewsController : Controller
    {
        private Bussiness.Admin admin = new Bussiness.Admin();

        public ActionResult CreateNews(int id)
        {

            return View();
        }

        public ActionResult RealeseNews(int id)
        {
            admin.ApproveNewsById(id);
            return RedirectToAction("News", "Admin");
        }
        public ActionResult DispatchNews(int id)
        {
            admin.DeclineNewsById(id);
            return RedirectToAction("News", "Admin");
        }
    }
}