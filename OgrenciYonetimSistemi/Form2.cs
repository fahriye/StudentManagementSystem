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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dashboardDesigner4_Load(object sender, EventArgs e)
        {

        }

        private void yeniÖğrenciEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniÖğrenciEkleme yeniÖğrenci = new YeniÖğrenciEkleme();
            yeniÖğrenci.Show(this);
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciListesi listele = new OgrenciListesi();
            listele.Show(this);
        }

        private void nOTLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void dersListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersListesi derslistesi = new DersListesi();
            derslistesi.Show();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nOTHESAPLAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Not_Hesaplamacs not = new Not_Hesaplamacs();
            not.Show();
        }

        private void öĞRENCİNOTLARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ogrenci_Notları Notlar = new Ogrenci_Notları();
            Notlar.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
