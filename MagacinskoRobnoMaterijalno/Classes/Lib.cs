using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumsNET;
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

        public static void PrepareDS(DSReport ds, Document document, DataSet groupByPrice)
        {
            Data.DSReport.DocumentRow rowd = ds.Document.NewDocumentRow();
            rowd.ID = (int)document.ID;
            rowd.DocumentNo = document.DocumentNo;
            rowd.DocumentType = ((DocumentType)document.DocumentType).AsString(EnumFormat.Description);
            //rowd.DocumentType = Enum.GetName(typeof(DocumentType), document.DocumentType);
            rowd.DocumentDateTime = document.DocumentDateTime;
            rowd.PaymentDate = document.PaymentDate;
            rowd.PaymentEndDate = document.PaymentEndDate;
            rowd.ClientID = (int)document.ClientID;
            rowd.GroupByPrice = "";
            foreach (DataRow d in groupByPrice.Tables[0].Rows)
            {
                rowd.GroupByPrice += "Cena: " + d["StartWith"] + "; Površina: " + d["Surface"] + Environment.NewLine;
            }
            
            rowd.TotalPrice = document.TotalPrice;
            ds.Document.AddDocumentRow(rowd);
            foreach (var item in document.DocumentItems)
            {
                Data.DSReport.DocumentItemRow row = ds.DocumentItem.NewDocumentItemRow();
                row.ItemPrice = item.ItemPrice;
                row.DocumentID = (int)document.ID;
                row.ArticleNo = item.ArticleNo;
                row.ItemPrice = item.ItemPrice;
                row.Name = item.Item.Name;
                row.Note = item.Note;
                row.OrderDate = item.OrderDate;
                row.ItemID = (int)item.Item.ID;
                row.Quantity = item.Quantity;
                row.QuantityItemPrice = item.QuantityItemPrice;
                row.Height = item.Height;
                row.Width = item.Width;
                row.Surface = item.Surface;
                //row.Name = "test";
                ds.DocumentItem.AddDocumentItemRow(row);
            }
            Data.DSReport.ClientRow rowc = ds.Client.NewClientRow();
            rowc.Address = document.Client.Address;
            rowc.ID = (int)document.ClientID;
            rowc.Name = document.Client.Name;
            rowc.Phone = document.Client.Phone;
            rowc.PhoneFax = document.Client.PhoneFax;
            rowc.PIB = document.Client.PIB;
            rowc.MB = document.Client.MB;
            rowc.BankAccount = document.Client.BankAccount;
            rowc.Email = document.Client.Email;
            ds.Client.AddClientRow(rowc);
            ds.AcceptChanges();
        }
    }
}
