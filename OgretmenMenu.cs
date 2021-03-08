using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YonProject
{
   
    public partial class OgretmenMenu : Form
    {
        public string idtut;
        public OgretmenMenu()
        {
            InitializeComponent();
        }

        private void btn_Ders_Click(object sender, EventArgs e)
        {

            Ders ders = new Ders();
            ders.Show();

        }

        private void btn_DersAlanOgrenci_Click(object sender, EventArgs e)
        {
            OgretmenDers ogretmenDers = new OgretmenDers();
            ogretmenDers.idyakala = idtut;
            ogretmenDers.Show();

        }
    }
}
