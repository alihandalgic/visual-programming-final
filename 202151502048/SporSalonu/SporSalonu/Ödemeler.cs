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
    public partial class Ödemeler : Form
    {
        public Ödemeler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Close();

        }

        MySqlConnection conn = new MySqlConnection("Server = localhost; Database = spordb; username= root; password = ''; ");
        private void FillName()
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select adsoyad from member", conn);
            MySqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("adsoyad", typeof(string));
            dt.Load(rdr);
            adsoyad.ValueMember = "adsoyad";
            adsoyad.DataSource = dt;
            conn.Close();
        }

        private void populate()
        {
            conn.Open();
            string query = "select * from odeme";
            MySqlDataAdapter mysqlda = new MySqlDataAdapter(query, conn);
            MySqlCommandBuilder builder = new MySqlCommandBuilder();
            var ds = new DataSet();
            mysqlda.Fill(ds);
            dgwOdeme.DataSource = ds.Tables[0];
            conn.Close();
        }

            private void button5_Click(object sender, EventArgs e)
        {
            //Adsoy.Text = "";
            ucret.Text = "";
        }

        private void Ödemeler_Load(object sender, EventArgs e)
        {
            FillName();
            populate();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            if (adsoyad.Text == "" || ucret.Text == "") 
            {
                MessageBox.Show("Lütfen Belirli Alanları Doldurunuz.");
            }
            else
            {
                string odemeTarihi = odemetar.Value.Month.ToString()+ "/" + odemetar.Value.Year.ToString();
                conn.Open();
                MySqlDataAdapter mysqda = new MySqlDataAdapter("select count(*) from odeme where uye='" + adsoyad.SelectedValue.ToString() + "' and ay='" + odemeTarihi + "'", conn);
                DataTable dt = new DataTable();
                mysqda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1") 
                {
                    MessageBox.Show("Bu Ayki Ücret Daha Önceden Ödenmiş.");
                }
                else
                {
                    string query = $"INSERT INTO odeme(ay,uye,ucret) VALUES('{odemeTarihi}','{adsoyad.Text}','{ucret.Text}')";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ödeme Başarıyla Alındı");
                }
                conn.Close();
                populate();
            }
        }

        private void ucret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
