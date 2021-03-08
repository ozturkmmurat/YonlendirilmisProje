
namespace YonProject
{
    partial class GirisSayfasi
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
            this.txt_KullaniciNo = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.lbl_KullaniciNo = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.btn_GirisYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_GirisKontrol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_KullaniciNo
            // 
            this.txt_KullaniciNo.Location = new System.Drawing.Point(225, 78);
            this.txt_KullaniciNo.Name = "txt_KullaniciNo";
            this.txt_KullaniciNo.Size = new System.Drawing.Size(100, 20);
            this.txt_KullaniciNo.TabIndex = 0;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(225, 104);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_Sifre.TabIndex = 1;
            // 
            // lbl_KullaniciNo
            // 
            this.lbl_KullaniciNo.AutoSize = true;
            this.lbl_KullaniciNo.Location = new System.Drawing.Point(155, 85);
            this.lbl_KullaniciNo.Name = "lbl_KullaniciNo";
            this.lbl_KullaniciNo.Size = new System.Drawing.Size(70, 13);
            this.lbl_KullaniciNo.TabIndex = 2;
            this.lbl_KullaniciNo.Text = "Kullanıcı Adı :";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(159, 111);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(34, 13);
            this.lbl_Sifre.TabIndex = 3;
            this.lbl_Sifre.Text = "Şifre :";
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.Location = new System.Drawing.Point(225, 130);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(75, 23);
            this.btn_GirisYap.TabIndex = 4;
            this.btn_GirisYap.Text = "Giriş Yap";
            this.btn_GirisYap.UseVisualStyleBackColor = true;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // lbl_GirisKontrol
            // 
            this.lbl_GirisKontrol.AutoSize = true;
            this.lbl_GirisKontrol.Location = new System.Drawing.Point(222, 171);
            this.lbl_GirisKontrol.Name = "lbl_GirisKontrol";
            this.lbl_GirisKontrol.Size = new System.Drawing.Size(0, 13);
            this.lbl_GirisKontrol.TabIndex = 6;
            // 
            // GirisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_GirisKontrol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GirisYap);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_KullaniciNo);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KullaniciNo);
            this.Name = "GirisSayfasi";
            this.Text = "GirisSayfasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_KullaniciNo;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label lbl_KullaniciNo;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.Button btn_GirisYap;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_GirisKontrol;
    }
}