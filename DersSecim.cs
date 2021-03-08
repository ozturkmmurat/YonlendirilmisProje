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
    public partial class DersSecim : Form
    {
        public DersSecim()
        {
            InitializeComponent();
        }
        int Ogretmen_id, Dersİd;
        public string idyakala;


        SqlConnection Baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = ProjectYon; Integrated Security = True");

        private void DersSecim_Load(object sender, EventArgs e)
        {
            TabloDoldur();
            dersKaldırTablosu();
        }
        void TabloDoldur()
        {
            SqlDataAdapter sqlVericekme = new SqlDataAdapter("SELECT tbl_Ders.Ders_id, tbl_Ders.DersAdı, tbl_Ogretmen.Ogretmen_id, tbl_Ogretmen.Ad, tbl_Ogretmen.Soyad FROM tbl_Ders INNER JOIN tbl_Ogretmen ON tbl_Ders.Ders_id = tbl_Ogretmen.Ogretmen_id", Baglanti);
            DataTable sqlVerialma = new DataTable();

            sqlVericekme.Fill(sqlVerialma);
            dataGridDersSec.DataSource = sqlVerialma;
            Baglanti.Close();
        }
        void dersKaldırTablosu()
        {
            SqlDataAdapter sqlVericekme = new SqlDataAdapter("select AD.id,OG.Ad AS OgrenciAdi,DS.DersAdı,OS.Ad AS OgretmenAdi,OS.Soyad AS OgretmenSoyadi from tbl_AlinanDersler AD  INNER JOIN tbl_Ogr OG ON AD.Ogrenci_id = OG.id INNER JOIN tbl_Ogretmen OS ON AD.Ogretmen_id = OS.Ogretmen_id INNER JOIN tbl_Ders DS ON AD.Ders_id = DS.Ders_id where  AD.Ogrenci_id =" + idyakala + "", Baglanti);
            DataTable sqlVerialma = new DataTable();

            sqlVericekme.Fill(sqlVerialma);
            dataGridAlinanDersler.DataSource = sqlVerialma;
            Baglanti.Close();
        }

        void DersAl()
        {
            {

                if (Dersİd != 0 && Ogretmen_id != 0)
                {
                    string sql = "insert into tbl_AlinanDersler(Ogrenci_id,Ders_id,Ogretmen_id) values(@Ogrenci_id,@Ders_id,@Ogretmen_id)";
                    SqlCommand komut = new SqlCommand(sql, Baglanti);
                    komut.Parameters.AddWithValue("@Ders_id", txt_Dersid.Text);
                    komut.Parameters.AddWithValue("@Ogretmen_id", txt_Ogretmenid.Text);
                    komut.Parameters.AddWithValue("@Ogrenci_id", idyakala);

                    Baglanti.Open();
                    komut.ExecuteNonQuery();
                    dersKaldırTablosu();
                    Baglanti.Close();
                    MessageBox.Show("işlem Başarılı");
                }
                else
                {
                    MessageBox.Show("Boş veri");
                }
            }


        
            
          
            
        }
        private void btn_DersAl_Click(object sender, EventArgs e)
        {
           
                
                DersAl();
          
            TabloDoldur();
        }

        private void btn_DersBırak_Click(object sender, EventArgs e)
        {
            if (dataGridAlinanDersler.SelectedRows.Count > 0)
            {
                dataGridAlinanDersler.Rows.RemoveAt(dataGridAlinanDersler.SelectedRows[0].Index);

            }

            else
            {

                MessageBox.Show("Bırakmak istediğiniz dersi seçin ");
            }
        }
        private void dataGridDersSec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_Dersid.Text = dataGridDersSec.CurrentRow.Cells[0].Value.ToString(); 
            txt_Ogretmenid.Text = dataGridDersSec.CurrentRow.Cells[2].Value.ToString(); 

            Dersİd = Convert.ToInt32(dataGridDersSec.CurrentRow.Cells["Ders_id"].Value);
            Ogretmen_id = Convert.ToInt32(dataGridDersSec.CurrentRow.Cells["Ogretmen_id"].Value);




        }
    }
}
