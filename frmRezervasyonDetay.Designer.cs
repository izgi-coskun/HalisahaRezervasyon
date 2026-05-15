namespace HalisahaRezervasyon
{
    partial class frmRezervasyonDetay
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
            btnDetayListele = new Button();
            dgvDetaylar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
            SuspendLayout();
            // 
            // btnDetayListele
            // 
            btnDetayListele.Location = new Point(290, 264);
            btnDetayListele.Name = "btnDetayListele";
            btnDetayListele.Size = new Size(188, 98);
            btnDetayListele.TabIndex = 0;
            btnDetayListele.Text = "Detayları Listele";
            btnDetayListele.UseVisualStyleBackColor = true;
            btnDetayListele.Click += btnDetayListele_Click;
            // 
            // dgvDetaylar
            // 
            dgvDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetaylar.Location = new Point(0, -1);
            dgvDetaylar.Name = "dgvDetaylar";
            dgvDetaylar.Size = new Size(797, 150);
            dgvDetaylar.TabIndex = 2;
            // 
            // frmRezervasyonDetay
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDetaylar);
            Controls.Add(btnDetayListele);
            Name = "frmRezervasyonDetay";
            Text = "frmRezervasyonDetay";
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDetayListele;
        private Button button2;
        private DataGridView dgvDetaylar;
    }
}