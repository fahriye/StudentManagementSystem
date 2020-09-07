using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciYonetimSistemi
{
    public partial class Ogrenci_Notları : Form
    {
        public Ogrenci_Notları()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=LAPTOP-RAONNEH0;Initial Catalog=OYS;Integrated Security=True");
        
        DataTable tablo1 = new DataTable();
        private void listele1()
        {
            baglantı.Open();
            SqlDataAdapter dptr = new SqlDataAdapter("select *from dbo.notlar", baglantı);
            dptr.Fill(tablo1);
            dataGridView1.DataSource = tablo1;

            baglantı.Close();

        }
        private void Ogrenci_Notları_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oYSDataSet17.notlar' table. You can move, or remove it, as needed.
            this.notlarTableAdapter3.Fill(this.oYSDataSet17.notlar);
            // TODO: This line of code loads data into the 'oYSDataSet16.notlar' table. You can move, or remove it, as needed.
            this.notlarTableAdapter2.Fill(this.oYSDataSet16.notlar);
            // TODO: This line of code loads data into the 'oYSDataSet15.notlar' table. You can move, or remove it, as needed.
            this.notlarTableAdapter1.Fill(this.oYSDataSet15.notlar);
            // TODO: This line of code loads data into the 'oYSDataSet14.notlar' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'oYSDataSet10.notlar' table. You can move, or remove it, as needed.


            baglantı.Open();
            SqlCommand kmt = new SqlCommand("Select ad from dbo.ogrenci",baglantı);
            SqlDataReader rd = kmt.ExecuteReader();
            while (rd.Read())
            {
                comboBox1.Items.Add(rd[0]);
               
            }
           baglantı.Close();



         

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand kmt1 = new SqlCommand("Select soyad from dbo.ogrenci where ad=@p1", baglantı);
            kmt1.Parameters.AddWithValue("@p1", comboBox1.SelectedText);
            SqlDataReader dr = kmt1.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);

            }
            baglantı.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("insert into dbo.notlar(ad,soyad,nott) values('" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox3_number.Text + "')", baglantı);
            komut2.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kayıt eklendi.", "Kayıt");


            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    Controls[i].Text = "";
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string constrin = "Data Source=LAPTOP-RAONNEH0;Initial Catalog=OYS;Integrated Security=True";
            string quer = "delete from dbo.notlar where ad='" + this.comboBox1.Text + "'";
            SqlConnection condatabas = new SqlConnection(constrin);
            SqlCommand cmddatabas = new SqlCommand(quer, condatabas);
            SqlDataReader myReader;

            try
            {
                condatabas.Open();
                myReader = cmddatabas.ExecuteReader();
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
    }
}
