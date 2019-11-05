using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagacinskoRobnoMaterijalno.Models;

namespace MagacinskoRobnoMaterijalno.Classes
{
   public class ArticalLogic
    {
        private MainRepository _mainRepository;
        public ArticalLogic() 
        {
            _mainRepository = new MainRepository();
        }

        public BindingList<Article> GetAllArticles() 
        {
            return _mainRepository.GetArticles();
        }
        public BindingList<Article> GetAllArticlesForWarehouse(Warehouse warehouse)
        {
            return _mainRepository.GetArticlesForWarehouse(warehouse);
        }

        public void AddArtical(Article article)
        {
            _mainRepository.AddArticle(article);
        }

        public bool SaveAllChanges()
        {
            return _mainRepository.SaveChanges();
        }

        public Article GetArticlesByArticleNo(string articleNo)
        {
            return _mainRepository.GetArticlesByArticleNo(articleNo);
        }

        public List<Article> GetArticlesByName(string articalName)
        {
            return _mainRepository.GetArticlesByName(articalName);
        }

        public void DeleteArticle(Article itemForDelete)
        {
            _mainRepository.DeleteArticle(itemForDelete);
        }

        internal void EditArticle(Article article)
        {
            _mainRepository.EditArticle(article);
        }

        internal List<Article> GetArticleByName(string name)
        {
            return _mainRepository.GetArticleByName(name);
        }

    }
}
