namespace HalisahaRezervasyon
{
    partial class frmOdeme
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
            label4 = new Label();
            txtRezervasyonID = new TextBox();
            txtOdemeTarih = new TextBox();
            txtOdemeTutar = new TextBox();
            txtAciklama = new TextBox();
            btnOdemeEkle = new Button();
            btnOdemeListele = new Button();
            dgvOdemeler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOdemeler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 166);
            label1.Name = "label1";
            label1.Size = new Size(97, 17);
            label1.TabIndex = 0;
            label1.Text = "Rezervasyon ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 192);
            label2.Name = "label2";
            label2.Size = new Size(86, 17);
            label2.TabIndex = 1;
            label2.Text = "Ödeme Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 228);
            label3.Name = "label3";
            label3.Size = new Size(88, 17);
            label3.TabIndex = 2;
            label3.Text = "Ödeme Tutarı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 259);
            label4.Name = "label4";
            label4.Size = new Size(59, 17);
            label4.TabIndex = 3;
            label4.Text = "Açıklama";
            label4.Click += label4_Click;
            // 
            // txtRezervasyonID
            // 
            txtRezervasyonID.Location = new Point(354, 158);
            txtRezervasyonID.Name = "txtRezervasyonID";
            txtRezervasyonID.Size = new Size(100, 25);
            txtRezervasyonID.TabIndex = 4;
            // 
            // txtOdemeTarih
            // 
            txtOdemeTarih.Location = new Point(354, 189);
            txtOdemeTarih.Name = "txtOdemeTarih";
            txtOdemeTarih.Size = new Size(100, 25);
            txtOdemeTarih.TabIndex = 5;
            // 
            // txtOdemeTutar
            // 
            txtOdemeTutar.Location = new Point(354, 220);
            txtOdemeTutar.Name = "txtOdemeTutar";
            txtOdemeTutar.Size = new Size(100, 25);
            txtOdemeTutar.TabIndex = 6;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(354, 251);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(100, 25);
            txtAciklama.TabIndex = 7;
            // 
            // btnOdemeEkle
            // 
            btnOdemeEkle.Location = new Point(354, 298);
            btnOdemeEkle.Name = "btnOdemeEkle";
            btnOdemeEkle.Size = new Size(115, 42);
            btnOdemeEkle.TabIndex = 8;
            btnOdemeEkle.Text = "Ödeme Ekle";
            btnOdemeEkle.UseVisualStyleBackColor = true;
            btnOdemeEkle.Click += btnOdemeEkle_Click;
            // 
            // btnOdemeListele
            // 
            btnOdemeListele.Location = new Point(354, 359);
            btnOdemeListele.Name = "btnOdemeListele";
            btnOdemeListele.Size = new Size(115, 50);
            btnOdemeListele.TabIndex = 9;
            btnOdemeListele.Text = "Ödemeleri Listele";
            btnOdemeListele.UseVisualStyleBackColor = true;
            btnOdemeListele.Click += btnOdemeListele_Click;
            // 
            // dgvOdemeler
            // 
            dgvOdemeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOdemeler.Location = new Point(-7, 3);
            dgvOdemeler.Name = "dgvOdemeler";
            dgvOdemeler.Size = new Size(808, 149);
            dgvOdemeler.TabIndex = 10;
            dgvOdemeler.CellContentClick += dgvOdemeler_CellContentClick;
            // 
            // frmOdeme
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvOdemeler);
            Controls.Add(btnOdemeListele);
            Controls.Add(btnOdemeEkle);
            Controls.Add(txtAciklama);
            Controls.Add(txtOdemeTutar);
            Controls.Add(txtOdemeTarih);
            Controls.Add(txtRezervasyonID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmOdeme";
            Text = "frmOdeme";
            ((System.ComponentModel.ISupportInitialize)dgvOdemeler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtRezervasyonID;
        private TextBox txtOdemeTarih;
        private TextBox txtOdemeTutar;
        private TextBox txtAciklama;
        private Button btnOdemeEkle;
        private Button btnOdemeListele;
        private DataGridView dgvOdemeler;
    }
}