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
    public partial class frmOgretmen : Form
    {
        public frmOgretmen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKulupİslemleri frm = new frmKulupİslemleri();
            frm.Show();
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            frmDersler frm = new frmDersler();
            frm.Show();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            frmOgrenci frm = new frmOgrenci();
            frm.Show();
        }
    }
}
