using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using MagacinskoRobnoMaterijalno.Data.Model;
using MagacinskoRobnoMaterijalno.Data.UnitOfWork;

namespace MagacinskoRobnoMaterijalno.Classes
{
   public class ArticalLogic
    {
        public ArticalLogic() 
        {

        }

        public BindingList<Article> GetAllArticles() 
        {
            List<Article> articles= new List<Article>();
            using (UOW uow = new UOW())
            {
                articles = uow.ArticleRepository.Find().ToList();
            }
            BindingList<Article> bindingListArticles = new BindingList<Article>(articles);
            return bindingListArticles;

        }

        public int AddArtical(Article article)
        {
            using(UOW uow = new UOW())
            {
                uow.ArticleRepository.Insert(article);
                return uow.Save();
            }
        }

        public Article GetArticleByArticleNo(string articleNo)
        {
            using (UOW uow = new UOW())
            {
                return uow.ArticleRepository.Find(x => x.ArticleNo == articleNo).FirstOrDefault();
            } 
        }
        public BindingList<Article> GetArticlesByArticleNo(string articleNo)
        {
            using (UOW uow = new UOW())
            {
                var articles = uow.ArticleRepository.Find(x => x.ArticleNo.StartsWith(articleNo)).ToList();
                BindingList<Article> bidingListArticles = new BindingList<Article>(articles);
                return bidingListArticles;
            }
        }

        public void DeleteArticle(Article itemForDelete)
        {
            using (UOW uow = new UOW())
            {
                uow.ArticleRepository.Delete(itemForDelete);
                uow.Save();
            }
        }

        internal int EditArticle(Article article)
        {
            using (UOW uow = new UOW())
            {
                uow.ArticleRepository.Update(article);
                return uow.Save();
            }
        }

        internal List<Article> GetArticleByName(string name)
        {
            using(UOW uow = new UOW())
            {
                return uow.ArticleRepository.Find(x => x.Name.Contains(name)).ToList();
            }
        }

        internal BindingList<Article> GetAllArticlesByWarehouseType(int warehouseType)
        {
            using (UOW uow = new UOW())
            {
                var articles = uow.ArticleRepository.Find(x => x.ArticleTypeID == warehouseType).ToList();
                BindingList<Article> bindingListArticles = new BindingList<Article>(articles);
                return bindingListArticles;
            }
        }

        internal bool IfExists(string articleNo)
        {
            using(UOW uow = new UOW())
            {
                return uow.ArticleRepository.Find(x => x.ArticleNo == articleNo).Any();
            }
        }
    }
}
