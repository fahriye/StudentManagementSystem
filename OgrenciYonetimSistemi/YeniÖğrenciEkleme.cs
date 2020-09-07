using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.DashboardCommon.Native.DashboardRestfulService;
using DevExpress.DashboardWin.Native;


namespace OgrenciYonetimSistemi
{
    public partial class YeniÖğrenciEkleme : Form
    {
        public YeniÖğrenciEkleme()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-RAONNEH0;Initial Catalog=OYS;Integrated Security=True");

        DataTable tablo = new DataTable();
        private void listele()
        {
            baglan.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select *from dbo.ogrenci",baglan);
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            
            baglan.Close();

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void YeniÖğrenciEkleme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oYSDataSet9.ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter6.Fill(this.oYSDataSet9.ogrenci);
          

        }



        private void button1_yukle_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_kaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into dbo.ogrenci(ad,soyad,telefon,adres,numarası,email) values('"+textBox1_ad.Text + "','" + textBox2_soyad.Text + "','" + textBox3_number.Text + "','" + textBox4_adress.Text + "','" + textBox1_No.Text + "','" + textBox1_mail.Text + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt eklendi.","Kayıt");


            for (int i = 0; i <Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    Controls[i].Text = "";
                }
            }
        }

        private void button3_Sil_Click(object sender, EventArgs e)
        {
            
                string constring = "Data Source=LAPTOP-RAONNEH0;Initial Catalog=OYS;Integrated Security=True";
                string query = "delete from dbo.ogrenci where ad='" + this.textBox1_ad.Text + "'";
                SqlConnection condatabase = new SqlConnection(constring);
                SqlCommand cmddatabase = new SqlCommand(query,condatabase);
                SqlDataReader myReader;

                try
                {
                condatabase.Open();
                myReader = cmddatabase.ExecuteReader();
                MessageBox.Show("silindi");
                
                while (myReader.Read())
                {
                    
                }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
