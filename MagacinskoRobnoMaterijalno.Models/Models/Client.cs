using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Models.Models
{
    public class Client
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string PIB { get; set; }
        public string MB { get; set; }
        public string Address { get; set; }
        public string BankAccount { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PhoneFax { get; set; }
    }
}
