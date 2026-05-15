namespace HalisahaRezervasyon
{
    partial class frmRezervasyon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtMusteriID = new TextBox();
            txtSahaID = new TextBox();
            txtTarih = new TextBox();
            txtBaslangic = new TextBox();
            txtBitis = new TextBox();
            txtUcret = new TextBox();
            btnRezervasyonEkle = new Button();
            btnRezervasyonListele = new Button();
            dgvRezervasyonlar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRezervasyonlar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 155);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 0;
            label1.Text = "Müşteri ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 199);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 1;
            label2.Text = "Saha ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 236);
            label3.Name = "label3";
            label3.Size = new Size(36, 17);
            label3.TabIndex = 2;
            label3.Text = "Tarih";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(286, 346);
            label6.Name = "label6";
            label6.Size = new Size(39, 17);
            label6.TabIndex = 5;
            label6.Text = "Ücret";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(286, 265);
            label7.Name = "label7";
            label7.Size = new Size(62, 17);
            label7.TabIndex = 3;
            label7.Text = "Başlangıç";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(286, 307);
            label8.Name = "label8";
            label8.Size = new Size(31, 17);
            label8.TabIndex = 4;
            label8.Text = "Bitiş";
            // 
            // txtMusteriID
            // 
            txtMusteriID.Location = new Point(422, 147);
            txtMusteriID.Name = "txtMusteriID";
            txtMusteriID.Size = new Size(100, 25);
            txtMusteriID.TabIndex = 6;
            // 
            // txtSahaID
            // 
            txtSahaID.Location = new Point(422, 191);
            txtSahaID.Name = "txtSahaID";
            txtSahaID.Size = new Size(100, 25);
            txtSahaID.TabIndex = 7;
            // 
            // txtTarih
            // 
            txtTarih.Location = new Point(422, 228);
            txtTarih.Name = "txtTarih";
            txtTarih.Size = new Size(100, 25);
            txtTarih.TabIndex = 8;
            // 
            // txtBaslangic
            // 
            txtBaslangic.Location = new Point(422, 259);
            txtBaslangic.Name = "txtBaslangic";
            txtBaslangic.Size = new Size(100, 25);
            txtBaslangic.TabIndex = 9;
            // 
            // txtBitis
            // 
            txtBitis.Location = new Point(422, 299);
            txtBitis.Name = "txtBitis";
            txtBitis.Size = new Size(100, 25);
            txtBitis.TabIndex = 10;
            txtBitis.TextChanged += txtBitis_TextChanged;
            // 
            // txtUcret
            // 
            txtUcret.Location = new Point(422, 338);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(100, 25);
            txtUcret.TabIndex = 11;
            // 
            // btnRezervasyonEkle
            // 
            btnRezervasyonEkle.Location = new Point(336, 402);
            btnRezervasyonEkle.Name = "btnRezervasyonEkle";
            btnRezervasyonEkle.Size = new Size(133, 23);
            btnRezervasyonEkle.TabIndex = 12;
            btnRezervasyonEkle.Text = "Rezervasyon Ekle";
            btnRezervasyonEkle.UseVisualStyleBackColor = true;
            btnRezervasyonEkle.Click += btnRezervasyonEkle_Click;
            // 
            // btnRezervasyonListele
            // 
            btnRezervasyonListele.Location = new Point(510, 402);
            btnRezervasyonListele.Name = "btnRezervasyonListele";
            btnRezervasyonListele.Size = new Size(173, 23);
            btnRezervasyonListele.TabIndex = 13;
            btnRezervasyonListele.Text = "Rezervasyonları Listele";
            btnRezervasyonListele.UseVisualStyleBackColor = true;
            btnRezervasyonListele.Click += btnRezervasyonListele_Click;
            // 
            // dgvRezervasyonlar
            // 
            dgvRezervasyonlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRezervasyonlar.Location = new Point(-4, 3);
            dgvRezervasyonlar.Name = "dgvRezervasyonlar";
            dgvRezervasyonlar.Size = new Size(802, 138);
            dgvRezervasyonlar.TabIndex = 14;
            // 
            // frmRezervasyon
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvRezervasyonlar);
            Controls.Add(btnRezervasyonListele);
            Controls.Add(btnRezervasyonEkle);
            Controls.Add(txtUcret);
            Controls.Add(txtBitis);
            Controls.Add(txtBaslangic);
            Controls.Add(txtTarih);
            Controls.Add(txtSahaID);
            Controls.Add(txtMusteriID);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRezervasyon";
            Text = "frmRezervasyon";
            ((System.ComponentModel.ISupportInitialize)dgvRezervasyonlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtMusteriID;
        private TextBox txtSahaID;
        private TextBox txtTarih;
        private TextBox txtBaslangic;
        private TextBox txtBitis;
        private TextBox txtUcret;
        private Button btnRezervasyonEkle;
        private Button btnRezervasyonListele;
        private DataGridView dgvRezervasyonlar;
    }
}