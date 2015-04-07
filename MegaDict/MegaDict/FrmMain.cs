using MegaDict.DAL;
using MegaDict.Dialog;
using MegaDict.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDict
{
    public partial class FrmMain : Form
    {
        public int CURRENT_VIEW_ID { get; set; }

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
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtView.Text = string.Empty;
            txtKey.Text = string.Empty;
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
                dict.KEY_ALT = ConvertToAscii(dict.KEY);
                dict.CONTENT = txtView.Text;
                dict.CONTENT_ALT = ConvertToAscii(dict.CONTENT);
                if (DictionaryAccess.Update(dict))
                    AllowModify(false);
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
                    dict.KEY_ALT = ConvertToAscii(dict.KEY);
                    dict.CONTENT = txtView.Text;
                    dict.CONTENT_ALT = ConvertToAscii(dict.CONTENT);
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

        private void AllowModify(bool isAllow)
        {
            txtKey.ReadOnly = !isAllow;
            txtView.ReadOnly = !isAllow;
        }

        private string ConvertToAscii(string unicodeString)
        {
            List<string[]> listCharactors = new List<string[]>();
            string[] strA = {"a", "á", "à", "ả", "ã", "ạ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ" };
            string[] strE = { "e", "é", "è", "ẻ", "ẽ", "ẹ", "ê", "ế", "ề", "ể", "ễ", "ệ" };
            string[] strI = { "i", "í", "ì", "ỉ", "ĩ", "ị" };
            string[] strO = { "o", "ó", "ò", "ỏ", "õ", "ọ", "ô", "ố", "ồ", "ổ", "ỗ","ộ", "ơ", "ớ", "ờ","ở","ỡ","ợ" };
            string[] strU = { "u", "ú", "ù", "ủ", "ũ", "ụ", "ư", "ứ", "ừ", "ử", "ữ", "ự" };

            string[] strY = { "y", "ý", "ỳ", "ỷ", "ỹ", "ỵ" };
            string[] strD = { "d", "đ" };

            listCharactors.Add(strA);
            listCharactors.Add(strE);
            listCharactors.Add(strI);
            listCharactors.Add(strO);
            listCharactors.Add(strU);
            listCharactors.Add(strY);
            listCharactors.Add(strD);

            foreach (string[] arr in listCharactors)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    unicodeString = unicodeString.Replace(arr[i], arr[0]);
                }
            }

            return unicodeString.ToLower();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            lsbResult.DataSource = DictionaryAccess.Search(ConvertToAscii(txtSearchKey.Text), cmbCategory.SelectedValue.ToString());
            
        }

        private void lsbResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox.SelectedValue != null)
            {
                DataTable dt = (listBox.DataSource as DataTable);
                txtKey.Text = dt.Rows[listBox.SelectedIndex]["KEY"].ToString();
                txtView.Text = dt.Rows[listBox.SelectedIndex]["CONTENT"].ToString();
                CURRENT_VIEW_ID = int.Parse(listBox.SelectedValue.ToString());
                AllowModify(false);

                //update view
                DictionaryAccess.UpdateView(CURRENT_VIEW_ID);


                lsbLatedViews.DataSource = DictionaryAccess.GetLastedViews();
                lsbMostViews.DataSource = DictionaryAccess.GetMostViews();
            }

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

        private void FrmMain_Activated(object sender, EventArgs e)
        {
            cmbCategory.DataSource = CategoryAccess.Read_AddEmptyRow();
        }

        
    }
}
