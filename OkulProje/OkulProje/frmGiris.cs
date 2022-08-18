using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulProje
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            frmOgrenciNotlar frm = new frmOgrenciNotlar();
            frm.numara = txtNumara.Text;
            frm.Show();
            this.Hide();
        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            frmOgretmen frm = new frmOgretmen();
            frm.Show();
            this.Hide();
        }
    }
}
