using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciYonetimSistemi
{
    public partial class Not_Hesaplamacs : Form
    {
        public Not_Hesaplamacs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double vize, final, ortalama;
            vize = Convert.ToDouble(textBox1.Text);
            final = Convert.ToDouble(textBox2.Text);

            ortalama = vize * 0.4 + final * 0.6;
            textBox3.Text = ortalama.ToString();
            if (vize < 0)
            {
                MessageBox.Show("0 dan küçük not girişi yapılamaz..");
            }

            if (vize > 100)
            {
                MessageBox.Show("100 den büyük not girişi yapılamaz..");
            }

            if (final < 0)
            {
                MessageBox.Show("0 dan küçük not girişi yapılamaz..");

            }

            if (final > 100)
            {
                MessageBox.Show("100 den büyük not girişi yapılamaz..");
            }
        }
    }
}
