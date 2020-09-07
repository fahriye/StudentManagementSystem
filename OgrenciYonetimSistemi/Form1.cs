using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OgrenciYonetimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn =
                new SqlConnection(@"Data Source=LAPTOP-RAONNEH0;Initial Catalog=OYS;Integrated Security=True");
            string query = "Select * from dbo.giris Where Kullanıcıadı = '" + textBox1.Text.Trim() +"' and Sifre = '" +
                           textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query,conn);
            DataTable dttbl = new DataTable();
            sda.Fill(dttbl);
            if (dttbl.Rows.Count==1)
            {
                Form2 obj = new Form2();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("kullanıcı adı ve şifreyi yeniden deneyiniz..");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
