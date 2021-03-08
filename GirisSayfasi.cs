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
    public partial class GirisSayfasi : Form
    {
        SqlConnection Baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = ProjectYon; Integrated Security = True");
        SqlDataReader oku;
        OgretmenDers ogretmenDers = new OgretmenDers();
        string ogretmenİd;
        public GirisSayfasi()
        {
            InitializeComponent();
        }


        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            if(txt_KullaniciNo.Text != "" && txt_Sifre.Text != "")
            {
                OgrenciGiris();
                OgretmenGiris();
            }
            else
            {
                MessageBox.Show("Lütfen gerekli yerleri doldurunuz.");
            }
            
        }
        public void OgretmenGiris()
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = Baglanti;
            Baglanti.Open();
            komut.CommandText = "SELECT * FROM tbl_OgretmenGiris where No='" + txt_KullaniciNo.Text + "' AND Sifre='" + txt_Sifre.Text + "' ";
            oku = komut.ExecuteReader();

            if (oku.Read())
            {
                OgretmenMenu ogretmenMenu = new OgretmenMenu();
                OgretmenDers ogretmenDers = new OgretmenDers();
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız. ");

                string sorgu = "Select id from tbl_OgretmenGiris";
                string deger;
                Baglanti.Close();
                SqlCommand komut2 = new SqlCommand(sorgu, Baglanti);
                Baglanti.Open();
                deger = Convert.ToString(komut2.ExecuteScalar());
                Baglanti.Close();

                ogretmenİd = deger;
                ogretmenMenu.idtut = ogretmenİd;

                MessageBox.Show(ogretmenİd);
                ogretmenMenu.Show();

                this.Hide();
            }
            else
            {
                lbl_GirisKontrol.Text = "Kullanıcı adını ve şifrenizi kontrol ediniz.";
            }
            Baglanti.Close();
        }

        public void OgrenciGiris()
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = Baglanti;
            Baglanti.Open();
            komut.CommandText = "SELECT * FROM tbl_OgrenciGiris where No='" + txt_KullaniciNo.Text + "' AND Sifre='" + txt_Sifre.Text + "' ";
            oku = komut.ExecuteReader();

            if (oku.Read())
            {
                OgrenciMenu  ogrenciMenu= new OgrenciMenu();
                OgretmenDers ogretmenDers = new OgretmenDers();
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız. ");

                string sorgu = "Select id from tbl_OgretmenGiris";
                string deger;
                Baglanti.Close();
                SqlCommand komut2 = new SqlCommand(sorgu, Baglanti);
                Baglanti.Open();
                deger = Convert.ToString(komut2.ExecuteScalar());
                Baglanti.Close();

                ogretmenİd = deger;
                ogrenciMenu.idtut = ogretmenİd;

                MessageBox.Show(ogretmenİd);
                ogrenciMenu.Show();

                this.Hide();
            }
            else
            {
                lbl_GirisKontrol.Text = "Kullanıcı adını ve şifrenizi kontrol ediniz.";
            }
            Baglanti.Close();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            
            //ogretmenDers.Form2ye_Gidecek_Veri = "Form2'ye Gönderdiğim Veri";
            
        }
    }
}
