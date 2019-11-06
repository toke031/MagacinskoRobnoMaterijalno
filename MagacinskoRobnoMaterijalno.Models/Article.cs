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
        [System.ComponentModel.Browsable(false)]
        public long ID { get; set; }


        [DisplayName("Sifra artikla")]
        public string ArticleNo { get; set; }

        [DisplayName("Naziv artikla")]
        public string Name { get; set; }

        [DisplayName("Jedinicna cena")]
        public decimal QuantityItemPrice { get; set; }

        public Warehouse Warehouse { get; set; }


    }
}
