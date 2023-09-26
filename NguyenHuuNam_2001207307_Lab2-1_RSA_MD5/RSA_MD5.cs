using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenHuuNam_2001207307_Lab2_1_RSA_MD5
{
    public partial class RSA_MD5 : Form
    {
        private List<RSAsite> RSAsites = new List<RSAsite>();
        public RSA_MD5()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Cbb_mod.Items.Add("Mã hóa băm (MD5)");
            Cbb_mod.Items.Add("Mã hóa bất đối xứng (RSA)");
            Cbb_mod.SelectedItem = "Mã hóa băm (MD5)";
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Content.Text = "";
            txt_Result.Text = "";
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Content.Text))
            {
                MessageBox.Show("Nhập nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Cbb_mod.Text.Contains("MD5"))
            {
                MessageBox.Show("Mã băm không hỗ trợ giải mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            String md5c = MD5site.Encrypt(txt_Content.Text);
            foreach(RSAsite s in this.RSAsites)
            {
                if (s.getMD5_code().Equals(md5c))
                {
                    String Result = s.Decrypt(txt_Content.Text);
                    if(Result == null)
                    {
                        MessageBox.Show("Giải mã thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    txt_Result.Text = Result;
                    return;
                }
            }

            MessageBox.Show("Không thể giải mã !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Content.Text))
            {
                MessageBox.Show("Nhập nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(Cbb_mod.Text.Contains("MD5")) txt_Result.Text = MD5site.Encrypt(txt_Content.Text);
            else
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                RSAsite site = new RSAsite(rsa.ExportParameters(true), rsa.ExportParameters(false));
                String Result = site.Encrypt(txt_Content.Text);
                if (Result == null)
                {
                    MessageBox.Show("Mã hóa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txt_Result.Text = Result;
                this.RSAsites.Add(site);
            }
        }
    }
}
