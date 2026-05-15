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
    public partial class frmRezervasyonDetay : Form
    {
        public frmRezervasyonDetay()
        {
            InitializeComponent();
        }

        private void btnDetayListele_Click(object sender, EventArgs e)
        {
            RezervasyonDetayBL detayBL = new RezervasyonDetayBL();

            dgvDetaylar.DataSource = detayBL.DetaylariListele();
        }
    }
}
