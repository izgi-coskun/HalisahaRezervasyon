using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalisahaRezervasyon.Business;

namespace HalisahaRezervasyon
{
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            MusteriBL musteriBL = new MusteriBL();
            dgvMusteriler.DataSource = musteriBL.MusterileriListele();
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MusteriBL musteriBL = new MusteriBL();

            musteriBL.MusteriEkle(txtAd.Text, txtSoyad.Text);

            MessageBox.Show("Müşteri eklendi.");
            dgvMusteriler.DataSource = musteriBL.MusterileriListele();
        }
    }
}
