using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Data;

namespace MagacinskoRobnoMaterijalno.Models
{
    public class DocumentRepository
    {
        readonly MainDBContext _context;

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
            return _context.Documents.Include(x => x.Client).Include(b => b.DocumentItems).Include(c=>c.DocumentItems.Select(d=>d.Item)).Where(x => x.ID == iD).FirstOrDefault();
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

        public BindingList<Document> GetDocumentForLast30Days()
        {
            var ThirtyDaysAgo = DateTime.Today.AddDays(-30);
            foreach (var entity in _context.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            _context.Documents.Include(x => x.Client).Where(x=> System.Data.Entity.DbFunctions.TruncateTime(x.DocumentDateTime) >= ThirtyDaysAgo).Load();
            return _context.Documents.Local.ToBindingList();
        }

        public BindingList<Document> GetAllDocumentsByDocumentType(int type)
        {
            foreach (var entity in _context.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            _context.Documents.Where(x => x.DocumentType == type).Include(x => x.Client).Load();
            return new BindingList<Document>(_context.Documents.Local.Where(x => x.DocumentType == type).ToList());
        }

        public DataSet GetGroupByPriceForClient(long documentID)
        {
            string queryString =
              "select cast(di.ItemPrice as int) StartWith, sum(di.Surface) Surface from Documents d inner join DocumentItems di on d.ID = di.DocumentID where d.ID = "+ documentID + " group by di.ItemPrice";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, "data source=xInfluencers.database.windows.net;Initial Catalog=WarehouseManagement;Persist Security Info=False;User ID=xinfluencer;Password=43mADU(H-qe3kjH^W0@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            DataSet groupByPrice = new DataSet();
            groupByPrice.Tables.Add("groupByPrice");
            groupByPrice.Tables[0].Columns.Add("StartWith", typeof(decimal));
            groupByPrice.Tables[0].Columns.Add("Surface", typeof(decimal));
            adapter.Fill(groupByPrice.Tables[0]);
            return groupByPrice;
        }

        public BindingList<Document> GetAllDocumentsForCcurrenParams(Dictionary<string, string> listOfParams)
        {
            var ClientName = listOfParams.Where(l => l.Key == "Name").FirstOrDefault().Value;
            var DocumentStatus = listOfParams.Where(l => l.Key == "DocumentStatus").FirstOrDefault().Value;
            var DocumentType = listOfParams.Where(l => l.Key == "DocumentType").FirstOrDefault().Value;
            var CreatedDateFrom = DateTime.ParseExact(listOfParams.Where(l => l.Key == "CreatedDateFrom").FirstOrDefault().Value, "MM/dd/yyyy", null);
            var CreatedDateTo = DateTime.ParseExact(listOfParams.Where(l => l.Key == "CreatedDateTo").FirstOrDefault().Value, "MM/dd/yyyy", null);
            if (DocumentType == null && DocumentStatus == null)
            {
                return new BindingList<Document>(_context.Documents.Where(x => x.Client.Name.Contains(ClientName)
                && System.Data.Entity.DbFunctions.TruncateTime(x.DocumentDateTime) >= CreatedDateFrom
                && System.Data.Entity.DbFunctions.TruncateTime(x.DocumentDateTime) <= CreatedDateTo).ToList());
            }
            else if (DocumentStatus == null && DocumentType != null)
            {
                return new BindingList<Document>(_context.Documents.Where(x => x.Client.Name.Contains(ClientName)
                && x.DocumentType.ToString() == DocumentType
                && System.Data.Entity.DbFunctions.TruncateTime(x.DocumentDateTime) >= CreatedDateFrom
                && System.Data.Entity.DbFunctions.TruncateTime(x.DocumentDateTime) <= CreatedDateTo).ToList());
            }
            else if (DocumentType == null && DocumentStatus != null)
            {
                return new BindingList<Document>(_context.Documents.Where(x => x.Client.Name.Contains(ClientName)
                && x.StatusID.ToString() == DocumentStatus
                && System.Data.Entity.DbFunctions.TruncateTime(x.DocumentDateTime) >= CreatedDateFrom
                && System.Data.Entity.DbFunctions.TruncateTime(x.DocumentDateTime) <= CreatedDateTo).ToList());
            }
            else
            {
                return new BindingList<Document>(_context.Documents.Where(x => x.Client.Name.Contains(ClientName)
                && x.StatusID.ToString() == DocumentStatus
                && x.DocumentType.ToString() == DocumentType
                && System.Data.Entity.DbFunctions.TruncateTime(x.DocumentDateTime) >= CreatedDateFrom
                && System.Data.Entity.DbFunctions.TruncateTime(x.DocumentDateTime) <= CreatedDateTo).ToList());
            }
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
