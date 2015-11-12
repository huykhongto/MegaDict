using MegaDict.DAL;
using MegaDict.Dialog;
using MegaDict.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDict
{
    public partial class FrmMain : Form
    {

        #region -VAR-

        public int CURRENT_VIEW_ID { get; set; }

        #endregion

        #region -FORM-

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
             cmbCategory.DataSource = CategoryAccess.Read_AddEmptyRow();
            cmbCategory.DisplayMember = "NAME";
            cmbCategory.ValueMember = "ID";
            lsbResult.DisplayMember = "Key";
            lsbResult.ValueMember = "ID";
            lsbLatedViews.DisplayMember = "Key";
            lsbLatedViews.ValueMember = "ID";
            lsbMostViews.DisplayMember = "Key";
            lsbMostViews.ValueMember = "ID";

            txtSearchKey.Focus();
        }

        private void FrmMain_Activated(object sender, EventArgs e)
        {
            cmbCategory.DataSource = CategoryAccess.Read_AddEmptyRow();
        }

        #endregion

        #region -BUTTON EVENTS-

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtView.Text = string.Empty;
            txtKey.Text = string.Empty;
            txtFilePath.Text = string.Empty;
            CURRENT_VIEW_ID = 0;
            AllowModify(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKey.Text))
            {
                MessageBox.Show("Key is required.");
                return;
            }

            if (CURRENT_VIEW_ID != 0)
            {
                Dictionary dict = new Dictionary();
                dict.ID = CURRENT_VIEW_ID;
                dict.KEY = txtKey.Text;
                dict.KEY_ALT = MegaDict.Utility.App.ConvertToAscii(dict.KEY);
                dict.CONTENT = txtView.Text;
                dict.CONTENT_ALT = MegaDict.Utility.App.ConvertToAscii(dict.CONTENT);
                dict.ATTACH_FILE_PATH =  CopyFileToData(txtFilePath.Text);
                
                if (DictionaryAccess.Update(dict))
                {
                    //copy file to data folder
                    if(!string.IsNullOrEmpty(txtFilePath.Text))
                       
                    AllowModify(false);
                }
                    
                else
                    MessageBox.Show("Insert error.");
            }
            else
            {
                DlgCategorySelector dlg = new DlgCategorySelector();
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Dictionary dict = new Dictionary();
                    dict.CATEGORY_ID = dlg.CategoryID;
                    dict.KEY = txtKey.Text;
                    dict.KEY_ALT = MegaDict.Utility.App.ConvertToAscii(dict.KEY);
                    dict.CONTENT = txtView.Text;
                    dict.CONTENT_ALT = MegaDict.Utility.App.ConvertToAscii(dict.CONTENT);
                    dict.ATTACH_FILE_PATH = CopyFileToData(txtFilePath.Text);
                    if (DictionaryAccess.Insert(dict)){
                        MessageBox.Show("Save succeed.");
                        //txtView.Text = txtKey.Text = string.Empty;
                        //AllowModify(true);
                        //CURRENT_VIEW_ID = 0;
                    }
                    else
                        MessageBox.Show("Insert error.");

                }
            }
            AllowModify(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var data = DictionaryAccess.Search(MegaDict.Utility.App.ConvertToAscii(txtSearchKey.Text), cmbCategory.SelectedValue.ToString());
            lsbResult.DataSource = data;
            if(data.Rows.Count > 0)
                groupBox1.Text = string.Format("Search result (total: {0})",data.Rows.Count);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AllowModify(true);
        }

        private void btnPoupCategory_Click(object sender, EventArgs e)
        {
            DlgCategory dlg = new DlgCategory();
            dlg.ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportData dlg = new ImportData();
            dlg.ShowDialog();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = dlg.FileName;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilePath.Text))
            {
                if (File.Exists(txtFilePath.Text))
                {
                    FileInfo file = new FileInfo(txtFilePath.Text);
                    System.Diagnostics.Process.Start(file.FullName);
                }
            }
        }

        #endregion

        #region -OTHER EVENTS-
        private void lsbResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox.SelectedValue != null)
            {
                DataTable dt = (listBox.DataSource as DataTable);
                txtKey.Text = dt.Rows[listBox.SelectedIndex]["KEY"].ToString();
                txtView.Text = dt.Rows[listBox.SelectedIndex]["CONTENT"].ToString();
                CURRENT_VIEW_ID = int.Parse(listBox.SelectedValue.ToString());
                txtFilePath.Text = dt.Rows[listBox.SelectedIndex]["ATTACH_FILE_PATH"].ToString();
                AllowModify(false);

                //update view
                DictionaryAccess.UpdateView(CURRENT_VIEW_ID);


                lsbLatedViews.DataSource = DictionaryAccess.GetLastedViews();
                lsbMostViews.DataSource = DictionaryAccess.GetMostViews();
            }

        }

        private void txtSearchKey_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            //lsbResult.DataSource = DictionaryAccess.Search(MegaDict.Utility.App.ConvertToAscii(txtSearchKey.Text), cmbCategory.SelectedValue.ToString());
        }
        #endregion

        #region -METHODO-
        private string CopyFileToData(string newFilePath)
        {
            string folderName = "Data//Files";
            if (!Directory.Exists(folderName))
                Directory.CreateDirectory(folderName);

            FileInfo file = new FileInfo(newFilePath);
            string desFilePath = folderName + "//" + DateTime.Now.ToString("yyyyMMdd_HHmmss_") + file.Name;
            File.Copy(newFilePath, desFilePath);
            return desFilePath;
        }

        private void AllowModify(bool isAllow)
        {
            txtKey.ReadOnly = !isAllow;
            txtView.ReadOnly = !isAllow;
            btnBrowse.Enabled = isAllow;
        }
        #endregion
    }
}
