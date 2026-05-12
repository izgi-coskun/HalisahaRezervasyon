namespace HalisahaRezervasyon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button2 = new Button();
            btnMusteri = new Button();
            btnSaha = new Button();
            btnRezervasyon = new Button();
            btnOdeme = new Button();
            button6 = new Button();
            btnDetay = new Button();
            btnCikis = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F);
            label1.Location = new Point(221, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 13);
            label1.TabIndex = 0;
            label1.Text = "HALISAHA REZERVASYON SİSTEMİ";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(375, 247);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnMusteri
            // 
            btnMusteri.Location = new Point(3, 38);
            btnMusteri.Name = "btnMusteri";
            btnMusteri.Size = new Size(200, 45);
            btnMusteri.TabIndex = 3;
            btnMusteri.Text = "Müşteri İşlemleri";
            btnMusteri.UseVisualStyleBackColor = true;
            btnMusteri.Click += button1_Click_1;
            // 
            // btnSaha
            // 
            btnSaha.Location = new Point(3, 96);
            btnSaha.Name = "btnSaha";
            btnSaha.Size = new Size(200, 45);
            btnSaha.TabIndex = 4;
            btnSaha.Text = "Saha İşlemleri";
            btnSaha.UseVisualStyleBackColor = true;
            // 
            // btnRezervasyon
            // 
            btnRezervasyon.Location = new Point(3, 147);
            btnRezervasyon.Name = "btnRezervasyon";
            btnRezervasyon.Size = new Size(200, 45);
            btnRezervasyon.TabIndex = 5;
            btnRezervasyon.Text = "Rezervasyon İşlemleri";
            btnRezervasyon.UseVisualStyleBackColor = true;
            // 
            // btnOdeme
            // 
            btnOdeme.Location = new Point(3, 198);
            btnOdeme.Name = "btnOdeme";
            btnOdeme.Size = new Size(200, 45);
            btnOdeme.TabIndex = 6;
            btnOdeme.Text = "Ödeme İşlemleri";
            btnOdeme.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(394, 170);
            button6.Name = "button6";
            button6.Size = new Size(8, 8);
            button6.TabIndex = 7;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnDetay
            // 
            btnDetay.Location = new Point(3, 249);
            btnDetay.Name = "btnDetay";
            btnDetay.Size = new Size(200, 45);
            btnDetay.TabIndex = 8;
            btnDetay.Text = "Rezervasyon Detayları";
            btnDetay.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(3, 300);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(200, 45);
            btnCikis.TabIndex = 9;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 344);
            Controls.Add(btnCikis);
            Controls.Add(btnDetay);
            Controls.Add(button6);
            Controls.Add(btnOdeme);
            Controls.Add(btnRezervasyon);
            Controls.Add(btnSaha);
            Controls.Add(btnMusteri);
            Controls.Add(button2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button btnMusteri;
        private Button btnSaha;
        private Button btnRezervasyon;
        private Button btnOdeme;
        private Button button6;
        private Button btnDetay;
        private Button btnCikis;
    }
}
