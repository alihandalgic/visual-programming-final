using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace SporSalonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server = localhost; Database = blog; Uid = root; Pwd = ''; ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kullanici.Text.Trim() == "" && sifre.Text.Trim() == "") 
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifrenizi Giriniz.");
            }
            else if (kullanici.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı Giriniz.");
            }
            else if (sifre.Text == "")
            {
                MessageBox.Show("Lütfen Şifrenizi Giriniz.");
            }
            else if (kullanici.Text.Trim() == "Alihan" || kullanici.Text.Trim() == "alihan" && sifre.Text.Trim() == "1234")  
            {
                AnaEkran anaEkran = new AnaEkran();
                anaEkran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.");    
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Close();
        }
    }
}
