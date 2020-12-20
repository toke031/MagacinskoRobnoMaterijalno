using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Models
{
    public class DocumentModel
    {
        public long ID { get; set; }
        public string DocumentNo { get; set; }
        public int DocumentType { get; set; }
        public System.DateTime DocumentDateTime { get; set; }
        public System.DateTime PaymentEndDate { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public int EmployeeID { get; set; }
        public decimal TotalPrice { get; set; }
        public long ClientID { get; set; }
        public long WarehouseID { get; set; }
        public int StatusID { get; set; }
        public string LinkDocumentNo { get; set; }
    }
}
