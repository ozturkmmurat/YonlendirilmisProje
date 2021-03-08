using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace YonProject
{
    public partial class Ders : Form
    {
        public Ders()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = ProjectYon; Integrated Security = True");
        private void Ders_Load(object sender, EventArgs e)
        {
            DersTablosu();

        }
        void DersTablosu()
        {

            SqlDataAdapter sqlVericekme = new SqlDataAdapter("SELECT dbo.tbl_Ders.DersAdı, dbo.tbl_Ogretmen.Ad AS OgretmenAd, dbo.tbl_Ogretmen.Soyad AS OgretmenSoyad FROM  dbo.tbl_Ders INNER JOIN  dbo.tbl_VerilenDersler ON dbo.tbl_Ders.Ders_id = dbo.tbl_VerilenDersler.Ders_id INNER JOIN  dbo.tbl_Ogretmen ON dbo.tbl_VerilenDersler.Ogretmen_id = dbo.tbl_Ogretmen.Ogretmen_id", Baglanti);
            DataTable sqlVerialma = new DataTable();

            sqlVericekme.Fill(sqlVerialma);
            dataGridDers.DataSource = sqlVerialma;
            Baglanti.Close();
        }

        private void dataGridDers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
