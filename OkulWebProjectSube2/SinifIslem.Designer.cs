namespace OgrenciBilgilendirmeApp
{
    partial class SinifIslem
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
            txtSinifAdi = new TextBox();
            txtKontejan = new TextBox();
            lblSinifAdi = new Label();
            lblKontejan = new Label();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnBul = new Button();
            grpSinifBilgileri = new GroupBox();
            btn_geri = new Button();
            grpSinifBilgileri.SuspendLayout();
            SuspendLayout();
            // 
            // txtSinifAdi
            // 
            txtSinifAdi.Location = new Point(155, 41);
            txtSinifAdi.Name = "txtSinifAdi";
            txtSinifAdi.Size = new Size(200, 25);
            txtSinifAdi.TabIndex = 1;
            // 
            // txtKontejan
            // 
            txtKontejan.Location = new Point(155, 81);
            txtKontejan.Name = "txtKontejan";
            txtKontejan.Size = new Size(200, 25);
            txtKontejan.TabIndex = 3;
            // 
            // lblSinifAdi
            // 
            lblSinifAdi.AutoSize = true;
            lblSinifAdi.Location = new Point(55, 41);
            lblSinifAdi.Name = "lblSinifAdi";
            lblSinifAdi.Size = new Size(61, 19);
            lblSinifAdi.TabIndex = 0;
            lblSinifAdi.Text = "Sınıf Adı:";
            // 
            // lblKontejan
            // 
            lblKontejan.AutoSize = true;
            lblKontejan.Location = new Point(55, 81);
            lblKontejan.Name = "lblKontejan";
            lblKontejan.Size = new Size(66, 19);
            lblKontejan.TabIndex = 2;
            lblKontejan.Text = "Kontejan:";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.LightGreen;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Location = new Point(12, 176);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(100, 40);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.LightBlue;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Location = new Point(118, 176);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(100, 40);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.LightCoral;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Location = new Point(224, 176);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(100, 40);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnBul
            // 
            btnBul.BackColor = Color.LightGoldenrodYellow;
            btnBul.FlatStyle = FlatStyle.Flat;
            btnBul.Location = new Point(330, 176);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(100, 40);
            btnBul.TabIndex = 7;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = false;
            btnBul.Click += btnBul_Click;
            // 
            // grpSinifBilgileri
            // 
            grpSinifBilgileri.Controls.Add(lblSinifAdi);
            grpSinifBilgileri.Controls.Add(txtSinifAdi);
            grpSinifBilgileri.Controls.Add(lblKontejan);
            grpSinifBilgileri.Controls.Add(txtKontejan);
            grpSinifBilgileri.Location = new Point(12, 38);
            grpSinifBilgileri.Name = "grpSinifBilgileri";
            grpSinifBilgileri.Size = new Size(418, 120);
            grpSinifBilgileri.TabIndex = 0;
            grpSinifBilgileri.TabStop = false;
            grpSinifBilgileri.Text = "Sınıf Bilgileri";
            // 
            // btn_geri
            // 
            btn_geri.Font = new Font("Segoe UI", 7F);
            btn_geri.Location = new Point(12, 12);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(62, 19);
            btn_geri.TabIndex = 8;
            btn_geri.Text = "Geri";
            btn_geri.TextAlign = ContentAlignment.TopCenter;
            btn_geri.UseVisualStyleBackColor = true;
            btn_geri.Click += btn_geri_Click;
            // 
            // SinifIslem
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(447, 234);
            Controls.Add(btn_geri);
            Controls.Add(grpSinifBilgileri);
            Controls.Add(btnKaydet);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnBul);
            Font = new Font("Segoe UI", 10F);
            Name = "SinifIslem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sınıf İşlemleri";
            Load += SinifIslem_Load_1;
            grpSinifBilgileri.ResumeLayout(false);
            grpSinifBilgileri.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtSinifAdi;
        private System.Windows.Forms.TextBox txtKontejan;
        private System.Windows.Forms.Label lblSinifAdi;
        private System.Windows.Forms.Label lblKontejan;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.GroupBox grpSinifBilgileri;
        private Button btn_geri;
    }
}
