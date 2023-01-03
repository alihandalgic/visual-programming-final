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
    public partial class Giris : Form
    {
        
        MySqlCommand cmd;
        MySqlDataReader dr;

        public Giris()
        {
            InitializeComponent();
        }
        public static string User;

        MySqlConnection conn = new MySqlConnection("Server = localhost; Database = spordb; username= root; password = ''; ");

        public static string userID;
        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand();
            
            cmd.Connection = conn;
            cmd.CommandText= "SELECT * FROM member where id='" + id.Text + "' AND ucret='" + sifre.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())  
            {
                MessageBox.Show("Giriş Başarıyla Yapıldı.");
                userID = id.Text;
                UyeEkran uyeEkran = new UyeEkran();
                uyeEkran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı T.C Kimlik Numarası veya Şifre Girdiniz.");
                id.Text = "";
                sifre.Text = "";
            }
            conn.Close();








            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            kayit.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
