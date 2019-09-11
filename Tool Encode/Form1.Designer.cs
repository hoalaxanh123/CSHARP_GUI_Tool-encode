namespace Tool_Encode
{
    partial class Form1
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
            this.Tab_GetConection = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.rtb_ChuoiKyTuBinhThuong_E = new System.Windows.Forms.RichTextBox();
            this.btn_MaHoa = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.rtb_ChuoiSauMaHoa_e = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_ChuoiDaMaHoa = new System.Windows.Forms.RichTextBox();
            this.btn_GiaiMaHoa = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rtb_ChuoiGiaiMaHoa = new System.Windows.Forms.RichTextBox();
            this.btn_Copy = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Database = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_HelpDataBase = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdo_HaveSecurity = new System.Windows.Forms.RadioButton();
            this.rdo_NonSecurity = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.grb_Account = new System.Windows.Forms.GroupBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SeverName = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_GetConection)).BeginInit();
            this.Tab_GetConection.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grb_Account.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_GetConection
            // 
            this.Tab_GetConection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab_GetConection.Location = new System.Drawing.Point(0, 0);
            this.Tab_GetConection.Name = "Tab_GetConection";
            this.Tab_GetConection.SelectedTabPage = this.xtraTabPage1;
            this.Tab_GetConection.Size = new System.Drawing.Size(344, 440);
            this.Tab_GetConection.TabIndex = 0;
            this.Tab_GetConection.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            this.Tab_GetConection.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupBox1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(338, 412);
            this.xtraTabPage1.Text = "Connection String";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.rtb_ChuoiSauMaHoa_e);
            this.xtraTabPage2.Controls.Add(this.simpleButton2);
            this.xtraTabPage2.Controls.Add(this.rtb_ChuoiKyTuBinhThuong_E);
            this.xtraTabPage2.Controls.Add(this.btn_MaHoa);
            this.xtraTabPage2.Controls.Add(this.label3);
            this.xtraTabPage2.Controls.Add(this.label2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(338, 412);
            this.xtraTabPage2.Text = "Encrypt";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.btn_Copy);
            this.xtraTabPage3.Controls.Add(this.rtb_ChuoiGiaiMaHoa);
            this.xtraTabPage3.Controls.Add(this.btn_GiaiMaHoa);
            this.xtraTabPage3.Controls.Add(this.label4);
            this.xtraTabPage3.Controls.Add(this.rtb_ChuoiDaMaHoa);
            this.xtraTabPage3.Controls.Add(this.label1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(338, 412);
            this.xtraTabPage3.Text = "Decrypt";
            // 
            // rtb_ChuoiKyTuBinhThuong_E
            // 
            this.rtb_ChuoiKyTuBinhThuong_E.Location = new System.Drawing.Point(23, 43);
            this.rtb_ChuoiKyTuBinhThuong_E.Name = "rtb_ChuoiKyTuBinhThuong_E";
            this.rtb_ChuoiKyTuBinhThuong_E.Size = new System.Drawing.Size(281, 117);
            this.rtb_ChuoiKyTuBinhThuong_E.TabIndex = 10;
            this.rtb_ChuoiKyTuBinhThuong_E.Text = "";
            this.rtb_ChuoiKyTuBinhThuong_E.TextChanged += new System.EventHandler(this.rtb_ChuoiKyTuBinhThuong_E_TextChanged);
            // 
            // btn_MaHoa
            // 
            this.btn_MaHoa.Location = new System.Drawing.Point(129, 166);
            this.btn_MaHoa.Name = "btn_MaHoa";
            this.btn_MaHoa.Size = new System.Drawing.Size(75, 23);
            this.btn_MaHoa.TabIndex = 8;
            this.btn_MaHoa.Text = "Encrypt";
            this.btn_MaHoa.Click += new System.EventHandler(this.btn_MaHoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result :";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(272, 229);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(32, 23);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "Copy";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // rtb_ChuoiSauMaHoa_e
            // 
            this.rtb_ChuoiSauMaHoa_e.Location = new System.Drawing.Point(23, 261);
            this.rtb_ChuoiSauMaHoa_e.Name = "rtb_ChuoiSauMaHoa_e";
            this.rtb_ChuoiSauMaHoa_e.Size = new System.Drawing.Size(281, 122);
            this.rtb_ChuoiSauMaHoa_e.TabIndex = 10;
            this.rtb_ChuoiSauMaHoa_e.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text :";
            // 
            // rtb_ChuoiDaMaHoa
            // 
            this.rtb_ChuoiDaMaHoa.Location = new System.Drawing.Point(24, 54);
            this.rtb_ChuoiDaMaHoa.Name = "rtb_ChuoiDaMaHoa";
            this.rtb_ChuoiDaMaHoa.Size = new System.Drawing.Size(285, 117);
            this.rtb_ChuoiDaMaHoa.TabIndex = 1;
            this.rtb_ChuoiDaMaHoa.Text = "";
            this.rtb_ChuoiDaMaHoa.TextChanged += new System.EventHandler(this.rtb_ChuoiDaMaHoa_TextChanged);
            // 
            // btn_GiaiMaHoa
            // 
            this.btn_GiaiMaHoa.Location = new System.Drawing.Point(124, 177);
            this.btn_GiaiMaHoa.Name = "btn_GiaiMaHoa";
            this.btn_GiaiMaHoa.Size = new System.Drawing.Size(75, 23);
            this.btn_GiaiMaHoa.TabIndex = 2;
            this.btn_GiaiMaHoa.Text = "Decrypt";
            this.btn_GiaiMaHoa.Click += new System.EventHandler(this.btn_GiaiMaHoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Result :";
            // 
            // rtb_ChuoiGiaiMaHoa
            // 
            this.rtb_ChuoiGiaiMaHoa.Location = new System.Drawing.Point(24, 263);
            this.rtb_ChuoiGiaiMaHoa.Name = "rtb_ChuoiGiaiMaHoa";
            this.rtb_ChuoiGiaiMaHoa.Size = new System.Drawing.Size(285, 121);
            this.rtb_ChuoiGiaiMaHoa.TabIndex = 1;
            this.rtb_ChuoiGiaiMaHoa.Text = "";
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(272, 232);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(37, 25);
            this.btn_Copy.TabIndex = 2;
            this.btn_Copy.Text = "Copy";
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.simpleButton4);
            this.groupBox1.Controls.Add(this.simpleButton3);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.txt_Database);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_HelpDataBase);
            this.groupBox1.Controls.Add(this.btn_Help);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.grb_Account);
            this.groupBox1.Controls.Add(this.txt_SeverName);
            this.groupBox1.Location = new System.Drawing.Point(11, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 402);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection String";
            // 
            // txt_Database
            // 
            this.txt_Database.Location = new System.Drawing.Point(110, 56);
            this.txt_Database.Name = "txt_Database";
            this.txt_Database.Size = new System.Drawing.Size(149, 21);
            this.txt_Database.TabIndex = 1;
            this.txt_Database.Text = "QuanLyNhaHang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Database :";
            // 
            // btn_HelpDataBase
            // 
            this.btn_HelpDataBase.Location = new System.Drawing.Point(275, 56);
            this.btn_HelpDataBase.Name = "btn_HelpDataBase";
            this.btn_HelpDataBase.Size = new System.Drawing.Size(16, 20);
            this.btn_HelpDataBase.TabIndex = 7;
            this.btn_HelpDataBase.Text = "?";
            this.btn_HelpDataBase.UseVisualStyleBackColor = true;
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(275, 31);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(16, 20);
            this.btn_Help.TabIndex = 7;
            this.btn_Help.Text = "?";
            this.btn_Help.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdo_HaveSecurity);
            this.groupBox3.Controls.Add(this.rdo_NonSecurity);
            this.groupBox3.Location = new System.Drawing.Point(28, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 55);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logon Security";
            // 
            // rdo_HaveSecurity
            // 
            this.rdo_HaveSecurity.AutoSize = true;
            this.rdo_HaveSecurity.Location = new System.Drawing.Point(172, 19);
            this.rdo_HaveSecurity.Name = "rdo_HaveSecurity";
            this.rdo_HaveSecurity.Size = new System.Drawing.Size(42, 17);
            this.rdo_HaveSecurity.TabIndex = 1;
            this.rdo_HaveSecurity.Text = "Yes";
            this.rdo_HaveSecurity.UseVisualStyleBackColor = true;
            this.rdo_HaveSecurity.CheckedChanged += new System.EventHandler(this.rdo_HaveSecurity_CheckedChanged);
            // 
            // rdo_NonSecurity
            // 
            this.rdo_NonSecurity.AutoSize = true;
            this.rdo_NonSecurity.Checked = true;
            this.rdo_NonSecurity.Location = new System.Drawing.Point(19, 19);
            this.rdo_NonSecurity.Name = "rdo_NonSecurity";
            this.rdo_NonSecurity.Size = new System.Drawing.Size(50, 17);
            this.rdo_NonSecurity.TabIndex = 0;
            this.rdo_NonSecurity.TabStop = true;
            this.rdo_NonSecurity.Text = "None";
            this.rdo_NonSecurity.UseVisualStyleBackColor = true;
            this.rdo_NonSecurity.CheckedChanged += new System.EventHandler(this.rdo_NonSecurity_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sever name :";
            // 
            // grb_Account
            // 
            this.grb_Account.Controls.Add(this.txtPassWord);
            this.grb_Account.Controls.Add(this.txt_UserName);
            this.grb_Account.Controls.Add(this.label7);
            this.grb_Account.Controls.Add(this.label8);
            this.grb_Account.Enabled = false;
            this.grb_Account.Location = new System.Drawing.Point(28, 192);
            this.grb_Account.Name = "grb_Account";
            this.grb_Account.Size = new System.Drawing.Size(263, 100);
            this.grb_Account.TabIndex = 2;
            this.grb_Account.TabStop = false;
            this.grb_Account.Text = "Account";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(91, 49);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '☺';
            this.txtPassWord.Size = new System.Drawing.Size(152, 21);
            this.txtPassWord.TabIndex = 1;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(91, 23);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(152, 21);
            this.txt_UserName.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Password :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "User name: ";
            // 
            // txt_SeverName
            // 
            this.txt_SeverName.Location = new System.Drawing.Point(110, 29);
            this.txt_SeverName.Name = "txt_SeverName";
            this.txt_SeverName.Size = new System.Drawing.Size(149, 21);
            this.txt_SeverName.TabIndex = 0;
            this.txt_SeverName.Text = "localhost\\SQLEXPRESS";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(28, 337);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(82, 23);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Test connection";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(128, 337);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(72, 23);
            this.simpleButton3.TabIndex = 9;
            this.simpleButton3.Text = "Copy";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(219, 337);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(72, 23);
            this.simpleButton4.TabIndex = 9;
            this.simpleButton4.Text = "Exit";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(217, 380);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Code by 1510289";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 440);
            this.Controls.Add(this.Tab_GetConection);
            this.Name = "Form1";
            this.Text = "Encode Tool";
            ((System.ComponentModel.ISupportInitialize)(this.Tab_GetConection)).EndInit();
            this.Tab_GetConection.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grb_Account.ResumeLayout(false);
            this.grb_Account.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl Tab_GetConection;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.RichTextBox rtb_ChuoiSauMaHoa_e;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.RichTextBox rtb_ChuoiKyTuBinhThuong_E;
        private DevExpress.XtraEditors.SimpleButton btn_MaHoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_Copy;
        private System.Windows.Forms.RichTextBox rtb_ChuoiGiaiMaHoa;
        private DevExpress.XtraEditors.SimpleButton btn_GiaiMaHoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtb_ChuoiDaMaHoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Database;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_HelpDataBase;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdo_HaveSecurity;
        private System.Windows.Forms.RadioButton rdo_NonSecurity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grb_Account;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_SeverName;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

