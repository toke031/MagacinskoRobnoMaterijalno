using Models.Contexts;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Repositories
{
   public class MainRepository
    {
        public List<Article> GetArticles() 
        {
            MainDBContext mainDBContext = new MainDBContext();
            return mainDBContext.Articles.ToList();
        }
    }
}
