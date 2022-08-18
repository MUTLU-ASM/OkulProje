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
    public partial class frmOgrenciNotlar : Form
    {
        public frmOgrenciNotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-SBTQ48V\\SQLEXPRESS; Initial Catalog = OkulProje; Integrated Security = True");

        public string numara;
        private void frmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select d.Ad ,n.Sınav1,n.Sınav2,n.Sınav3,n.Proje,n.Ortalama,n.Durum from Tbl_Dersler d,Tbl_Notlar n where n.DersID=d.DersID and n.OgrenciID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1",numara);
            // this.Text = numara.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
