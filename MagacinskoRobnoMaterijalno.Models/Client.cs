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
    public class Client
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public string Name { get; set; }
        public string PIB { get; set; }
        public string MB { get; set; }
        public string Address { get; set; }
        public string BankAccount { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PhoneFax { get; set; }
      //  public ICollection<Document> Documents { get; set; }
        public Client()
        {
        //    Documents = new BindingList<Document>();
        }
    }
}
