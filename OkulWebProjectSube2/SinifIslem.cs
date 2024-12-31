using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using OkulWebProjectSube2;

namespace OgrenciBilgilendirmeApp
{
    public partial class SinifIslem : Form
    {
        Sinif? snf;
        public SinifIslem()
        {
            InitializeComponent();
        }

        private void SinifIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (Control item in grpSinifBilgileri.Controls)
            {
                if (item is TextBox && item.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            this.snf = new Sinif { SinifAd = txtSinifAdi.Text.Trim(), Kontenjan = int.Parse(txtKontejan.Text.Trim()) };
            try
            {
                using (var ctx = new StudentDBContext())
                {
                    ctx.Siniflar!.Add(snf);
                    int sonuc = ctx.SaveChanges();
                    MessageBox.Show($"{sonuc} Kayıt Başarıyla Yapıldı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string secilenSinifAdi = txtSinifAdi.Text.Trim();
            if (secilenSinifAdi == string.Empty)
            {
                MessageBox.Show("Lütfen silmek istediğiniz sınıf adını girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var ctx = new StudentDBContext())
                {
                    var sinif = ctx.Siniflar!.FirstOrDefault(s => s.SinifAd == secilenSinifAdi);

                    if (sinif == null)
                    {
                        MessageBox.Show("Seçilen sınıf bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int ogrenciSayisi = ctx.Ogrenciler!.Count(o => o.SinifId == sinif.SinifId);
                    if (ogrenciSayisi > 0)
                    {
                        MessageBox.Show("Bu sınıfta kayıtlı öğrenciler bulunduğu için silme işlemi yapılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    ctx.Siniflar!.Remove(sinif);
                    int sonuc = ctx.SaveChanges();
                    MessageBox.Show($"{sonuc} Sınıf başarıyla silindi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            string secilenSinifAdi = txtSinifAdi.Text.Trim();
            if (secilenSinifAdi == string.Empty)
            {
                MessageBox.Show("Lütfen bulmak istediğiniz sınıf adını girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var ctx = new StudentDBContext())
            {
                var sinif = ctx.Siniflar!.FirstOrDefault(s => s.SinifAd == secilenSinifAdi);
                if (sinif == null)
                {
                    MessageBox.Show("Seçilen sınıf bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtSinifAdi.Text = sinif.SinifAd;
                txtKontejan.Text = sinif.Kontenjan.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            string secilenSinifAdi = txtSinifAdi.Text.Trim();

            if (secilenSinifAdi == string.Empty)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz sınıf adını girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var ctx = new StudentDBContext())
                {
                    if (txtSinifAdi.Text == string.Empty || txtKontejan.Text == string.Empty)
                    {
                        MessageBox.Show($"Alanlar Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    snf = ctx.Siniflar!.FirstOrDefault(s => s.SinifAd == secilenSinifAdi);
                    if (snf == null)
                    {
                        MessageBox.Show("Seçilen sınıf bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    snf.Kontenjan = int.Parse(txtKontejan.Text.Trim());
                    ctx.Entry(snf).State = EntityState.Modified;
                    int sonuc = ctx.SaveChanges();
                    MessageBox.Show($"{sonuc} Sınıf başarıyla güncellendi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SinifIslem_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris giris = new Giris();
            giris.Show();
        }
    }
}
