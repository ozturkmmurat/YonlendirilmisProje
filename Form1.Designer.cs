
namespace YonProject
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
            this.lbl_No = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.txt_No = new System.Windows.Forms.MaskedTextBox();
            this.txt_Sifre = new System.Windows.Forms.MaskedTextBox();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.Location = new System.Drawing.Point(209, 98);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(21, 13);
            this.lbl_No.TabIndex = 0;
            this.lbl_No.Text = "No";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(209, 144);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(28, 13);
            this.lbl_Sifre.TabIndex = 1;
            this.lbl_Sifre.Text = "Şifre";
            // 
            // txt_No
            // 
            this.txt_No.Location = new System.Drawing.Point(282, 91);
            this.txt_No.Name = "txt_No";
            this.txt_No.Size = new System.Drawing.Size(100, 20);
            this.txt_No.TabIndex = 2;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(282, 141);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_Sifre.TabIndex = 3;
            // 
            // btn_Giris
            // 
            this.btn_Giris.Location = new System.Drawing.Point(282, 184);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(75, 23);
            this.btn_Giris.TabIndex = 4;
            this.btn_Giris.Text = "Giriş Yap";
            this.btn_Giris.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_No);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_No);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_No;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.MaskedTextBox txt_No;
        private System.Windows.Forms.MaskedTextBox txt_Sifre;
        private System.Windows.Forms.Button btn_Giris;
    }
}

