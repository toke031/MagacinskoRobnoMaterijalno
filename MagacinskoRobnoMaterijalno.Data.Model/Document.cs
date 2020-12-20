//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MagacinskoRobnoMaterijalno.Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Document
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Document()
        {
            this.DocumentItems = new HashSet<DocumentItem>();
        }
    
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
    
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentItem> DocumentItems { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}