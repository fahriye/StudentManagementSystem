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
    public partial class DersListesi : Form
    {
        public DersListesi()
        {
            InitializeComponent();
        }

        private void DersListesi_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void eLEKTRİKVEELEKTRONİKMÜHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bİLGİSAYARMÜHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BilgisayarMüh blg = new BilgisayarMüh();
            blg.Show();
            this.Hide();
        }
    }
}
