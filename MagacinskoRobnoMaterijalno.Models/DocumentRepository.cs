using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Models
{
    public class DocumentRepository
    {
        MainDBContext _context;

        public DocumentRepository()
        {
            _context = new MainDBContext();
        }
        public void DeleteDocument(Document itemForDelete)
        {
            _context.Documents.Remove(itemForDelete);
        }
        public void AddDocument(Document item)
        {
            _context.Documents.Add(item);
        }
        public bool SaveChanges()
        {
            return _context.SaveAllChanges();
        }

        public Document GetDocument(long iD)
        {
            return _context.Documents.FirstOrDefault(x => x.ID == iD);
        }

        public string GetLastNoForDoument(int year, int typeId)
        {
            return (_context.Documents
                .Where(x => x.DocumentType == typeId)
                .Where(x => x.DocumentDateTime.Year == year)
                .Where(x => x.StatusID == 0 || x.StatusID == 1).Count() + 1).ToString();
        }

        public List<Document> GetAllDocuments()
        {
            return _context.Documents.ToList();
        }
    }
}
