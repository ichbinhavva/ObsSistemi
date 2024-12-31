namespace OgrenciBilgilendirmeApp
{
    partial class Giris
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
            lblTitle = new Label();
            btnDersSec = new Button();
            btnOgrenciKayit = new Button();
            btnSinifIslemleri = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(0, 123, 255);
            lblTitle.Location = new Point(40, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(398, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Öğrenci Bilgilendirme Sistemi";
            // 
            // btnDersSec
            // 
            btnDersSec.BackColor = Color.FromArgb(40, 167, 69);
            btnDersSec.FlatAppearance.BorderSize = 0;
            btnDersSec.FlatStyle = FlatStyle.Flat;
            btnDersSec.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnDersSec.ForeColor = Color.White;
            btnDersSec.Location = new Point(100, 87);
            btnDersSec.Name = "btnDersSec";
            btnDersSec.Size = new Size(250, 45);
            btnDersSec.TabIndex = 1;
            btnDersSec.Text = "Ders Seçimi";
            btnDersSec.UseVisualStyleBackColor = false;
            btnDersSec.Click += btnDersSec_Click;
            // 
            // btnOgrenciKayit
            // 
            btnOgrenciKayit.BackColor = Color.FromArgb(0, 123, 255);
            btnOgrenciKayit.FlatAppearance.BorderSize = 0;
            btnOgrenciKayit.FlatStyle = FlatStyle.Flat;
            btnOgrenciKayit.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnOgrenciKayit.ForeColor = Color.White;
            btnOgrenciKayit.Location = new Point(100, 155);
            btnOgrenciKayit.Name = "btnOgrenciKayit";
            btnOgrenciKayit.Size = new Size(250, 45);
            btnOgrenciKayit.TabIndex = 2;
            btnOgrenciKayit.Text = "Öğrenci Kayıt";
            btnOgrenciKayit.UseVisualStyleBackColor = false;
            btnOgrenciKayit.Click += btnOgrenciKayit_Click;
            // 
            // btnSinifIslemleri
            // 
            btnSinifIslemleri.BackColor = Color.FromArgb(255, 193, 7);
            btnSinifIslemleri.FlatAppearance.BorderSize = 0;
            btnSinifIslemleri.FlatStyle = FlatStyle.Flat;
            btnSinifIslemleri.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSinifIslemleri.ForeColor = Color.White;
            btnSinifIslemleri.Location = new Point(100, 225);
            btnSinifIslemleri.Name = "btnSinifIslemleri";
            btnSinifIslemleri.Size = new Size(250, 45);
            btnSinifIslemleri.TabIndex = 3;
            btnSinifIslemleri.Text = "Sınıf İşlemleri";
            btnSinifIslemleri.UseVisualStyleBackColor = false;
            btnSinifIslemleri.Click += btnSinifIslemleri_Click;
            // 
            // Giris
            // 
            BackColor = Color.White;
            ClientSize = new Size(505, 297);
            Controls.Add(lblTitle);
            Controls.Add(btnDersSec);
            Controls.Add(btnOgrenciKayit);
            Controls.Add(btnSinifIslemleri);
            Name = "Giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci Bilgilendirme Sistemi";
            Load += Giris_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnDersSec;
        private Button btnOgrenciKayit;
        private Button btnSinifIslemleri;
    }
}
