using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using OkulWebProjectSube2;

namespace OgrenciBilgilendirmeApp
{
    public partial class OgrenciIslem : Form
    {
        Students? ogr;

        public OgrenciIslem()
        {
            InitializeComponent();
        }

        private void OgrenciIslem_Load(object sender, EventArgs e)
        {
            using (var ctx = new StudentDBContext())
            {
                var siniflar = ctx.Siniflar!.Select(s => new { s.SinifId, s.SinifAd }).ToList();
                cmbSinif.DataSource = siniflar;
                cmbSinif.DisplayMember = "SinifAdi";
                cmbSinif.ValueMember = "SinifId";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string? secilenSinifAdi = cmbSinif.Text;
            foreach (Control item in grpOgrenciBilgileri.Controls)
            {
                if (item is TextBox && item.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen tüm alanlarý doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }

            try
            {
                using (var ctx = new StudentDBContext())
                {
                    int secilenSinifId = (int)cmbSinif.SelectedValue;
                    int mevcutOgrenciSayisi = ctx.Ogrenciler!.Count(o => o.SinifId == secilenSinifId);
                    var sinif = ctx.Siniflar!.FirstOrDefault(s => s.SinifId == secilenSinifId);

                    if (sinif == null)
                    {
                        MessageBox.Show("Sýnýf bulunamadý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (sinif.Kontenjan <= mevcutOgrenciSayisi)
                    {
                        MessageBox.Show("Kontenjan Yetersiz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.ogr = new Students
                    {
                        Ad = txt_ad.Text.Trim(),
                        Soyad = txt_soyad.Text.Trim(),
                        Numara = txt_numara.Text.Trim(),
                        SinifId = secilenSinifId
                    };
                    ctx.Ogrenciler!.Add(ogr);
                    int sonuc = ctx.SaveChanges();
                    MessageBox.Show($"{sonuc} Kayýt Baþarýyla Yapýldý");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (var ctx = new StudentDBContext())
            {
                if (this.ogr != null)
                {
                    var sinifId = cmbSinif.SelectedValue as int?;

                    if (sinifId == null)
                    {
                        MessageBox.Show("Lütfen geçerli bir sýnýf seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var sinif = ctx.Siniflar.FirstOrDefault(s => s.SinifId == sinifId);
                    if (sinif == null)
                    {
                        MessageBox.Show("Seçilen sýnýf bulunamadý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ogr.Ad = txt_ad.Text;
                    ogr.Soyad = txt_soyad.Text;
                    ogr.Numara = txt_numara.Text;
                    ogr.SinifId = sinif.SinifId;

                    ctx.Entry(ogr).State = EntityState.Modified;

                    try
                    {
                        int sonuc = ctx.SaveChanges();
                        MessageBox.Show($"{sonuc} kullanýcý baþarýyla güncellendi.", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir öðrenci seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void btnBul_Click(object sender, EventArgs e)
        {
            string secilenOgrenciAdi = txt_ad.Text.Trim();
            if (secilenOgrenciAdi == string.Empty)
            {
                MessageBox.Show("Lütfen bulmak istediðiniz kiþinin adýný girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var ctx = new StudentDBContext())
                {
                    var ogr = ctx.Ogrenciler!.FirstOrDefault(s => s.Ad == secilenOgrenciAdi);

                    if (ogr == null)
                    {
                        MessageBox.Show("Seçilen öðrenci bulunamadý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var sinif = ctx.Siniflar!.FirstOrDefault(s => s.SinifId == ogr.SinifId);

                    if (sinif == null)
                    {
                        MessageBox.Show("Öðrencinin sýnýf bilgisi bulunamadý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.ogr = ogr;
                    txt_ad.Text = ogr.Ad;
                    txt_soyad.Text = ogr.Soyad;
                    txt_numara.Text = ogr.Numara;

                    cmbSinif.SelectedValue = sinif.SinifId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            foreach (Control item in grpOgrenciBilgileri.Controls)
            {
                if (item is TextBox && item.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen tüm alanlarý doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            DersSecim dersSecim = new DersSecim(txt_ad.Text, txt_soyad.Text, txt_numara.Text, cmbSinif.Text);
            dersSecim.Show();
            this.Hide();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris giris = new Giris();
            giris.Show();
        }
    }
}
