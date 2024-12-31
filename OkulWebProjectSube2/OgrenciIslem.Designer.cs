namespace OgrenciBilgilendirmeApp
{
    partial class OgrenciIslem
    {
        private TextBox txt_ad;
        private TextBox txt_soyad;
        private TextBox txt_numara;
        private ComboBox cmbSinif;
        private Button btnKaydet;
        private Button btnGuncelle;
        private Button btnBul;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblNumara;
        private Label lblSinif;
        private GroupBox grpOgrenciBilgileri;

        private void InitializeComponent()
        {
            txt_ad = new TextBox();
            txt_soyad = new TextBox();
            txt_numara = new TextBox();
            cmbSinif = new ComboBox();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            btnBul = new Button();
            lblAd = new Label();
            lblSoyad = new Label();
            lblNumara = new Label();
            lblSinif = new Label();
            grpOgrenciBilgileri = new GroupBox();
            btnDers = new Button();
            btn_geri = new Button();
            grpOgrenciBilgileri.SuspendLayout();
            SuspendLayout();
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(155, 41);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(200, 30);
            txt_ad.TabIndex = 1;
            // 
            // txt_soyad
            // 
            txt_soyad.Location = new Point(155, 81);
            txt_soyad.Name = "txt_soyad";
            txt_soyad.Size = new Size(200, 30);
            txt_soyad.TabIndex = 3;
            // 
            // txt_numara
            // 
            txt_numara.Location = new Point(155, 121);
            txt_numara.Name = "txt_numara";
            txt_numara.Size = new Size(200, 30);
            txt_numara.TabIndex = 5;
            // 
            // cmbSinif
            // 
            cmbSinif.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSinif.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cmbSinif.Location = new Point(155, 161);
            cmbSinif.Name = "cmbSinif";
            cmbSinif.Size = new Size(200, 31);
            cmbSinif.TabIndex = 7;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.LightGreen;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Location = new Point(74, 265);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(100, 40);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.LightBlue;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Location = new Point(199, 265);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(100, 40);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnBul
            // 
            btnBul.BackColor = Color.LightGoldenrodYellow;
            btnBul.FlatStyle = FlatStyle.Flat;
            btnBul.Location = new Point(324, 265);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(100, 40);
            btnBul.TabIndex = 3;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = false;
            btnBul.Click += btnBul_Click;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(55, 41);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(35, 23);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(55, 81);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(60, 23);
            lblSoyad.TabIndex = 2;
            lblSoyad.Text = "Soyad:";
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(55, 121);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(76, 23);
            lblNumara.TabIndex = 4;
            lblNumara.Text = "Numara:";
            // 
            // lblSinif
            // 
            lblSinif.AutoSize = true;
            lblSinif.Location = new Point(55, 161);
            lblSinif.Name = "lblSinif";
            lblSinif.Size = new Size(46, 23);
            lblSinif.TabIndex = 6;
            lblSinif.Text = "Sınıf:";
            // 
            // grpOgrenciBilgileri
            // 
            grpOgrenciBilgileri.Controls.Add(lblAd);
            grpOgrenciBilgileri.Controls.Add(txt_ad);
            grpOgrenciBilgileri.Controls.Add(lblSoyad);
            grpOgrenciBilgileri.Controls.Add(txt_soyad);
            grpOgrenciBilgileri.Controls.Add(lblNumara);
            grpOgrenciBilgileri.Controls.Add(txt_numara);
            grpOgrenciBilgileri.Controls.Add(lblSinif);
            grpOgrenciBilgileri.Controls.Add(cmbSinif);
            grpOgrenciBilgileri.Location = new Point(30, 30);
            grpOgrenciBilgileri.Name = "grpOgrenciBilgileri";
            grpOgrenciBilgileri.Size = new Size(440, 220);
            grpOgrenciBilgileri.TabIndex = 0;
            grpOgrenciBilgileri.TabStop = false;
            grpOgrenciBilgileri.Text = "Öğrenci Bilgileri";
            // 
            // btnDers
            // 
            btnDers.BackColor = Color.LightGreen;
            btnDers.FlatStyle = FlatStyle.Flat;
            btnDers.Location = new Point(74, 311);
            btnDers.Name = "btnDers";
            btnDers.Size = new Size(350, 40);
            btnDers.TabIndex = 1;
            btnDers.Text = "Ders Seçimi";
            btnDers.UseVisualStyleBackColor = false;
            btnDers.Click += btnDers_Click;
            // 
            // btn_geri
            // 
            btn_geri.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btn_geri.Location = new Point(30, 5);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(62, 19);
            btn_geri.TabIndex = 4;
            btn_geri.Text = "Geri";
            btn_geri.TextAlign = ContentAlignment.TopCenter;
            btn_geri.UseVisualStyleBackColor = true;
            btn_geri.Click += btn_geri_Click;
            // 
            // OgrenciIslem
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(500, 368);
            Controls.Add(btn_geri);
            Controls.Add(grpOgrenciBilgileri);
            Controls.Add(btnDers);
            Controls.Add(btnKaydet);
            Controls.Add(btnGuncelle);
            Controls.Add(btnBul);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "OgrenciIslem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci Bilgilendirme Sistemi";
            Load += OgrenciIslem_Load;
            grpOgrenciBilgileri.ResumeLayout(false);
            grpOgrenciBilgileri.PerformLayout();
            ResumeLayout(false);
        }

        private Button btnDers;
        private Button btn_geri;
    }
}
