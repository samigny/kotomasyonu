using System;
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
    public partial class kitapdüzenle : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=" + Application.StartupPath + "\\kutuphanedbase.accdb");
        public kitapdüzenle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update kitap set barkodno='" + textBox1.Text + "', kitapadi='" + textBox2.Text + "', yazari='" + textBox3.Text + "', sayfasayisi='" + textBox4.Text + "', rafno='" + textBox5.Text + "' where barkodno='" + textBox1.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kitap Bilgileri Başarıyla Düzenlendi");
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from kitap where barkodno LIKE '" + textBox1.Text.ToString() + "'", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                textBox2.Text = okuyucu["kitapadi"].ToString();
                textBox3.Text = okuyucu["yazari"].ToString();
                textBox4.Text = okuyucu["sayfasayisi"].ToString();
                textBox5.Text = okuyucu["rafno"].ToString();
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void kitapdüzenle_Load(object sender, EventArgs e)
        {

        }
    }
}
