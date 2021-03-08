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
    public partial class OgrenciMenu : Form
    {
        public string idtut;
        public OgrenciMenu()
        {
            InitializeComponent();
        }

        private void btn_DersTablosu_Click(object sender, EventArgs e)
        {
            Ders ders = new Ders();
            ders.Show();
        }

        private void btn_AlinanDersler_Click(object sender, EventArgs e)
        {
            DersSecim dersSecim = new DersSecim();
            dersSecim.idyakala = idtut;
            dersSecim.Show();
        }
    }
}
