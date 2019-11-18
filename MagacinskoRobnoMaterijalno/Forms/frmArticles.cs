﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagacinskoRobnoMaterijalno.Classes;
using MagacinskoRobnoMaterijalno.Models;

namespace MagacinskoRobnoMaterijalno.Forms
{
    public partial class frmArticles : Form
    {
        ArticalLogic _articalLogic;
        Article ItemForDelete;
        public frmArticles()
        {
            InitializeComponent();
            InitArticles();
        }

        private void InitArticles()
        {
            _articalLogic = new ArticalLogic();
            List<string> _rowForDelete = new List<string>();
            articleBindingSource.DataSource = _articalLogic.GetAllArticles();
            DGVArticles.AllowUserToAddRows = false;
            DGVArticles.ReadOnly = true;
            DGVArticles.AllowUserToDeleteRows = true;
            DGVArticles.UserDeletingRow += DGVArticles_UserDeletingRow; ;
            DGVArticles.UserDeletedRow += DGVArticles_UserDeletedRow;
            DGVArticles.Click += Right_Click;
        }

        private void DGVArticles_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            _articalLogic.DeleteArticle(ItemForDelete);
        }

        private void DGVArticles_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete artikal", "Brisanje artikla", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ItemForDelete = _articalLogic.GetArticleByArticleNo(e.Row.Cells[1].Value.ToString());
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Right_Click(object sender, EventArgs e)
        {


            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var hti = DGVArticles.HitTest(me.X, me.Y);
                if (hti.RowIndex >= 0)
                {
                    DGVArticles.ClearSelection();
                    DGVArticles.Rows[hti.RowIndex].Selected = true;
                }

                ContextMenu cm = new ContextMenu();
                cm.MenuItems.Add("Dodaj artikal", new EventHandler(AddNewArtical_Click));
                if (DGVArticles.SelectedRows.Count == 1)
                {
                    cm.MenuItems.Add("Izmeni artikal", new EventHandler(EditRow_Click));
                }
                cm.Show(DGVArticles, new Point(me.X, me.Y));
            }
        }

        private void EditRow_Click(object sender, EventArgs e)
        {
            if (DGVArticles.SelectedRows.Count == 1)
            {
                var articalForEdit = (Article)DGVArticles.SelectedRows[0].DataBoundItem;
                frmNewItem editArticle = new frmNewItem(articalForEdit);
                editArticle.ShowDialog();
                DGVArticles.DataSource = new BindingList<Article>(_articalLogic.GetArticleByName(tbSearchItemNo.Text));
                DGVArticles.ClearSelection();
            }
        }

        private void AddNewArtical_Click(object sender, EventArgs e)
        {
            var newItemForm = new frmNewItem();
            newItemForm.ShowDialog();
            RefreshDGVSource();
        }

        private void RefreshDGVSource()
        {
            DGVArticles.DataSource = _articalLogic.GetAllArticles();
            DGVArticles.RefreshEdit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DGVArticles.DataSource = _articalLogic.GetArticlesByArticleNo(tbSearchItemNo.Text);
        }
    }
}
