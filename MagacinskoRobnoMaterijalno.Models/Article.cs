﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Models
{
    public class Article
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public string ArticleNo { get; set; }
        public string Name { get; set; }
        public decimal ItemPrice { get; set; }
        public int ArticleTypeID{ get; set; }
     //   public ICollection<DocumentItem> DocumentItems { get; set; }

        public Article()
        {
    //        DocumentItems = new BindingList<DocumentItem>();
        }
    }
}
