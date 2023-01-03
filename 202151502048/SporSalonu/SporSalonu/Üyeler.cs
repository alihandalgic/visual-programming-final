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
    public partial class Üyeler : Form
    {
        public Üyeler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void Üyeler_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
            this.Hide();
        }
        private void filterByName()
        {
            conn.Open();
            string query = "select * from member where adsoyad='" + ara.Text + "';";
            MySqlDataAdapter mysqlda = new MySqlDataAdapter(query, conn);
            MySqlCommandBuilder builder = new MySqlCommandBuilder();
            var ds = new DataSet();
            mysqlda.Fill(ds);
            uyeler.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            filterByName();
        }
    }
}
