using MagacinskoRobnoMaterijalno.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Data.Repository
{
   public class DocumentRepository : Repository<Document>
    {
        public DocumentRepository(MagacinskoRobnoMaterijalnoDbContext dbContext) : base(dbContext)
        {

        }

        public BindingList<Document> GetAllDocumentsForCcurrenParams(Dictionary<string, string> listOfParams)
        {
            var ClientName = listOfParams.Where(l => l.Key == "Name").FirstOrDefault().Value;
            var DocumentStatus = listOfParams.Where(l => l.Key == "DocumentStatus").FirstOrDefault().Value;
            var DocumentType = listOfParams.Where(l => l.Key == "DocumentType").FirstOrDefault().Value;
            var CreatedDateFrom = DateTime.ParseExact(listOfParams.Where(l => l.Key == "CreatedDateFrom").FirstOrDefault().Value, "MM/dd/yyyy", null);
            var CreatedDateTo = DateTime.ParseExact(listOfParams.Where(l => l.Key == "CreatedDateTo").FirstOrDefault().Value, "MM/dd/yyyy", null);
            IQueryable<Document> query = dbSet;

            query = query.Where(x => x.Client.Name.Contains(ClientName) && x.DocumentDateTime >= CreatedDateFrom && x.DocumentDateTime <= CreatedDateTo);
            if(DocumentType != null)
            {
                query = query.Where(x => x.DocumentType.ToString() == DocumentType);
            }

            if(DocumentStatus != null)
            {
                query = query.Where(x => x.StatusID.ToString() == DocumentStatus);
            }

            var documents = query.ToList();
            BindingList<Document> bindingListDocuments = new BindingList<Document>(documents);
            return bindingListDocuments;
        }
    }
}
