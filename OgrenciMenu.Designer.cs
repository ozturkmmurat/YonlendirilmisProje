
namespace YonProject
{
    partial class OgrenciMenu
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
            this.btn_DersTablosu = new System.Windows.Forms.Button();
            this.btn_AlinanDersler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DersTablosu
            // 
            this.btn_DersTablosu.Location = new System.Drawing.Point(197, 144);
            this.btn_DersTablosu.Name = "btn_DersTablosu";
            this.btn_DersTablosu.Size = new System.Drawing.Size(154, 93);
            this.btn_DersTablosu.TabIndex = 0;
            this.btn_DersTablosu.Text = "Ders Tablosu";
            this.btn_DersTablosu.UseVisualStyleBackColor = true;
            this.btn_DersTablosu.Click += new System.EventHandler(this.btn_DersTablosu_Click);
            // 
            // btn_AlinanDersler
            // 
            this.btn_AlinanDersler.Location = new System.Drawing.Point(467, 144);
            this.btn_AlinanDersler.Name = "btn_AlinanDersler";
            this.btn_AlinanDersler.Size = new System.Drawing.Size(154, 93);
            this.btn_AlinanDersler.TabIndex = 1;
            this.btn_AlinanDersler.Text = "Aldığınız Dersler";
            this.btn_AlinanDersler.UseVisualStyleBackColor = true;
            this.btn_AlinanDersler.Click += new System.EventHandler(this.btn_AlinanDersler_Click);
            // 
            // OgrenciMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AlinanDersler);
            this.Controls.Add(this.btn_DersTablosu);
            this.Name = "OgrenciMenu";
            this.Text = "OgrenciDers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DersTablosu;
        private System.Windows.Forms.Button btn_AlinanDersler;
    }
}