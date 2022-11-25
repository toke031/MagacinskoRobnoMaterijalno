using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using MagacinskoRobnoMaterijalno.Data.Model;
using MagacinskoRobnoMaterijalno.Data.UnitOfWork;

namespace MagacinskoRobnoMaterijalno.Classes
{
    public class DocumentLogic
    {
        public DocumentLogic()
        {
        }

        internal void DeleteDocument(Document document)
        {
            using (UOW uow = new UOW())
            {
                uow.DocumentRepository.Delete(document);
                uow.Save();
            }
        }
        public void AddDocument(Document document)
        {
            using (UOW uow = new UOW())
            {
                uow.DocumentRepository.Insert(document);
                uow.Save();
            }
        }

        internal Document GetDocument(long id)
        {
            using (UOW uow = new UOW())
            {
                return uow.DocumentRepository.Find(x => x.ID == id, includeProperties: "DocumentItems, DocumentItems.Article, Client").FirstOrDefault();
            }
        }

        internal string GetLastNoForDoument(int year, int type)
        {
            using (UOW uow = new UOW())
            {
                return (uow.DocumentRepository.Find(x => x.DocumentType == type && x.DocumentDateTime.Year == year && (x.StatusID == 0 || x.StatusID == 1)).Count() + 1).ToString();
            }
        }

        public void Update(Document document)
        {
            using (UOW uow = new UOW())
            {
                foreach(var documentItem in document.DocumentItems)
                {
                    if(documentItem.ID == 0)
                    {
                        uow.DocumentItemRepository.Insert(documentItem);
                    }
                    else
                    {
             //           uow.DocumentItemRepository.Update(documentItem);
                    }
                }
                uow.DocumentRepository.Update(document);
                uow.Save();
            }
        }

        public void SaveAllChanges()
        {
            using (UOW uow = new UOW())
            {
                uow.Save();
            }
        }

        internal BindingList<Document> GetAllDocuments(Expression<Func<Document, bool>> filter = null)
        {
            using (UOW uow = new UOW())
            {
                var documents = uow.DocumentRepository.Find(filter, includeProperties: "Client").ToList();
                BindingList<Document> bindingListDocuments = new BindingList<Document>(documents);
                return bindingListDocuments;
            }
        }

        internal BindingList<Document> GetDocumentForLast30Days()
        {
            var thirtyDaysAgo = DateTime.Today.AddDays(-30);
            using(UOW uow = new UOW())
            {
                var documents = uow.DocumentRepository.Find(x => x.DocumentDateTime >= thirtyDaysAgo, includeProperties: "Client").ToList();
                BindingList<Document> bindingListDocuments = new BindingList<Document>(documents);
                return bindingListDocuments;
            }
        }
        internal BindingList<Document> GetAllDocumentsByDocumentType(int type)
        {
            using(UOW uow = new UOW())
            {
                var documents = uow.DocumentRepository.Find(x => x.DocumentType == type, includeProperties: "Client").ToList();
                BindingList<Document> bindingListDocuments = new BindingList<Document>(documents);
                return bindingListDocuments;
            }
        }

        public bool IsChangedChanged()
        {
            using (UOW uow = new UOW())
            {
                return uow.IsChangedChanged();
            }
        }

        internal BindingList<Document> SearchDocuments(Dictionary<string, string> listOfParams)
        {
            using (UOW uow = new UOW())
            {
               return uow.DocumentRepository.GetAllDocumentsForCcurrenParams(listOfParams);
            }
        }

        internal DataSet GetGroupByPriceForClient(long documentID)
        {
            using(UOW uow = new UOW())
            {
                var rows = uow.DocumentItemRepository.Find(x => x.DocumentID == documentID).ToList().GroupBy(x => x.ItemPrice).Select(x => new GroupByPrice() { StartWith = x.Key.ToString() + " eur" , Surface = (decimal)x.Sum(i => i.Surface)}).ToList();
                DataSet groupByPrice = new DataSet();
                groupByPrice.Tables.Add("groupByPrice");
                groupByPrice.Tables[0].Columns.Add("StartWith", typeof(string));
                groupByPrice.Tables[0].Columns.Add("Surface", typeof(decimal));

                foreach(var row in rows)
                {
                    DataRow dr = groupByPrice.Tables[0].Rows.Add();
                    dr.SetField("StartWith", row.StartWith);
                    dr.SetField("Surface", row.Surface);
                }
                return groupByPrice;
            }
             //return _docRepository.GetGroupByPriceForClient(documentID);
        }
    }
    
    public class GroupByPrice 
    {
        public string StartWith { get; set; }
        public decimal Surface { get; set; }
    }
}
