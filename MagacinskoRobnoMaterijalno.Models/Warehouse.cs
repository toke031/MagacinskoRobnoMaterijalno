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
        public long ID { get; set; }
        public int WarehouseTypeID { get; set; }
        public string WarehouseNo { get; set; }
        public string Name { get; set; }
    }
}
