using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Classes
{
    public class Lib
    {
        public enum StatusEnum
        {
            [Description("Neplaćeni")]
            U_Pripremi  = 0,
            [Description("Plaćeni")]
            Vazeci = 1,
            [Description("Storno")]
            Storno = 2
        }

        public enum FormMode
        {
            New = 0,
            Modifying = 1,
            ReadOnly = 2
        }

        public enum DocumentType
        {
            [Description("Prijemnica")]
            Receipt = 0,

            [Description("Otpremnica")]
            Despatch = 1,

            [Description("Delimicna otplata")]
            Payment = 2
        }

        public enum ItemType
        {

            [Description("Proizvod")]
            Product = 1,

            [Description("Materijal")]
            Material = 0
        }

    }
}
