using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonu
{
    public partial class UyeEkran : Form
    {
        public UyeEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Giris giris = new Giris();
            giris.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Gelisim gelisim = new Gelisim();
            gelisim.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Antreman2 antreman2 = new Antreman2();
            antreman2.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Antreman antreman = new Antreman();
            antreman.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Antreman3 antreman3 = new Antreman3();
            antreman3.Show();
            this.Hide();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            GrupDers grupDers = new GrupDers();
            grupDers.Show();
            this.Hide();
        }
    }
}
