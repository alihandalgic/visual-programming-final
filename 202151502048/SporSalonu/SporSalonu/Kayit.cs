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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("Server = localhost; Database = spordb; username= root; password = ''; ");
        private void button1_Click(object sender, EventArgs e)
        {
            

            if (id.Text == "" || adsoyad.Text == "" || tel.Text == "" || cins.Text == "" || yas.Text == "" || sifre.Text == "") 
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
            else 
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO member VALUES('" + id.Text + "','" + adsoyad.Text + "','" + tel.Text + "','" + cins.SelectedItem.ToString() + "','" + yas.Text + "','" + sifre.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye Kaydı Başarıyla Yapıldı.");
                    conn.Close();
                    id.Text = "";
                    adsoyad.Text = "";
                    tel.Text = "";
                    cins.Text = "";
                    yas.Text = "";
                    sifre.Text = "";
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                    Kayit kayit = new Kayit();
                    kayit.Show();
                    this.Hide();
                }

            }
            
        }

        

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Close();
        }

        private void tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void yas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
