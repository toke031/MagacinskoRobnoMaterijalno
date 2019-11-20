using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.ComponentModel;

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
            return _context.Documents.Include(x => x.Client).Include(b=>b.DocumentItems).Where(x => x.ID == iD).FirstOrDefault();
        }

        public string GetLastNoForDoument(int year, int typeId)
        {
            return (_context.Documents
                .Where(x => x.DocumentType == typeId)
                .Where(x => x.DocumentDateTime.Year == year)
                .Where(x => x.StatusID == 0 || x.StatusID == 1).Count() + 1).ToString();
        }

        public BindingList<Document> GetAllDocuments()
        {
                foreach (var entity in _context.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            _context.Documents.Include(x => x.Client).Load();
            return _context.Documents.Local.ToBindingList();
        }

        public bool IsChangedChanged()
        {
            foreach (var entity in _context.ChangeTracker.Entries())
            {
                var d = entity;//.Reload();

            }
                return _context.ChangeTracker.Entries().Any(e => e.State == EntityState.Added
                                              || e.State == EntityState.Modified
                                              || e.State == EntityState.Deleted);
        }
    }
}
