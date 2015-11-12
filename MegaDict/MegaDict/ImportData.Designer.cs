namespace MegaDict
{
    partial class ImportData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lsbResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(12, 12);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(587, 405);
            this.txtData.TabIndex = 0;
            this.txtData.Text = "Dán dữ liệu từ file của Nam vào đây rồi bấm \"Read\", sau khi dữ liệu đã được đọc v" +
    "ào danh sách kế bên, bấm \"Import\" để nhập dữ liệu vào CSDL. Hệ thống sẽ yêu cầu " +
    "chọn Category ngay sau đó.";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(605, 425);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 29);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(524, 425);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 29);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lsbResult
            // 
            this.lsbResult.FormattingEnabled = true;
            this.lsbResult.Location = new System.Drawing.Point(605, 12);
            this.lsbResult.Name = "lsbResult";
            this.lsbResult.Size = new System.Drawing.Size(343, 407);
            this.lsbResult.TabIndex = 2;
            // 
            // ImportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 469);
            this.Controls.Add(this.lsbResult);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ListBox lsbResult;
    }
}