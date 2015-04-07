using MegaDict.DAL;
using MegaDict.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MegaDict.Dialog
{
    public partial class DlgCategory : Form
    {
        private object CurrentEditingValue { get; set; }

        public DlgCategory()
        {
            InitializeComponent();
            dataGridView_Category.AutoGenerateColumns = false;
        }

        private void DlgCategory_Load(object sender, EventArgs e)
        {
            dataGridView_Category.DataSource = CategoryAccess.Read();
            
        }

        private void dataGridView_Category_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            CurrentEditingValue = grid[e.ColumnIndex, e.RowIndex].Value.ToString();
        }

        private void dataGridView_Category_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            if (string.IsNullOrEmpty(grid[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString()))
            {
                MessageBox.Show(string.Format("{0} is required.", "Category name"));
                grid[e.ColumnIndex, e.RowIndex].Value = CurrentEditingValue;
            }
        }

        private void dataGridView_Category_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && dataGridView_Category.IsCurrentCellInEditMode)
            {
                var className = dataGridView_Category[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString();
                if (!string.IsNullOrEmpty(className))
                {
                    Category ent = new Category();
                    ent.NAME = dataGridView_Category[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString();
                    if (dataGridView_Category["clmID", e.RowIndex].Value != null && dataGridView_Category["clmID", e.RowIndex].Value.ToString() != "")
                        ent.ID = int.Parse(dataGridView_Category["clmID", e.RowIndex].Value.ToString());

                    int updatedId = CategoryAccess.Save(ent);
                    dataGridView_Category["clmID", e.RowIndex].Value = updatedId;
                }
            }
        }

        private void dataGridView_Category_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Delete confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string id = e.Row.Cells["clmID"].Value.ToString();
                CategoryAccess.Delete(id);
            }
            else
                e.Cancel = true;
        }
    }
}
