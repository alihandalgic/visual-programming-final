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
    public partial class GrupDers : Form
    {
        public GrupDers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeEkran uyeEkran = new UyeEkran();
            uyeEkran.Show();
            this.Close();
        }

        
    }
}
