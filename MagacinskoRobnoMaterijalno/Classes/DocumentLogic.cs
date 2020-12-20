using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
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
                return uow.DocumentRepository.Find(x => x.ID == id, includeProperties: "DocumentItems, DocumentItems.Article").FirstOrDefault();
            }
        }

        internal string GetLastNoForDoument(int year, int type)
        {
            using (UOW uow = new UOW())
            {
                return (uow.DocumentRepository.Find(x => x.DocumentType == type && x.DocumentDateTime.Year == year && (x.StatusID == 0 || x.StatusID == 1)).Count() + 1).ToString();
            }
        }

        public void SaveAllChanges()
        {
            using (UOW uow = new UOW())
            {
                uow.Save();
            }
        }

        internal BindingList<Document> GetAllDocuments()
        {
            using (UOW uow = new UOW())
            {
                var documents = uow.DocumentRepository.Find(includeProperties: "Client").ToList();
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
            return null;
             //return _docRepository.GetGroupByPriceForClient(documentID);
        }
    }
}
