
namespace NguyenHuuNam_2001207307_Lab2_1_RSA_MD5
{
    partial class RSA_MD5
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
            this.btn_Decrypt = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Encrypt = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Reset = new Guna.UI2.WinForms.Guna2Button();
            this.Cbb_mod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_Content = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Result = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Decrypt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Decrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Decrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Decrypt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Decrypt.ForeColor = System.Drawing.Color.White;
            this.btn_Decrypt.Location = new System.Drawing.Point(368, 430);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(322, 45);
            this.btn_Decrypt.TabIndex = 0;
            this.btn_Decrypt.Text = "Giải mã";
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Encrypt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Encrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Encrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Encrypt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Encrypt.ForeColor = System.Drawing.Color.White;
            this.btn_Encrypt.Location = new System.Drawing.Point(12, 430);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(337, 45);
            this.btn_Encrypt.TabIndex = 1;
            this.btn_Encrypt.Text = "Mã hóa";
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(12, 12);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(82, 26);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Cbb_mod
            // 
            this.Cbb_mod.BackColor = System.Drawing.Color.Transparent;
            this.Cbb_mod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cbb_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbb_mod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cbb_mod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cbb_mod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cbb_mod.ForeColor = System.Drawing.Color.Black;
            this.Cbb_mod.ItemHeight = 30;
            this.Cbb_mod.Location = new System.Drawing.Point(356, 12);
            this.Cbb_mod.Name = "Cbb_mod";
            this.Cbb_mod.Size = new System.Drawing.Size(334, 36);
            this.Cbb_mod.TabIndex = 3;
            // 
            // txt_Content
            // 
            this.txt_Content.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Content.DefaultText = "";
            this.txt_Content.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Content.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Content.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Content.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Content.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Content.ForeColor = System.Drawing.Color.Black;
            this.txt_Content.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Content.Location = new System.Drawing.Point(12, 94);
            this.txt_Content.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Content.Multiline = true;
            this.txt_Content.Name = "txt_Content";
            this.txt_Content.PasswordChar = '\0';
            this.txt_Content.PlaceholderText = "";
            this.txt_Content.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Content.SelectedText = "";
            this.txt_Content.Size = new System.Drawing.Size(678, 97);
            this.txt_Content.TabIndex = 4;
            // 
            // txt_Result
            // 
            this.txt_Result.BackColor = System.Drawing.Color.White;
            this.txt_Result.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Result.DefaultText = "";
            this.txt_Result.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Result.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Result.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Result.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Result.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Result.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Result.ForeColor = System.Drawing.Color.Black;
            this.txt_Result.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Result.Location = new System.Drawing.Point(12, 236);
            this.txt_Result.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.PasswordChar = '\0';
            this.txt_Result.PlaceholderText = "";
            this.txt_Result.ReadOnly = true;
            this.txt_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Result.SelectedText = "";
            this.txt_Result.Size = new System.Drawing.Size(678, 185);
            this.txt_Result.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nội dung:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kết quả:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 487);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.txt_Content);
            this.Controls.Add(this.Cbb_mod);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.btn_Decrypt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_Decrypt;
        private Guna.UI2.WinForms.Guna2Button btn_Encrypt;
        private Guna.UI2.WinForms.Guna2Button btn_Reset;
        private Guna.UI2.WinForms.Guna2ComboBox Cbb_mod;
        private Guna.UI2.WinForms.Guna2TextBox txt_Content;
        private Guna.UI2.WinForms.Guna2TextBox txt_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

