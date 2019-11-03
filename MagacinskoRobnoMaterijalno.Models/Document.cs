using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Models
{
    public class Document
    {
        public long ID { get; set; }
        public string DocumentNo { get; set; }
        public string DocumentType { get; set; }
        public long ClientID { get; set; }
        public DateTime DocumentDateTime { get; set; }
        public DateTime PaymentEndDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public int EmployeeID { get; set; }
        public int TotalPrice { get; set; }

    }
}
