using HalisahaRezervasyon.Business;
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
    public partial class frmSahalar : Form
    {
        public frmSahalar()
        {
            InitializeComponent();
        }

        private void btnSahaEkle_Click(object sender, EventArgs e)
        {
            SahaBL sahaBL = new SahaBL();

            sahaBL.SahaEkle(
                txtSahaAd.Text,
                float.Parse(txtUcret.Text)
            );

            MessageBox.Show("Saha eklendi.");

            dgvSahalar.DataSource = sahaBL.SahalariListele();
        }

        private void btnSahaListele_Click(object sender, EventArgs e)
        {
            SahaBL sahaBL = new SahaBL();

            dgvSahalar.DataSource = sahaBL.SahalariListele();
        }
    }
}
