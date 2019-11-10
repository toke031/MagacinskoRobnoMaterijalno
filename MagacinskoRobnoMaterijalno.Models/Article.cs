using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Models
{
    public class Article
    {
        public long ID { get; set; }
        public string ArticleNo { get; set; }
        public string Name { get; set; }
        public decimal QuantityItemPrice { get; set; }
        public int ArticleTypeID{ get; set; }
        public ICollection<DocumentItem> DocumentItems { get; set; }


    }
}
