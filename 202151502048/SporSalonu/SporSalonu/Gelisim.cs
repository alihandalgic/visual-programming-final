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
    public partial class Gelisim : Form
    {
        public Gelisim()
        {
            InitializeComponent();
            label4.Visible = false;
            label5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kilo, boy, sonuc;
            kilo = Convert.ToDouble(textBox1.Text);
            boy = Convert.ToDouble(textBox2.Text);
            sonuc = kilo / (boy * boy);
            label4.Text = sonuc.ToString();
            label4.Visible = true;
            label5.Visible = true;
            if (sonuc < 18)
            {
                label5.Text = "Zayıf";
            }
            else if (sonuc >= 18 && sonuc < 25)
            {
                label5.Text = "Normal";
            }
            else if (sonuc >= 25 && sonuc < 3)
            {
                label5.Text = "Fazla Kilolu";
            }
            else if (sonuc >= 3 && sonuc < 35)
            {
                label5.Text = "Şişman (Obez)- I.Sınıf";
            }
            else if (sonuc >= 35 && sonuc < 4)
            {
                label5.Text = "Şişman (Obez)- II.Sınıf";
            }
            else
            {
                label5.Text = "Şişman (Aşırı Obez)- III.Sınıf";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeEkran uyeEkran = new UyeEkran();
            uyeEkran.Show();
            this.Close();
        }
    }
}
