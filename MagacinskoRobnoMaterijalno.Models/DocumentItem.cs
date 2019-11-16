using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Models
{
   public class DocumentItem
   {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public long DocumentID { get; set; }
        [ForeignKey("DocumentID")]
        public Document Document { get; set; }
        public decimal ItemPrice { get; set; }
        public string ArticleNo { get; set; }

        public long ItemID { get; set; }
        //[ForeignKey("ItemID")]
      //  public Article Item { get; set; }
        public decimal Quantity { get; set; }
        public decimal QuantityItemPrice { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
    }
}
