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
using System.Windows.Forms;

namespace MegaDict
{
    public partial class ImportData : Form
    {
        public ImportData()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string[] items = txtData.Text.Split(new string[]{"\r\n"}, StringSplitOptions.RemoveEmptyEntries);
            foreach(var item in items)
            {
                lsbResult.Items.Add(item);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            
            DlgCategorySelector dlg = new DlgCategorySelector();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                btnImport.Enabled = false;
                Dictionary dict = new Dictionary();
                dict.CATEGORY_ID = dlg.CategoryID;

                foreach(string item in lsbResult.Items)
                {
                    string[] data = item.Split(new string[] { "~~" }, StringSplitOptions.RemoveEmptyEntries);
                    if(data.Length == 2)
                    {
                        string key = data[0];
                        string key_alt = MegaDict.Utility.App.ConvertToAscii(key);
                        string content = data[1];
                        string content_alt = MegaDict.Utility.App.ConvertToAscii(content);

                        dict.KEY = key;
                        dict.KEY_ALT = key_alt;
                        dict.CONTENT = content.Replace("`", "\r\n");
                        dict.CONTENT_ALT = content_alt;
                        if (DictionaryAccess.Insert(dict))
                        {
                            Console.WriteLine(string.Format("Đã thêm: {0}", key));
                        }
                        else
                            Console.WriteLine(string.Format("Thêm: {0} thất bại.", key));
                    }
                    
                }

                Cursor = Cursors.Default;
                MessageBox.Show("Đã thêm hoàn tất.");
                btnImport.Enabled = true;
            }
        }
    }
}
