namespace HalisahaRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRezervasyon frm = new frmRezervasyon();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmMusteriler frm = new frmMusteriler();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaha_Click(object sender, EventArgs e)
        {
            frmSahalar frm = new frmSahalar();
            frm.Show();
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            frmOdeme frm = new frmOdeme();
            frm.Show();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            frmRezervasyonDetay frm =
            new frmRezervasyonDetay();

            frm.Show();
        }
    }
}
