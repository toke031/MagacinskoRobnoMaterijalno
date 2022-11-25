using MagacinskoRobnoMaterijalno.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagacinskoRobnoMaterijalno.Forms
{
    public partial class FrmNewItem : Form
    {
        readonly BindingList<Data.Model.Article> _bindinglist;
        ArticalLogic _articalLogic;
        public FrmNewItem()
        {
            InitializeComponent();
            _bindinglist = new BindingList<Data.Model.Article>
            {
                new Data.Model.Article() { ArticleTypeID = 1 }
            };
            InitNewItem();
        }

        public FrmNewItem(Data.Model.Article article)
        {
            InitializeComponent();
            _bindinglist = new BindingList<Data.Model.Article>
            {
                article
            };
            InitNewItem();
            btnAddArticle.Text = "Sačuvaj izmenu";
            this.Text = "Izmena artikla";
            btnAddArticle.Click -= BtnAddArticle_Click;
            btnAddArticle.Click += BtnEditArticle_Click;
        }

        private void BtnEditArticle_Click(object sender, EventArgs e)
        {
            var result = _articalLogic.EditArticle(_bindinglist[0]);
            if (result != 0)
            {
                MessageBox.Show("Uspesno ste izmenili artikal.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nesto nije u redu, pokusajte ponovo.");
            }
        }

        private void BtnAddArticle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_bindinglist[0].ArticleNo))
            {
                MessageBox.Show("Šifra artikla je obavezno polje.");
                return;
            }
            else if (_articalLogic.IfExists(_bindinglist[0].ArticleNo))
            {
                MessageBox.Show("Artikal sa šifrom " + _bindinglist[0].ArticleNo + " već postoji. Promenite šifru i probajte ponovo.");
                return;
            }

            //Task<Task> task = Task.Factory.StartNew(() =>
            //               _articalLogic.AddArtical(_bindinglist[0]);
            //var addArticle = task;

            var id = _articalLogic.AddArtical(_bindinglist[0]);

            if (id != 0)
            {
                MessageBox.Show("Uspesno ste dodali novi artikal.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nesto nije u redu, pokusajte ponovo.");
            }
        }

        private void InitNewItem()
        {
            _articalLogic = new ArticalLogic();

            // tip dokumenta
            cmbItemType.DisplayMember = "Description";
            cmbItemType.DataSource = Enum.GetValues(typeof(Classes.Lib.ItemType))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    v = (int)(Enum.Parse(typeof(Classes.Lib.ItemType), value.ToString()))
                })
                .OrderBy(item => item.v)
                .ToList();
            BindingAttributes();

        }
        private void BindingAttributes()
        {
            tbSifra.DataBindings.Clear();
            tbSifra.DataBindings.Add("Text", _bindinglist[0], "ArticleNo");

            tbNaziv.DataBindings.Clear();
            tbNaziv.DataBindings.Add("Text", _bindinglist[0], "Name");

            tbPrice.DataBindings.Clear();
            tbPrice.DataBindings.Add("Text", _bindinglist[0], "ItemPrice");

            cmbItemType.DataBindings.Clear();
            cmbItemType.DataBindings.Add("SelectedIndex", _bindinglist[0], "ArticleTypeID");
        }
    }
}
