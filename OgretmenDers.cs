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
    public partial class OgretmenDers : Form
    {

        public string idyakala;

        public OgretmenDers()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = ProjectYon; Integrated Security = True");
        private void OgretmenDers_Load(object sender, EventArgs e)
        {

           
            VerilenDersTablosu();
            DersAlanlarListesi();
           
        }

        void VerilenDersTablosu()
        {
            
            SqlDataAdapter sqlVericekme = new SqlDataAdapter("SELECT tbl_Ders.DersAdı  FROM tbl_Ders INNER JOIN tbl_Ogretmen ON tbl_Ders.Ders_id = tbl_Ogretmen.Ogretmen_id where  tbl_Ogretmen.Ogretmen_id ='" + idyakala+ "'", Baglanti);
            DataTable sqlVerialma = new DataTable();

                sqlVericekme.Fill(sqlVerialma);
                dataGrid_VerilenDersListesi.DataSource = sqlVerialma;
                Baglanti.Close();
            }

        void DersAlanlarListesi()
        {

            SqlDataAdapter sqlVericekme = new SqlDataAdapter("select AD.id,OG.Ad AS OgrenciAdi,DS.DersAdı  from tbl_AlinanDersler AD INNER JOIN tbl_Ogr OG ON AD.Ogrenci_id = OG.id INNER JOIN tbl_Ogretmen OS ON AD.Ogretmen_id = OS.Ogretmen_id INNER JOIN tbl_Ders DS ON AD.Ders_id = DS.Ders_id where  OS.Ogretmen_id = '"+ idyakala +"'", Baglanti);
            DataTable sqlVerialma = new DataTable();

            sqlVericekme.Fill(sqlVerialma);
            dataGrid_DersAlanlarinListesi.DataSource = sqlVerialma;
            Baglanti.Close();
        }

        private void btn_OgrenciyiCikar_Click(object sender, EventArgs e)
        {
            if (dataGrid_DersAlanlarinListesi.SelectedRows.Count > 0)
            {
                dataGrid_DersAlanlarinListesi.Rows.RemoveAt(dataGrid_DersAlanlarinListesi.SelectedRows[0].Index);

            }

            else
            {

                MessageBox.Show("Dersten Çıkarmak İstediğiniz Öğrenciyi Seçiniz.");
            }
        }
    }
}
