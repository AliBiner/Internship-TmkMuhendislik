using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TmkMuhendislik.Bussiness;
using TmkMuhendislik.Models;

namespace TmkMuhendislik.Controllers
{
    
    public class NewsController : Controller
    {
        private CRUD c = new CRUD();
        // GET: News
        public ActionResult Index()
        {
            var model = c.Read();

            return View(model);
        }
        
        public ActionResult Detail(int id)
        {
            var model = c.ReadById(id);
            return View(model);
        }


    }
}