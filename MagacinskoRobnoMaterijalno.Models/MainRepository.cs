using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Models
{
   public class MainRepository
    {
        MainDBContext _context;
        public MainRepository()
        {
            _context = new MainDBContext();
        }
        public BindingList<Article> GetArticles() 
        {
            _context.Articles.Load();
            return _context.Articles.Local.ToBindingList();
        }

        public BindingList<Warehouse> GetWarehouseByTypeID(int typeID)
        {
            _context.Warehouses.Where(x => x.WarehouseTypeID == typeID).Load();
            return _context.Warehouses.Local.ToBindingList();
        }

        public BindingList<Article> GetArticlesForWarehouse(Warehouse warehouse)
        {
            //_context.Articles.Where(x => x.Warehouse.ID == warehouse.ID).Load();
            //return _context.Articles.Local.ToBindingList();
            return null;
        }

        public BindingList<Warehouse> GetAllWarehouse()
        {
            _context.Warehouses.Load();
            return _context.Warehouses.Local.ToBindingList();
        }

        public List<Article> GetArticlesByName(string articleName) 
        {
           return _context.Articles.Where(x=>x.ArticleNo.Contains(articleName)).ToList();
        }
        public Article GetArticleByArticleNo (string articleNo)
        {
            return _context.Articles.Where(x => x.ArticleNo == articleNo).FirstOrDefault();
        }

        public BindingList<Article> GetArticlesByArticleNo(string articleNo)
        {
            return new BindingList<Article>(_context.Articles.Where(x => x.ArticleNo.StartsWith(articleNo)).ToList());
        }

        public void EditClient(Client client)
        {
            _context.Clients.Add(client);
            _context.Entry(client).State = System.Data.Entity.EntityState.Modified;
        }

        public BindingList<Article> GetArticlesByWarehouseType(int warehouseType)
        {
          //  _context.Articles.Where(x => x.ArticleTypeID == warehouseType).Load();
            BindingList<Article> b = new BindingList<Article>(_context.Articles.Where(x => x.ArticleTypeID == warehouseType).ToList());
            return b;//.Where(x => x.ArticleTypeID == warehouseType);
        }

        public bool IfExists(string articleNo)
        {
            return _context.Articles.Any(x => x.ArticleNo == articleNo);
        }

        public Client GetClientByClientPIB(string PIB)
        {
            return _context.Clients.Where(x => x.PIB == PIB).FirstOrDefault();
        }

        public void DeleteClient(Client itemForDelete)
        {
            _context.Clients.Remove(itemForDelete);
        }

        public void EditArticle(Article article)
        {
            _context.Articles.Add(article);
            _context.Entry(article).State = System.Data.Entity.EntityState.Modified;
        }

        public List<Article> GetArticleByName(string name)
        {
            return _context.Articles.Where(x => x.Name.Contains(name)).ToList();
        }

        public List<Client> GetClientByName(string name)
        {
            return _context.Clients.Where(x => x.Name.Contains(name)).ToList();
        }

        public void AddArticle(Article article)
        {
             _context.Articles.Add(article);
        }

        public BindingList<Client> GetClients()
        {
            _context.Clients.Load();
            return _context.Clients.Local.ToBindingList();
        }

        public void DeleteArticle(Article itemForDelete)
        {
            _context.Articles.Remove(itemForDelete);
            _context.SaveAllChanges();
        }

        public void AddClient(Client client)
        {
            _context.Clients.Add(client);
        }
        public bool SaveChanges()
        { 
            return _context.SaveAllChanges();
        }

        public void AddDocument(Document doc)
        {
            _context.Documents.Add(doc);
        }

    }
}
