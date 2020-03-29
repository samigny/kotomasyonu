﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kotomasyon
{
    public partial class kitaplistele : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=" + Application.StartupPath + "\\kutuphanedbase.accdb");
        DataTable tablo = new DataTable();
        public kitaplistele()
        {
            InitializeComponent();
        }

        private void kitaplistele_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adaptr = new OleDbDataAdapter("select * from kitap", baglanti);
            adaptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
