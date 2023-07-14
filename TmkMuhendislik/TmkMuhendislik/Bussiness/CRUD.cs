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
        public List<News> Control()
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

    }
}