using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagacinskoRobnoMaterijalno.Data;
using MagacinskoRobnoMaterijalno.Models;

namespace MagacinskoRobnoMaterijalno.Classes
{
    public class Lib
    {
        public enum StatusEnum
        {
            [Description("Neplaćeni")]
            U_Pripremi = 0,
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

        public static void PrepareDS(DSReport ds, Document document)
        {
            Data.DSReport.DocumentRow rowd = ds.Document.NewDocumentRow();
            rowd.ID = (int)document.ID;
            rowd.DocumentNo = document.DocumentNo;
            rowd.DocumentType = Enum.GetName(typeof(DocumentType), document.DocumentType);
            rowd.DocumentDateTime = document.DocumentDateTime;
            rowd.PaymentDate = document.PaymentDate;
            rowd.PaymentEndDate = document.PaymentEndDate;
            rowd.ClientID = (int)document.ClientID;
            ds.Document.AddDocumentRow(rowd);
            foreach (var item in document.DocumentItems)
            {
                Data.DSReport.DocumentItemRow row = ds.DocumentItem.NewDocumentItemRow();
                row.ItemPrice = item.ItemPrice;
                row.DocumentID = (int)document.ID;
                row.ArticleNo = item.ArticleNo;
                row.ItemPrice = item.ItemPrice;
                ds.DocumentItem.AddDocumentItemRow(row);
            }
            Data.DSReport.ClientRow rowc = ds.Client.NewClientRow();
            rowc.Address = document.Client.Address;
            rowc.ID = (int)document.ClientID;
            rowc.Name = document.Client.Name;
            ds.Client.AddClientRow(rowc);
            ds.AcceptChanges();
        }
    }
}
