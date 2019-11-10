using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Models
{
    public class Document
    {
        public Document()
        {
            DocumentItems = new BindingList<DocumentItem>();
        }
        public long ID { get; set; }
        public string DocumentNo { get; set; }
        public int DocumentType { get; set; }
        public long ClientID { get; set; }
        public long WarehouseID { get; set; }
        public DateTime DocumentDateTime { get; set; }
        public DateTime PaymentEndDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public int EmployeeID { get; set; }
        public decimal TotalPrice { get; set; }

        [ForeignKey("ClientID")]
        public Client Client { get; set; }

        [ForeignKey("WarehouseID")]
        public Warehouse Warehouse { get; set; }
        public int StatusID { get; set; }
        public ICollection<DocumentItem> DocumentItems { get; set; }

    }
}
