using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TmkMuhendislik.Models;

namespace TmkMuhendislik.Bussiness
{
    public class CRUD
    {
        private TmkMuhendislikEntities db = new TmkMuhendislikEntities();
        public List<News> Read()
        {
            var controls = db.News.Where(x=>x.N_Check==true).ToList();
            if (controls==null)
            {
                return null;
            }
            else
            {
                return controls;
            }
        }

        public News ReadById(int id)
        {
            var news = db.News.Where(x => x.N_Id == id).FirstOrDefault();
            return news;
        }

    }
}