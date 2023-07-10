using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TmkMuhendislik.RandomData;

namespace TmkMuhendislik.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        
        public ActionResult Home()
        {
            //String[] dizi = RandomDataNavbar.RndCount(12);
            
           
            return View();
        }

    }
}