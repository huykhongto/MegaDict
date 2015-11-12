namespace MegaDict
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lsbResult = new System.Windows.Forms.ListBox();
            this.txtView = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lsbLatedViews = new System.Windows.Forms.ListBox();
            this.lsbMostViews = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnPoupCategory = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(272, 63);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(552, 20);
            this.txtSearchKey.TabIndex = 0;
            this.txtSearchKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchKey_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(830, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(3, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(3, 63);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(169, 21);
            this.cmbCategory.TabIndex = 2;
            // 
            // lsbResult
            // 
            this.lsbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbResult.FormattingEnabled = true;
            this.lsbResult.Location = new System.Drawing.Point(3, 16);
            this.lsbResult.Name = "lsbResult";
            this.lsbResult.Size = new System.Drawing.Size(263, 230);
            this.lsbResult.TabIndex = 3;
            this.lsbResult.SelectedIndexChanged += new System.EventHandler(this.lsbResult_SelectedIndexChanged);
            // 
            // txtView
            // 
            this.txtView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtView.Location = new System.Drawing.Point(3, 16);
            this.txtView.Multiline = true;
            this.txtView.Name = "txtView";
            this.txtView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtView.Size = new System.Drawing.Size(636, 393);
            this.txtView.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(84, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lsbLatedViews
            // 
            this.lsbLatedViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbLatedViews.FormattingEnabled = true;
            this.lsbLatedViews.Location = new System.Drawing.Point(3, 16);
            this.lsbLatedViews.Name = "lsbLatedViews";
            this.lsbLatedViews.Size = new System.Drawing.Size(263, 121);
            this.lsbLatedViews.TabIndex = 6;
            this.lsbLatedViews.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsbResult_SelectedIndexChanged);
            // 
            // lsbMostViews
            // 
            this.lsbMostViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbMostViews.FormattingEnabled = true;
            this.lsbMostViews.Location = new System.Drawing.Point(3, 16);
            this.lsbMostViews.Name = "lsbMostViews";
            this.lsbMostViews.Size = new System.Drawing.Size(263, 107);
            this.lsbMostViews.TabIndex = 7;
            this.lsbMostViews.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsbResult_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(3, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtKey
            // 
            this.txtKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKey.Location = new System.Drawing.Point(3, 16);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(636, 20);
            this.txtKey.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 515);
            this.panel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsbResult);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search result";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsbLatedViews);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 140);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lasted Views";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsbMostViews);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 389);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 126);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Most Views";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(269, 578);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 30);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAddNew);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(480, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(162, 30);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(86, 30);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.btnImport);
            this.panel5.Controls.Add(this.btnPoupCategory);
            this.panel5.Controls.Add(this.btnSearch);
            this.panel5.Controls.Add(this.txtSearchKey);
            this.panel5.Controls.Add(this.cmbCategory);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(911, 93);
            this.panel5.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MegaDict.Properties.Resources.dc1305024fbd2be1bed67e446f4a26cf1404955154_LOgo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(218, 63);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(48, 23);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnPoupCategory
            // 
            this.btnPoupCategory.Location = new System.Drawing.Point(178, 63);
            this.btnPoupCategory.Name = "btnPoupCategory";
            this.btnPoupCategory.Size = new System.Drawing.Size(36, 23);
            this.btnPoupCategory.TabIndex = 3;
            this.btnPoupCategory.Text = "...";
            this.btnPoupCategory.UseVisualStyleBackColor = true;
            this.btnPoupCategory.Click += new System.EventHandler(this.btnPoupCategory_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtView);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(642, 412);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Content";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox4);
            this.panel6.Controls.Add(this.groupBox5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(269, 93);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(642, 485);
            this.panel6.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnOpen);
            this.groupBox5.Controls.Add(this.txtFilePath);
            this.groupBox5.Controls.Add(this.btnBrowse);
            this.groupBox5.Controls.Add(this.txtKey);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(642, 73);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(330, 43);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(4, 44);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(238, 20);
            this.txtFilePath.TabIndex = 10;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(248, 43);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 608);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RCR EMPLOYEE MANAGEMENT (SIMPLE VERSION)";
            this.Activated += new System.EventHandler(this.FrmMain_Activated);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ListBox lsbResult;
        private System.Windows.Forms.TextBox txtView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lsbLatedViews;
        private System.Windows.Forms.ListBox lsbMostViews;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnPoupCategory;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnOpen;
    }
}

