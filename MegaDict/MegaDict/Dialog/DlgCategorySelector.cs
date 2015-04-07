using MegaDict.DAL;
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
    public partial class DlgCategorySelector : Form
    {
        public DlgCategorySelector()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex != 0)
                CategoryID = int.Parse(cmbCategory.SelectedValue.ToString());
            else
                CategoryID = null;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void DlgCategorySelector_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = CategoryAccess.Read_AddEmptyRow();
            cmbCategory.DisplayMember = "NAME";
            cmbCategory.ValueMember = "ID";
        }

        public int? CategoryID { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

    }
}
