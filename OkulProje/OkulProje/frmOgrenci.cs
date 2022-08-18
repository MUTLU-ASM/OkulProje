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

namespace OkulProje
{
    public partial class frmOgrenci : Form
    {
        public frmOgrenci()
        {
            InitializeComponent();
        }
         SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-SBTQ48V\\SQLEXPRESS; Initial Catalog = OkulProje; Integrated Security = True");
        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        private void frmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Kulup",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "KULUPAD";
            comboBox1.ValueMember = "KULUPID";
            comboBox1.DataSource = dt;
            baglanti.Close();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string c="";
            if (radioButton1.Checked==true)
            {
                c = "KIZ";
            }
            if (radioButton2.Checked==true)
            {
                c = "ERKEK";
            }
            ds.OgrenciEkle(txtSoyad.Text, txtAdı.Text,c,byte.Parse(comboBox1.SelectedValue.ToString()));
            MessageBox.Show("Öğrenci Eklendi.");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // txtID.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
