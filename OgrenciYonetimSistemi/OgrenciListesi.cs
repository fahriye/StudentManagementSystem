using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OgrenciYonetimSistemi
{
    public partial class OgrenciListesi : Form
    {
        public OgrenciListesi()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-RAONNEH0;Initial Catalog=OYS;Integrated Security=True");

        DataTable tablo = new DataTable();
        private void listele()
        {
            baglan.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select *from dbo.ogrenci", baglan);
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;

            baglan.Close();

        }
        private void OgrenciListesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oYSDataSet8.ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.oYSDataSet8.ogrenci);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select *from dbo.ogrenci where ad like '"+textBox1.Text+"'or telefon like'"+textBox1.Text+"'", baglan);
            DataTable tablo2 = new DataTable();
            adptr.Fill(tablo2);
            dataGridView1.DataSource = tablo2;

            baglan.Close();

        }
    }
}
