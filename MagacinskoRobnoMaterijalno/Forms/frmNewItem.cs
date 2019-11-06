using MagacinskoRobnoMaterijalno.Classes;
using MagacinskoRobnoMaterijalno.Models;
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
    public partial class frmNewItem : Form
    {
        BindingList<Article> _bindinglist;
        ArticalLogic _articalLogic;
        public frmNewItem()
        {
            InitializeComponent();
            _bindinglist = new BindingList<Article>();
            _bindinglist.Add(new Article());
            InitNewItem();
        }

        public frmNewItem(Article article)
        {
            InitializeComponent();
            _bindinglist = new BindingList<Article>();
            _bindinglist.Add(article);
            InitNewItem();
            btnAddArticle.Text = "Sačuvaj izmenu";
            this.Text = "Izmena artikla";
            tbSifra.ReadOnly = true;
            btnAddArticle.Click -= btnAddArticle_Click;
            btnAddArticle.Click += btnEditArticle_Click;
        }

        private void btnEditArticle_Click(object sender, EventArgs e)
        {
            _articalLogic.EditArticle(_bindinglist[0]);
            var result = _articalLogic.SaveAllChanges();
            if (result == true)
            {
                MessageBox.Show("Uspesno ste izmenili artikal.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nesto nije u redu, pokusajte ponovo.");
            }
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            _articalLogic.AddArtical(_bindinglist[0]);
           var result = _articalLogic.SaveAllChanges();
            if(result ==true)
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
            BindingAttributes();
        }
        private void BindingAttributes()
        {
            tbSifra.DataBindings.Clear();
            tbSifra.DataBindings.Add("Text", _bindinglist[0], "ArticleNo");

            tbNaziv.DataBindings.Clear();
            tbNaziv.DataBindings.Add("Text", _bindinglist[0], "Name");

            tbPrice.DataBindings.Clear();
            tbPrice.DataBindings.Add("Text", _bindinglist[0], "QuantityItemPrice");
        }
    }
}
