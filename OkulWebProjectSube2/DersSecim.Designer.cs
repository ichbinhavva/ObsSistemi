namespace OgrenciBilgilendirmeApp
{
    partial class DersSecim
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpOgrenciBilgileri = new GroupBox();
            lblAd = new Label();
            txtAd = new TextBox();
            lblSoyad = new Label();
            txtSoyad = new TextBox();
            lblNumara = new Label();
            txtNumara = new TextBox();
            lblSinif = new Label();
            txtSinif = new TextBox();
            dgvDersler = new DataGridView();
            btnDersiKaydet = new Button();
            btn_geri = new Button();
            grpOgrenciBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDersler).BeginInit();
            SuspendLayout();
            // 
            // grpOgrenciBilgileri
            // 
            grpOgrenciBilgileri.BackColor = SystemColors.Info;
            grpOgrenciBilgileri.Controls.Add(lblAd);
            grpOgrenciBilgileri.Controls.Add(txtAd);
            grpOgrenciBilgileri.Controls.Add(lblSoyad);
            grpOgrenciBilgileri.Controls.Add(txtSoyad);
            grpOgrenciBilgileri.Controls.Add(lblNumara);
            grpOgrenciBilgileri.Controls.Add(txtNumara);
            grpOgrenciBilgileri.Controls.Add(lblSinif);
            grpOgrenciBilgileri.Controls.Add(txtSinif);
            grpOgrenciBilgileri.ForeColor = SystemColors.ControlText;
            grpOgrenciBilgileri.Location = new Point(20, 32);
            grpOgrenciBilgileri.Name = "grpOgrenciBilgileri";
            grpOgrenciBilgileri.Size = new Size(364, 160);
            grpOgrenciBilgileri.TabIndex = 0;
            grpOgrenciBilgileri.TabStop = false;
            grpOgrenciBilgileri.Text = "Öğrenci Bilgileri";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(20, 30);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(25, 15);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(100, 30);
            txtAd.Name = "txtAd";
            txtAd.ReadOnly = true;
            txtAd.Size = new Size(250, 23);
            txtAd.TabIndex = 1;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(20, 60);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(42, 15);
            lblSoyad.TabIndex = 2;
            lblSoyad.Text = "Soyad:";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(100, 60);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.ReadOnly = true;
            txtSoyad.Size = new Size(250, 23);
            txtSoyad.TabIndex = 3;
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(20, 90);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(53, 15);
            lblNumara.TabIndex = 4;
            lblNumara.Text = "Numara:";
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(100, 90);
            txtNumara.Name = "txtNumara";
            txtNumara.ReadOnly = true;
            txtNumara.Size = new Size(250, 23);
            txtNumara.TabIndex = 5;
            // 
            // lblSinif
            // 
            lblSinif.AutoSize = true;
            lblSinif.Location = new Point(20, 120);
            lblSinif.Name = "lblSinif";
            lblSinif.Size = new Size(33, 15);
            lblSinif.TabIndex = 6;
            lblSinif.Text = "Sınıf:";
            // 
            // txtSinif
            // 
            txtSinif.Location = new Point(100, 120);
            txtSinif.Name = "txtSinif";
            txtSinif.ReadOnly = true;
            txtSinif.Size = new Size(250, 23);
            txtSinif.TabIndex = 7;
            // 
            // dgvDersler
            // 
            dgvDersler.AllowUserToAddRows = false;
            dgvDersler.AllowUserToDeleteRows = false;
            dgvDersler.BackgroundColor = SystemColors.ControlLight;
            dgvDersler.Location = new Point(20, 198);
            dgvDersler.Name = "dgvDersler";
            dgvDersler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDersler.Size = new Size(364, 180);
            dgvDersler.TabIndex = 1;
            // 
            // btnDersiKaydet
            // 
            btnDersiKaydet.BackColor = Color.MintCream;
            btnDersiKaydet.FlatStyle = FlatStyle.Flat;
            btnDersiKaydet.Location = new Point(145, 384);
            btnDersiKaydet.Name = "btnDersiKaydet";
            btnDersiKaydet.Size = new Size(120, 35);
            btnDersiKaydet.TabIndex = 2;
            btnDersiKaydet.Text = "Dersi Kaydet";
            btnDersiKaydet.UseVisualStyleBackColor = false;
            btnDersiKaydet.Click += btnDersiKaydet_Click;
            // 
            // btn_geri
            // 
            btn_geri.Font = new Font("Segoe UI", 7F);
            btn_geri.Location = new Point(20, 7);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(62, 19);
            btn_geri.TabIndex = 3;
            btn_geri.Text = "Geri";
            btn_geri.TextAlign = ContentAlignment.TopCenter;
            btn_geri.UseVisualStyleBackColor = true;
            btn_geri.Click += btn_geri_Click;
            // 
            // DersSecim
            // 
            ClientSize = new Size(406, 434);
            Controls.Add(btn_geri);
            Controls.Add(grpOgrenciBilgileri);
            Controls.Add(dgvDersler);
            Controls.Add(btnDersiKaydet);
            Name = "DersSecim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ders Seçimi";
            Load += DersSecim_Load;
            grpOgrenciBilgileri.ResumeLayout(false);
            grpOgrenciBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDersler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgrenciBilgileri;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label lblSinif;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.TextBox txtSinif;
        private System.Windows.Forms.DataGridView dgvDersler;
        private System.Windows.Forms.Button btnDersiKaydet;
        private Button btn_geri;
    }
}
