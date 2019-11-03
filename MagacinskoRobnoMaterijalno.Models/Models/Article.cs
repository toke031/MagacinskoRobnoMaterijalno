using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Models.Models
{
    public class Article
    {
        public long ID { get; set; }
        public string ArticleNo { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set;}
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
