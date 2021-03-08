
namespace YonProject
{
    partial class DersSecim
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
            this.dataGridDersSec = new System.Windows.Forms.DataGridView();
            this.dataGridAlinanDersler = new System.Windows.Forms.DataGridView();
            this.btn_DersAl = new System.Windows.Forms.Button();
            this.btn_DersBırak = new System.Windows.Forms.Button();
            this.txt_Ogretmenid = new System.Windows.Forms.TextBox();
            this.txt_Dersid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDersSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlinanDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDersSec
            // 
            this.dataGridDersSec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDersSec.Location = new System.Drawing.Point(0, 0);
            this.dataGridDersSec.Name = "dataGridDersSec";
            this.dataGridDersSec.Size = new System.Drawing.Size(540, 150);
            this.dataGridDersSec.TabIndex = 0;
            this.dataGridDersSec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDersSec_CellContentClick);
            // 
            // dataGridAlinanDersler
            // 
            this.dataGridAlinanDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlinanDersler.Location = new System.Drawing.Point(0, 298);
            this.dataGridAlinanDersler.Name = "dataGridAlinanDersler";
            this.dataGridAlinanDersler.Size = new System.Drawing.Size(806, 150);
            this.dataGridAlinanDersler.TabIndex = 1;
            // 
            // btn_DersAl
            // 
            this.btn_DersAl.Location = new System.Drawing.Point(23, 156);
            this.btn_DersAl.Name = "btn_DersAl";
            this.btn_DersAl.Size = new System.Drawing.Size(75, 23);
            this.btn_DersAl.TabIndex = 2;
            this.btn_DersAl.Text = "Ders Al";
            this.btn_DersAl.UseVisualStyleBackColor = true;
            this.btn_DersAl.Click += new System.EventHandler(this.btn_DersAl_Click);
            // 
            // btn_DersBırak
            // 
            this.btn_DersBırak.Location = new System.Drawing.Point(23, 269);
            this.btn_DersBırak.Name = "btn_DersBırak";
            this.btn_DersBırak.Size = new System.Drawing.Size(75, 23);
            this.btn_DersBırak.TabIndex = 3;
            this.btn_DersBırak.Text = "Ders Bırak";
            this.btn_DersBırak.UseVisualStyleBackColor = true;
            this.btn_DersBırak.Click += new System.EventHandler(this.btn_DersBırak_Click);
            // 
            // txt_Ogretmenid
            // 
            this.txt_Ogretmenid.Location = new System.Drawing.Point(688, 12);
            this.txt_Ogretmenid.Name = "txt_Ogretmenid";
            this.txt_Ogretmenid.Size = new System.Drawing.Size(100, 20);
            this.txt_Ogretmenid.TabIndex = 5;
            // 
            // txt_Dersid
            // 
            this.txt_Dersid.Location = new System.Drawing.Point(688, 38);
            this.txt_Dersid.Name = "txt_Dersid";
            this.txt_Dersid.Size = new System.Drawing.Size(100, 20);
            this.txt_Dersid.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Öğretmen İd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ders İd";
            // 
            // DersSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Dersid);
            this.Controls.Add(this.txt_Ogretmenid);
            this.Controls.Add(this.btn_DersBırak);
            this.Controls.Add(this.btn_DersAl);
            this.Controls.Add(this.dataGridAlinanDersler);
            this.Controls.Add(this.dataGridDersSec);
            this.Name = "DersSecim";
            this.Text = "DersSecim";
            this.Load += new System.EventHandler(this.DersSecim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDersSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlinanDersler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDersSec;
        private System.Windows.Forms.DataGridView dataGridAlinanDersler;
        private System.Windows.Forms.Button btn_DersAl;
        private System.Windows.Forms.Button btn_DersBırak;
        private System.Windows.Forms.TextBox txt_Ogretmenid;
        private System.Windows.Forms.TextBox txt_Dersid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}