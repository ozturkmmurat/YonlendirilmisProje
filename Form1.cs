﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = ProjectYon; Integrated Security = True");
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
