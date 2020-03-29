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
    public partial class kitapver : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=" + Application.StartupPath + "\\kutuphanedbase.accdb");

        public kitapver()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from ogrenci where tcno LIKE '" + textBox1.Text.ToString() + "'", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                textBox2.Text = okuyucu["adi"].ToString();
                textBox3.Text = okuyucu["soyadi"].ToString();
                textBox4.Text = okuyucu["telefon"].ToString();
                textBox5.Text = okuyucu["adres"].ToString();
            }
            baglanti.Close();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Open) /* Eğer açık bir bağlantı varsa kapatma işlemini uyguluyoruz.*/
            {
                baglanti.Close();
            }
            try
            {
                baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from kitap where barkodno LIKE '" + textBox10.Text.ToString() + "'", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();            
                while (okuyucu.Read())
                {

                    textBox10.Text = okuyucu["kitapadi"].ToString();
                    textBox9.Text = okuyucu["yazar"].ToString();
                    textBox8.Text = okuyucu["sayfasayisi"].ToString();
                    textBox7.Text = okuyucu["rafno"].ToString();

                }
                baglanti.Close();
            }
            catch { }
            }
        private void button2_Click(object sender, EventArgs e)
        {
            { 
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into kitapver (tcno,adi,soyadi,telefon,adres,barkodno,kitapadi,yazar,sayfasayisi,rafno,verilistarihi,teslimtarihi) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + dateTimePicker1 + "','" + dateTimePicker1 + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Kaydedildi");
                baglanti.Close();
            }
        }

        private void kitapver_Load(object sender, EventArgs e)
        {

        }
    }
}
