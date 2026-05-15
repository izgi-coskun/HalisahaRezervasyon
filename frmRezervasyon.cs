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

namespace HalisahaRezervasyon
{
    public partial class frmRezervasyon : Form
    {
        public frmRezervasyon()
        {
            InitializeComponent();
        }

        private void btnRezervasyonEkle_Click(object sender, EventArgs e)
        {
            RezervasyonBL rezervasyonBL = new RezervasyonBL();

            rezervasyonBL.RezervasyonEkle(
                int.Parse(txtMusteriID.Text),
                int.Parse(txtSahaID.Text),
              txtTarih.Text,
             txtBaslangic.Text,
             txtBitis.Text,
             float.Parse(txtUcret.Text)
            );

            MessageBox.Show("Rezervasyon eklendi.");

            dgvRezervasyonlar.DataSource = rezervasyonBL.RezervasyonlariListele();
        }

        private void btnRezervasyonListele_Click(object sender, EventArgs e)
        {
            RezervasyonBL rezervasyonBL = new RezervasyonBL();

            dgvRezervasyonlar.DataSource =
                rezervasyonBL.RezervasyonlariListele();
        }

        private void txtBitis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
