﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Models
{
   public class DocumentItem
    {
        public long ID { get; set; }
        public long ItemID { get; set; }
        public int DocumentID { get; set; }
        public decimal ItemPrice { get; set; }
        public string ItemName { get; set; }
        public int WareHouseID { get; set; }
        public int Quantity { get; set; }
        public decimal QuantityItemPrice { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
    }
}
