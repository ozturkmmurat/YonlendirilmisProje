
namespace YonProject
{
    partial class OgretmenMenu
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
            this.btn_DersAlanOgrenci = new System.Windows.Forms.Button();
            this.btn_Ders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DersAlanOgrenci
            // 
            this.btn_DersAlanOgrenci.Location = new System.Drawing.Point(446, 139);
            this.btn_DersAlanOgrenci.Name = "btn_DersAlanOgrenci";
            this.btn_DersAlanOgrenci.Size = new System.Drawing.Size(168, 109);
            this.btn_DersAlanOgrenci.TabIndex = 1;
            this.btn_DersAlanOgrenci.Text = "Derslerinizi Alan Öğrenciler";
            this.btn_DersAlanOgrenci.UseVisualStyleBackColor = true;
            this.btn_DersAlanOgrenci.Click += new System.EventHandler(this.btn_DersAlanOgrenci_Click);
            // 
            // btn_Ders
            // 
            this.btn_Ders.Location = new System.Drawing.Point(178, 139);
            this.btn_Ders.Name = "btn_Ders";
            this.btn_Ders.Size = new System.Drawing.Size(168, 109);
            this.btn_Ders.TabIndex = 2;
            this.btn_Ders.Text = "Ders Tablosuna Git";
            this.btn_Ders.UseVisualStyleBackColor = true;
            this.btn_Ders.Click += new System.EventHandler(this.btn_Ders_Click);
            // 
            // OgretmenMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Ders);
            this.Controls.Add(this.btn_DersAlanOgrenci);
            this.Name = "OgretmenMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_DersAlanOgrenci;
        private System.Windows.Forms.Button btn_Ders;
    }
}