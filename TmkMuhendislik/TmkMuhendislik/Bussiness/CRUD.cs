using System;
using System.Collections.Generic;
using System.Linq;
using TmkMuhendislik.Models;

namespace TmkMuhendislik.Bussiness
{
    public class CRUD
    {
        private readonly TmkMuhendislikEntities db = new TmkMuhendislikEntities();

        public List<News> ReadNews()
        {
            var controls = db.News.Where(x => x.N_Check == true).ToList();
            if (controls == null)
                return null;
            return controls;
        }

        public News ReadNewsById(int id)
        {
            var news = db.News.Where(x => x.N_Id == id).FirstOrDefault();
            if (news == null)
                return null;
            if (news.N_Check == false)
                return null;
            return news;
        }

     
    }
}