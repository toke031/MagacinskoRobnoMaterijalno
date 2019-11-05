using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Models
{
    public class Warehouse
    {
        [System.ComponentModel.Browsable(false)]
        public long ID { get; set; }

        [DisplayName("ID tipa magacina")]
        public int WarehouseTypeID { get; set; }

        [DisplayName("Sifra magacina")]
        public string WarehouseNo { get; set; }

        [DisplayName("Naziv magacina")]
        public string Name { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
