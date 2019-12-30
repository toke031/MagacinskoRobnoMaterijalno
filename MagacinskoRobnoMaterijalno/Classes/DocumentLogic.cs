using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagacinskoRobnoMaterijalno.Models;

namespace MagacinskoRobnoMaterijalno.Classes
{
    public class DocumentLogic
    {
        private DocumentRepository _docRepository;
        public DocumentLogic()
        {
            _docRepository = new DocumentRepository();
        }

        internal void DeleteDocument(Document document)
        {
            _docRepository.DeleteDocument(document);
        }
        public bool SaveAllChanges()
        {
            return _docRepository.SaveChanges();
        }
        public void AddDocument(Document document)
        {
            _docRepository.AddDocument(document);
        }

        internal Document GetDocument(long iD)
        {
            return _docRepository.GetDocument(iD);
        }

        internal string GetLastNoForDoument(int year, int type)
        {
            return _docRepository.GetLastNoForDoument(year, type);
        }

        internal BindingList<Document> GetAllDocuments()
        {
            return _docRepository.GetAllDocuments();
        }
        internal BindingList<Document> GetAllDocumentsByDocumentType(int type)
        {
            return _docRepository.GetAllDocumentsByDocumentType(type);
        }
        public bool IsChangedChanged()
        {
            return _docRepository.IsChangedChanged();
        }

        internal BindingList<Document> SearchDocuments(Dictionary<string, string> listOfParams)
        {
            return _docRepository.GetAllDocumentsForCcurrenParams(listOfParams);
        }

        internal DataSet GetGroupByPriceForClient(long documentID)
        {
             return _docRepository.GetGroupByPriceForClient(documentID);
        }
    }
}
