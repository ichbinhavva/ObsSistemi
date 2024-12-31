namespace OkulWebProjectSube2
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
            grp_ogrencigrs = new GroupBox();
            cmb_sinif = new ComboBox();
            lbl_sinif = new Label();
            btn_bul = new Button();
            btn_guncelle = new Button();
            btn_giris = new Button();
            txt_numara = new TextBox();
            txt_soyad = new TextBox();
            txt_ad = new TextBox();
            lbl_no = new Label();
            lbl_soyad = new Label();
            lbl_ad = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            grp_ogrencigrs.SuspendLayout();
            SuspendLayout();
            // 
            // grp_ogrencigrs
            // 
            grp_ogrencigrs.Controls.Add(cmb_sinif);
            grp_ogrencigrs.Controls.Add(lbl_sinif);
            grp_ogrencigrs.Controls.Add(btn_bul);
            grp_ogrencigrs.Controls.Add(btn_guncelle);
            grp_ogrencigrs.Controls.Add(btn_giris);
            grp_ogrencigrs.Controls.Add(txt_numara);
            grp_ogrencigrs.Controls.Add(txt_soyad);
            grp_ogrencigrs.Controls.Add(txt_ad);
            grp_ogrencigrs.Controls.Add(lbl_no);
            grp_ogrencigrs.Controls.Add(lbl_soyad);
            grp_ogrencigrs.Controls.Add(lbl_ad);
            grp_ogrencigrs.Location = new Point(252, 12);
            grp_ogrencigrs.Name = "grp_ogrencigrs";
            grp_ogrencigrs.Size = new Size(431, 357);
            grp_ogrencigrs.TabIndex = 0;
            grp_ogrencigrs.TabStop = false;
            grp_ogrencigrs.Text = "Ögrenci Girişi";
            // 
            // cmb_sinif
            // 
            cmb_sinif.FormattingEnabled = true;
            cmb_sinif.Items.AddRange(new object[] { "Hazırlık", "1", "2", "3", "4" });
            cmb_sinif.Location = new Point(142, 197);
            cmb_sinif.Name = "cmb_sinif";
            cmb_sinif.Size = new Size(174, 28);
            cmb_sinif.TabIndex = 4;
            // 
            // lbl_sinif
            // 
            lbl_sinif.AutoSize = true;
            lbl_sinif.Location = new Point(98, 193);
            lbl_sinif.Name = "lbl_sinif";
            lbl_sinif.Size = new Size(38, 20);
            lbl_sinif.TabIndex = 11;
            lbl_sinif.Text = "Sınıf";
            // 
            // btn_bul
            // 
            btn_bul.Location = new Point(292, 254);
            btn_bul.Name = "btn_bul";
            btn_bul.Size = new Size(99, 36);
            btn_bul.TabIndex = 10;
            btn_bul.Text = "Bul";
            btn_bul.UseVisualStyleBackColor = true;
            btn_bul.Click += btn_bul_Click;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(74, 254);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(99, 36);
            btn_guncelle.TabIndex = 9;
            btn_guncelle.Text = "Güncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // btn_giris
            // 
            btn_giris.Location = new Point(183, 254);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(99, 36);
            btn_giris.TabIndex = 6;
            btn_giris.Text = "Giriş";
            btn_giris.UseVisualStyleBackColor = true;
            btn_giris.Click += btn_giris_Click;
            // 
            // txt_numara
            // 
            txt_numara.Location = new Point(142, 144);
            txt_numara.Name = "txt_numara";
            txt_numara.Size = new Size(174, 27);
            txt_numara.TabIndex = 3;
            // 
            // txt_soyad
            // 
            txt_soyad.Location = new Point(142, 93);
            txt_soyad.Name = "txt_soyad";
            txt_soyad.Size = new Size(174, 27);
            txt_soyad.TabIndex = 2;
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(142, 36);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(174, 27);
            txt_ad.TabIndex = 1;
            // 
            // lbl_no
            // 
            lbl_no.AutoSize = true;
            lbl_no.Location = new Point(71, 147);
            lbl_no.Name = "lbl_no";
            lbl_no.Size = new Size(65, 20);
            lbl_no.TabIndex = 2;
            lbl_no.Text = "Numara:";
            // 
            // lbl_soyad
            // 
            lbl_soyad.AutoSize = true;
            lbl_soyad.Location = new Point(83, 96);
            lbl_soyad.Name = "lbl_soyad";
            lbl_soyad.Size = new Size(53, 20);
            lbl_soyad.TabIndex = 1;
            lbl_soyad.Text = "Soyad:";
            // 
            // lbl_ad
            // 
            lbl_ad.AutoSize = true;
            lbl_ad.Location = new Point(105, 39);
            lbl_ad.Name = "lbl_ad";
            lbl_ad.Size = new Size(31, 20);
            lbl_ad.TabIndex = 0;
            lbl_ad.Text = "Ad:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 110, 122);
            panel1.Location = new Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 446);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(84, 110, 122);
            panel2.Location = new Point(244, 375);
            panel2.Name = "panel2";
            panel2.Size = new Size(547, 74);
            panel2.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(grp_ogrencigrs);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci Bilgi Sistemi";
            Load += Form1_Load;
            grp_ogrencigrs.ResumeLayout(false);
            grp_ogrencigrs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp_ogrencigrs;
        private Label lbl_no;
        private Label lbl_soyad;
        private Label lbl_ad;
        private Button btn_giris;
        private TextBox txt_numara;
        private TextBox txt_soyad;
        private TextBox txt_ad;
        private Button btn_bul;
        private Button btn_guncelle;
        private ComboBox cmb_sinif;
        private Label lbl_sinif;
        private Panel panel1;
        private Panel panel2;
    }
}