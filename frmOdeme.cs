using HalisahaRezervasyon.Business;
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
    public partial class frmOdeme : Form
    {
        public frmOdeme()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvOdemeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOdemeEkle_Click(object sender, EventArgs e)
        {
            OdemeBL odemeBL = new OdemeBL();

            odemeBL.OdemeEkle(
                int.Parse(txtRezervasyonID.Text),
                txtOdemeTarih.Text,
                float.Parse(txtOdemeTutar.Text),
                txtAciklama.Text
            );

            MessageBox.Show("Ödeme eklendi.");

            dgvOdemeler.DataSource =
                odemeBL.OdemeleriListele();
        }

        private void btnOdemeListele_Click(object sender, EventArgs e)
        {
            OdemeBL odemeBL = new OdemeBL();

            dgvOdemeler.DataSource =
                odemeBL.OdemeleriListele();
        }
    }
}
