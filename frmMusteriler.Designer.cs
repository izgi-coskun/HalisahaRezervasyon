namespace HalisahaRezervasyon
{
    partial class frmMusteriler
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
            dgvMusteriler = new DataGridView();
            btnListele = new Button();
            label1 = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            btnEkle = new Button();
            txtSoyad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            SuspendLayout();
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Dock = DockStyle.Top;
            dgvMusteriler.Location = new Point(0, 0);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.Size = new Size(800, 150);
            dgvMusteriler.TabIndex = 0;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(31, 222);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(258, 130);
            btnListele.TabIndex = 1;
            btnListele.Text = "Müşterileri Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 174);
            label1.Name = "label1";
            label1.Size = new Size(24, 17);
            label1.TabIndex = 2;
            label1.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(441, 174);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 25);
            txtAd.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 222);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 4;
            label2.Text = "Soyad";
            label2.Click += label2_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(369, 296);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(136, 23);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Müşteri Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(441, 222);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 25);
            txtSoyad.TabIndex = 6;
            // 
            // frmMusteriler
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSoyad);
            Controls.Add(btnEkle);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Controls.Add(btnListele);
            Controls.Add(dgvMusteriler);
            Name = "frmMusteriler";
            Text = "frmMusteriler";
            Load += frmMusteriler_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMusteriler;
        private Button btnListele;
        private Label label1;
        private TextBox txtAd;
        private Label label2;
        private Button btnEkle;
        private TextBox txtSoyad;
    }
}