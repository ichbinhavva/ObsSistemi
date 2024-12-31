namespace OgrenciBilgilendirmeApp
{
    partial class DersIslem
    {
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.TextBox txtDersKodu;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.Button btnDersGuncelle;  // Güncelle butonu eklendi
        private System.Windows.Forms.DataGridView dgvDersler;
        private System.Windows.Forms.Label lblDersAdi;
        private System.Windows.Forms.Label lblDersKodu;
        private System.Windows.Forms.GroupBox grpDersBilgileri;

        private void InitializeComponent()
        {
            txtDersAdi = new TextBox();
            txtDersKodu = new TextBox();
            btnDersEkle = new Button();
            btnDersSil = new Button();
            btnDersGuncelle = new Button();
            dgvDersler = new DataGridView();
            lblDersAdi = new Label();
            lblDersKodu = new Label();
            grpDersBilgileri = new GroupBox();
            btn_geri = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDersler).BeginInit();
            grpDersBilgileri.SuspendLayout();
            SuspendLayout();
            // 
            // txtDersAdi
            // 
            txtDersAdi.Location = new Point(136, 35);
            txtDersAdi.Name = "txtDersAdi";
            txtDersAdi.Size = new Size(146, 23);
            txtDersAdi.TabIndex = 1;
            // 
            // txtDersKodu
            // 
            txtDersKodu.Location = new Point(136, 75);
            txtDersKodu.Name = "txtDersKodu";
            txtDersKodu.Size = new Size(146, 23);
            txtDersKodu.TabIndex = 2;
            // 
            // btnDersEkle
            // 
            btnDersEkle.BackColor = Color.LightGreen;
            btnDersEkle.FlatStyle = FlatStyle.Flat;
            btnDersEkle.Location = new Point(25, 164);
            btnDersEkle.Name = "btnDersEkle";
            btnDersEkle.Size = new Size(100, 40);
            btnDersEkle.TabIndex = 3;
            btnDersEkle.Text = "Ekle";
            btnDersEkle.UseVisualStyleBackColor = false;
            btnDersEkle.Click += btnDersEkle_Click;
            // 
            // btnDersSil
            // 
            btnDersSil.BackColor = Color.LightCoral;
            btnDersSil.FlatStyle = FlatStyle.Flat;
            btnDersSil.Location = new Point(237, 164);
            btnDersSil.Name = "btnDersSil";
            btnDersSil.Size = new Size(100, 40);
            btnDersSil.TabIndex = 4;
            btnDersSil.Text = "Sil";
            btnDersSil.UseVisualStyleBackColor = false;
            btnDersSil.Click += btnDersSil_Click;
            // 
            // btnDersGuncelle
            // 
            btnDersGuncelle.BackColor = Color.LightBlue;
            btnDersGuncelle.FlatStyle = FlatStyle.Flat;
            btnDersGuncelle.Location = new Point(131, 164);
            btnDersGuncelle.Name = "btnDersGuncelle";
            btnDersGuncelle.Size = new Size(100, 40);
            btnDersGuncelle.TabIndex = 5;
            btnDersGuncelle.Text = "Güncelle";
            btnDersGuncelle.UseVisualStyleBackColor = false;
            btnDersGuncelle.Click += btnDersGuncelle_Click;
            // 
            // dgvDersler
            // 
            dgvDersler.AllowUserToAddRows = false;
            dgvDersler.AllowUserToDeleteRows = false;
            dgvDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDersler.Location = new Point(25, 220);
            dgvDersler.Name = "dgvDersler";
            dgvDersler.Size = new Size(312, 150);
            dgvDersler.TabIndex = 7;
            dgvDersler.CellClick += dgvDersler_CellClick;
            // 
            // lblDersAdi
            // 
            lblDersAdi.AutoSize = true;
            lblDersAdi.Location = new Point(36, 35);
            lblDersAdi.Name = "lblDersAdi";
            lblDersAdi.Size = new Size(54, 15);
            lblDersAdi.TabIndex = 0;
            lblDersAdi.Text = "Ders Adı:";
            // 
            // lblDersKodu
            // 
            lblDersKodu.AutoSize = true;
            lblDersKodu.Location = new Point(36, 75);
            lblDersKodu.Name = "lblDersKodu";
            lblDersKodu.Size = new Size(64, 15);
            lblDersKodu.TabIndex = 2;
            lblDersKodu.Text = "Ders Kodu:";
            // 
            // grpDersBilgileri
            // 
            grpDersBilgileri.Controls.Add(lblDersAdi);
            grpDersBilgileri.Controls.Add(txtDersAdi);
            grpDersBilgileri.Controls.Add(lblDersKodu);
            grpDersBilgileri.Controls.Add(txtDersKodu);
            grpDersBilgileri.Location = new Point(25, 33);
            grpDersBilgileri.Name = "grpDersBilgileri";
            grpDersBilgileri.Size = new Size(312, 120);
            grpDersBilgileri.TabIndex = 0;
            grpDersBilgileri.TabStop = false;
            grpDersBilgileri.Text = "Ders Bilgileri";
            grpDersBilgileri.Enter += grpDersBilgileri_Enter;
            // 
            // btn_geri
            // 
            btn_geri.Font = new Font("Segoe UI", 7F);
            btn_geri.Location = new Point(27, 8);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(62, 19);
            btn_geri.TabIndex = 8;
            btn_geri.Text = "Geri";
            btn_geri.TextAlign = ContentAlignment.TopCenter;
            btn_geri.UseVisualStyleBackColor = true;
            btn_geri.Click += btn_geri_Click;
            // 
            // DersIslem
            // 
            ClientSize = new Size(368, 398);
            Controls.Add(btn_geri);
            Controls.Add(grpDersBilgileri);
            Controls.Add(dgvDersler);
            Controls.Add(btnDersEkle);
            Controls.Add(btnDersSil);
            Controls.Add(btnDersGuncelle);
            Name = "DersIslem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ders İşlemleri";
            Load += DersIslem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDersler).EndInit();
            grpDersBilgileri.ResumeLayout(false);
            grpDersBilgileri.PerformLayout();
            ResumeLayout(false);
        }

        private Button btn_geri;
    }
}
