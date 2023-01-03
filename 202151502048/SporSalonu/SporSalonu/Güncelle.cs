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
    public partial class Güncelle : Form
    {
        
        public Güncelle()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("Server = localhost; Database = spordb; username= root; password = ''; ");
        private void populate()
        {
            conn.Open();
            string query = "select * from member";
            MySqlDataAdapter mysqlda = new MySqlDataAdapter(query, conn);
            MySqlCommandBuilder builder = new MySqlCommandBuilder();
            var ds = new DataSet();
            mysqlda.Fill(ds);
            uyeler.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void Güncelle_Load(object sender, EventArgs e)
        {
            populate();
        }

        int key=0;

        

        private void button3_Click(object sender, EventArgs e)
        {
            
            id.Text = "";
            adsoyad.Text = "";
            tel.Text = "";
            yas.Text = "";
            cins.Text = "";
            sifre.Text = "";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Lütfen Silinmesini İstediğiniz Üyeyi Seçiniz.");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "delete from member where id=" + key + ";";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye Kaydı Başarıyla Silindi.");
                    conn.Close();
                    populate();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0 || adsoyad.Text == "" || tel.Text == "" || yas.Text == "" || sifre.Text == "" || cins.Text == "") 
            {
                MessageBox.Show("Lütfen Güncellenmesini İstediğiniz Üyeyi Seçiniz.");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "update member set id='" + id.Text + "',adsoyad='" + adsoyad.Text + "',tel='" + tel.Text + "',cins='" + cins.Text + "',yas='" + yas.Text + "',ucret='" + sifre.Text + "' where id=" + key + ";";
                    
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye Kaydı Başarıyla Güncellendi.");
                    conn.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    Güncelle güncelle = new Güncelle();
                    güncelle.Show();
                    this.Hide();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uyeler_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            key = Convert.ToInt32(uyeler.CurrentRow.Cells[0].Value);
            id.Text = uyeler.CurrentRow.Cells[0].Value.ToString();
            adsoyad.Text = uyeler.CurrentRow.Cells[1].Value.ToString();
            tel.Text = uyeler.CurrentRow.Cells[2].Value.ToString();
            yas.Text = uyeler.CurrentRow.Cells[4].Value.ToString();
            cins.Text = uyeler.CurrentRow.Cells[3].Value.ToString();
            sifre.Text = uyeler.CurrentRow.Cells[5].Value.ToString();
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void yas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
