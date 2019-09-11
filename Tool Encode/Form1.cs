using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Tool_Encode
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string CNS = "";
        static readonly string PasswordHash = "P@@Sw0rd";
        static readonly string SaltKey = "S@LT&KEY";
        static readonly string VIKey = "@1B2c3D4e5F6g7H8";
        public static string Encrypt(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

            byte[] cipherTextBytes;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }
            return Convert.ToBase64String(cipherTextBytes);
        }
        //Hàm giải mã hóa file
        public static string Decrypt(string encryptedText)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }
        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void rtb_ChuoiKyTuBinhThuong_E_TextChanged(object sender, EventArgs e)
        {
            btn_MaHoa.PerformClick();
        }

        private void btn_MaHoa_Click(object sender, EventArgs e)
        {
            this.rtb_ChuoiSauMaHoa_e.Text = Encrypt(this.rtb_ChuoiKyTuBinhThuong_E.Text);

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtb_ChuoiSauMaHoa_e.Text);
            MessageBox.Show("Copied");
        }

        private void btn_GiaiMaHoa_Click(object sender, EventArgs e)
        {
            this.rtb_ChuoiGiaiMaHoa.Text = Decrypt(this.rtb_ChuoiDaMaHoa.Text);
        }

        private void rtb_ChuoiDaMaHoa_TextChanged(object sender, EventArgs e)
        {
            btn_GiaiMaHoa.PerformClick();
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtb_ChuoiGiaiMaHoa.Text);
            MessageBox.Show("Copied");
        }

        private void rdo_NonSecurity_CheckedChanged(object sender, EventArgs e)
        {
            this.grb_Account.Enabled = false;
        }

        private void rdo_HaveSecurity_CheckedChanged(object sender, EventArgs e)
        {
            this.grb_Account.Enabled = true;
        }

 

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                CNS = "Server=" + this.txt_SeverName.Text + "; database=" + this.txt_Database.Text;
                if (rdo_NonSecurity.Checked)
                    CNS += ";Integrated Security=SSPI";
                else
                    CNS += ";User Id=" + this.txt_UserName.Text + ";Password = " + this.txtPassWord.Text;
                // MessageBox.Show(CNS);
                SqlConnection cns = new SqlConnection(CNS);
                try
                {
                    cns.Open();
                    MessageBox.Show("Connected", "Result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    cns.Close();
                }
                catch
                {
                    MessageBox.Show("An error occurred, please be sure to enter the correct information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("An error occurred, please be sure to enter the correct information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CNS);
            MessageBox.Show("Copied");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://fb.com/hoalaxanh123");
        }
    }
}
