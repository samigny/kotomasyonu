﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;      // access kütüphanesini çagirdik.

namespace kotomasyon
{
    public partial class Form1 : Form
    {                       
        public Form1()
        {
            InitializeComponent();
             
        }
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        private void Form1_Load(object sender, EventArgs e)
        {            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string sifre = textBox2.Text;
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=kutuphanedbase.accdb"); //veritabanı bağlantı dizesi
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanici where k_ad='" + textBox1.Text + "' AND k_sifre='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                this.Hide();
                MessageBox.Show("HOŞGELDİNİZ");
                Form2 f2 = new Form2();
                f2.Show();                
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // form kapanir.
        }
    }
}