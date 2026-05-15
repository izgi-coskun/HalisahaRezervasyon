namespace HalisahaRezervasyon
{
    partial class frmSahalar
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
            txtSahaAd = new TextBox();
            txtUcret = new TextBox();
            btnSahaEkle = new Button();
            btnSahaListele = new Button();
            dgvSahalar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSahalar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 235);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 0;
            label1.Text = "Saha Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 287);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 1;
            label2.Text = "Saatlik Ücret";
            // 
            // txtSahaAd
            // 
            txtSahaAd.Location = new Point(390, 227);
            txtSahaAd.Name = "txtSahaAd";
            txtSahaAd.Size = new Size(100, 25);
            txtSahaAd.TabIndex = 2;
            // 
            // txtUcret
            // 
            txtUcret.Location = new Point(390, 279);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(100, 25);
            txtUcret.TabIndex = 3;
            // 
            // btnSahaEkle
            // 
            btnSahaEkle.Location = new Point(390, 383);
            btnSahaEkle.Name = "btnSahaEkle";
            btnSahaEkle.Size = new Size(139, 23);
            btnSahaEkle.TabIndex = 4;
            btnSahaEkle.Text = "Saha Ekle";
            btnSahaEkle.UseVisualStyleBackColor = true;
            btnSahaEkle.Click += btnSahaEkle_Click;
            // 
            // btnSahaListele
            // 
            btnSahaListele.Location = new Point(390, 342);
            btnSahaListele.Name = "btnSahaListele";
            btnSahaListele.Size = new Size(139, 23);
            btnSahaListele.TabIndex = 5;
            btnSahaListele.Text = "Sahaları Listele";
            btnSahaListele.UseVisualStyleBackColor = true;
            btnSahaListele.Click += btnSahaListele_Click;
            // 
            // dgvSahalar
            // 
            dgvSahalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSahalar.Location = new Point(-1, -1);
            dgvSahalar.Name = "dgvSahalar";
            dgvSahalar.Size = new Size(800, 150);
            dgvSahalar.TabIndex = 6;
            // 
            // frmSahalar
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSahalar);
            Controls.Add(btnSahaListele);
            Controls.Add(btnSahaEkle);
            Controls.Add(txtUcret);
            Controls.Add(txtSahaAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSahalar";
            Text = "frmSahalar";
            ((System.ComponentModel.ISupportInitialize)dgvSahalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSahaAd;
        private TextBox txtUcret;
        private Button btnSahaEkle;
        private Button btnSahaListele;
        private DataGridView dgvSahalar;
    }
}