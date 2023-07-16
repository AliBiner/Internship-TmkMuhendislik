using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using System.Web.Security;
using TmkMuhendislik.Bussiness;
using TmkMuhendislik.Models;

namespace TmkMuhendislik.Controllers
{
    
    public class AdminController : Controller
    {
        private Bussiness.Admin a = new Bussiness.Admin();
        private CRUD c = new CRUD();


        // GET: Admin
        [CustomActionFilter]
        public ActionResult Index()
        {
            var id = Convert.ToInt32(Session["Id"]);
            var model = a.ReadAdminInfoById(id);
            return View(model);
        }
        

       
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(AdminInfo info)
        {
            
                var control = a.AdminLoginControl(info);
                if (control==null)
                {

                    return View();

                }
                else
                {
                    FormsAuthentication.SetAuthCookie(control.A_Email,false);
                    Session["Id"] = control.A_Id.ToString();
                    Session["Name"] = control.A_Name.ToString();
                    Session["Surname"] = control.A_Surname.ToString();

                    return RedirectToAction("Index","Admin");
                }
           
            
        }
      
        public ActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Register(AdminInfo adminInfo)
        {
            if (!ModelState.IsValid)
            {
                return View();
               
            }
            else
            {
                var control = a.CreateAdmin(adminInfo);
                if (control == false)
                {
                    return View();
                }
                else
                {
                    return RedirectToAction("Login","Admin");
                }
            }

            
        }
        [CustomActionFilter]
        public ActionResult AdminCheckControl()
        {
            var model= a.ReadCheckAll();
            if (model==null)
            {
                return View();
            }
            else
            {
                return View(model);
            }
           
        }
        [CustomActionFilter]
        public ActionResult ApproveAdmin(int id)
        {
            a.ApproveAdminById(id);
            return RedirectToAction("AdminCheckControl");
        }
        [CustomActionFilter]
        public ActionResult DeclineAdmin (int id)
        {
            a.DeclineAdminById(id);
            return RedirectToAction("AdminCheckControl");
        }

        [CustomActionFilter]
        public ActionResult News()
        {
            var model=a.ReadNewsListAll();   
            return View(model);
        }
        [CustomActionFilter]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToActionPermanent("Login", "Admin");
        }

        [CustomActionFilter]
        public ActionResult Settings(int id)
        {
            if (id!=Convert.ToInt32(Session["Id"]))
            {
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                var model = a.ReadAdminInfoById(id);
                return View(model);
            }
            
        }
    }
}