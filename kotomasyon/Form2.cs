using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kotomasyon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {                
                DialogResult result = MessageBox.Show("kapatmak istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ogrencie = new ogrenciekle();
            ogrencie.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ogrencisil = new Ogrencisil();
            ogrencisil.Show();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ogrencidüzenle = new ogrencidüzenle();
            ogrencidüzenle.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ogrencilistele = new ogrencilistele();
            ogrencilistele.Show();
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form kitapekle = new kitapekle();
            kitapekle.Show();
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form kitapsil = new kitapsil();
            kitapsil.Show();
        }

        private void düzenleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form kitapdüzenle = new kitapdüzenle();
            kitapdüzenle.Show ();
        }

        private void listeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form kitaplistele = new kitaplistele();
            kitaplistele.Show();
        }

        private void kitapVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kitapver = new kitapver();
            kitapver.Show();
        }

        private void geçKalanKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form geckalankitaplar = new geckalankitaplar();
            geckalankitaplar.Show();
        }
    }
}