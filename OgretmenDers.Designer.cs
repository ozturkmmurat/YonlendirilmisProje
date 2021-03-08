
namespace YonProject
{
    partial class OgretmenDers
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
            this.dataGrid_VerilenDersListesi = new System.Windows.Forms.DataGridView();
            this.dataGrid_DersAlanlarinListesi = new System.Windows.Forms.DataGridView();
            this.lbl_Dersalanlar = new System.Windows.Forms.Label();
            this.lbl_VerilenDersler = new System.Windows.Forms.Label();
            this.btn_OgrenciyiCikar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_VerilenDersListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DersAlanlarinListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_VerilenDersListesi
            // 
            this.dataGrid_VerilenDersListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_VerilenDersListesi.Location = new System.Drawing.Point(-2, 34);
            this.dataGrid_VerilenDersListesi.Name = "dataGrid_VerilenDersListesi";
            this.dataGrid_VerilenDersListesi.Size = new System.Drawing.Size(802, 150);
            this.dataGrid_VerilenDersListesi.TabIndex = 0;
            // 
            // dataGrid_DersAlanlarinListesi
            // 
            this.dataGrid_DersAlanlarinListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_DersAlanlarinListesi.Location = new System.Drawing.Point(-2, 303);
            this.dataGrid_DersAlanlarinListesi.Name = "dataGrid_DersAlanlarinListesi";
            this.dataGrid_DersAlanlarinListesi.Size = new System.Drawing.Size(802, 150);
            this.dataGrid_DersAlanlarinListesi.TabIndex = 1;
            // 
            // lbl_Dersalanlar
            // 
            this.lbl_Dersalanlar.AutoSize = true;
            this.lbl_Dersalanlar.Location = new System.Drawing.Point(12, 259);
            this.lbl_Dersalanlar.Name = "lbl_Dersalanlar";
            this.lbl_Dersalanlar.Size = new System.Drawing.Size(111, 13);
            this.lbl_Dersalanlar.TabIndex = 2;
            this.lbl_Dersalanlar.Text = "Derslerinizi Alan Kişiler";
            // 
            // lbl_VerilenDersler
            // 
            this.lbl_VerilenDersler.AutoSize = true;
            this.lbl_VerilenDersler.Location = new System.Drawing.Point(12, 18);
            this.lbl_VerilenDersler.Name = "lbl_VerilenDersler";
            this.lbl_VerilenDersler.Size = new System.Drawing.Size(91, 13);
            this.lbl_VerilenDersler.TabIndex = 3;
            this.lbl_VerilenDersler.Text = "Verilebilen Dersler";
            // 
            // btn_OgrenciyiCikar
            // 
            this.btn_OgrenciyiCikar.Location = new System.Drawing.Point(12, 275);
            this.btn_OgrenciyiCikar.Name = "btn_OgrenciyiCikar";
            this.btn_OgrenciyiCikar.Size = new System.Drawing.Size(132, 23);
            this.btn_OgrenciyiCikar.TabIndex = 4;
            this.btn_OgrenciyiCikar.Text = "Öğrenciyi Dersten Çıkar";
            this.btn_OgrenciyiCikar.UseVisualStyleBackColor = true;
            this.btn_OgrenciyiCikar.Click += new System.EventHandler(this.btn_OgrenciyiCikar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // OgretmenDers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_OgrenciyiCikar);
            this.Controls.Add(this.lbl_VerilenDersler);
            this.Controls.Add(this.lbl_Dersalanlar);
            this.Controls.Add(this.dataGrid_DersAlanlarinListesi);
            this.Controls.Add(this.dataGrid_VerilenDersListesi);
            this.Name = "OgretmenDers";
            this.Text = "OgretmenDers";
            this.Load += new System.EventHandler(this.OgretmenDers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_VerilenDersListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DersAlanlarinListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_VerilenDersListesi;
        private System.Windows.Forms.DataGridView dataGrid_DersAlanlarinListesi;
        private System.Windows.Forms.Label lbl_Dersalanlar;
        private System.Windows.Forms.Label lbl_VerilenDersler;
        private System.Windows.Forms.Button btn_OgrenciyiCikar;
        public System.Windows.Forms.Label label1;
    }
}