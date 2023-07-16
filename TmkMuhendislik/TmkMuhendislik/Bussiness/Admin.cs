using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TmkMuhendislik.Models;

namespace TmkMuhendislik.Bussiness
{
    public class Admin
    {
        private readonly TmkMuhendislikEntities db = new TmkMuhendislikEntities();
        
        public bool CreateAdmin(AdminInfo adminInfo)
        {

            adminInfo.A_CreateDate = CreateDateNow();
            db.AdminInfoes.Add(adminInfo);
            db.SaveChanges();
            var control = db.AdminInfoes.Where(x => x.A_Id == adminInfo.A_Id).FirstOrDefault();
            if (control == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public string CreateDateNow()
        {
            DateTime dt = DateTime.Now;
            string date = Convert.ToString(dt);
            return date;
        }

        public AdminInfo AdminLoginControl(AdminInfo info)
        {
            var control = db.AdminInfoes.Where(x =>
                x.A_Email == info.A_Email && x.A_Password == info.A_Password && x.A_Check == true).FirstOrDefault();
            if (control == null)
            {
                return null;
            }
            else
            {
                return control;
            }
        }

        public AdminInfo ReadAdminInfoById(int id)
        {
            var model = db.AdminInfoes.Where(x => x.A_Id == id).FirstOrDefault();
            return model;
        }

        public List<AdminInfo> ReadCheckAll()
        {
            var model = db.AdminInfoes.Where(x=>x.A_Check==null).ToList();
            if (model==null)
            {
                return null;
            }
            else
            {
                return model;
            }
            
        }

        public void DeclineAdminById(int id)
        {
            var admin = db.AdminInfoes.Where(x => x.A_Id == id).FirstOrDefault();
            admin.A_Check = false;
            db.Entry(admin).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void ApproveAdminById(int id)
        {
            var admin = db.AdminInfoes.Where(x => x.A_Id == id).FirstOrDefault();
            admin.A_Check = true;
            db.Entry(admin).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void DeclineNewsById(int id)
        {
            var news = db.News.Where(x => x.N_Id == id).FirstOrDefault();
            news.N_Check = false;
            db.Entry(news).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void ApproveNewsById(int id)
        {
            var news = db.News.Where(x => x.N_Id == id).FirstOrDefault();
            news.N_Check = true;
            db.Entry(news).State = EntityState.Modified;
            db.SaveChanges();
        }

        public List<News> ReadNewsListAll()
        {
            var model = db.News.ToList();
            return model;
        }

    }
}