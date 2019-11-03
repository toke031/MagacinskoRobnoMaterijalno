using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Models
{
    public class Client
    {
        [System.ComponentModel.Browsable(false)]
        public long ID { get; set; }

        [DisplayName("Naziv klijenta")]
        public string Name { get; set; }

        [DisplayName("PIB")]
        public string PIB { get; set; }

        [DisplayName("MB")]
        public string MB { get; set; }

        [DisplayName("Adresa")]
        public string Address { get; set; }

        [DisplayName("Broj računa")]
        public string BankAccount { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Telefon")]
        public string Phone { get; set; }

        [DisplayName("Fax")]
        public string PhoneFax { get; set; }
    }
}
