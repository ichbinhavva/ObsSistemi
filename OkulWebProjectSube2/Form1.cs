using Microsoft.EntityFrameworkCore;

namespace OkulWebProjectSube2
{
    public partial class Form1 : Form
    {
        Students? ogr;
        List<Sinif> sinifList;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e) //insert
        {
            var ogr = new Students { Ad = txt_ad.Text.Trim(), Soyad = txt_soyad.Text.Trim(), Numara = txt_numara.Text.Trim() };

            //DbContext'ten bir nesne olu�turuyoruz ki i�indeki yap�y� kullanabilelim, oradaki dbset'imize
            using (var ctx = new StudentDBContext())
            {
                ctx.Ogrenciler.Add(ogr);
                //Ramdeki bir nesneyi ram deki bir dbset e atm�� olduk.
                int sonuc = ctx.SaveChanges();
                Console.WriteLine(sonuc > 0 ? "��lem Ba�ar�l�" : "��lem Ba�ar�s�z!");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e) //update
        {
            var ogr = new Students();

            using (var ctx = new StudentDBContext())
            {
                ogr.Ad = txt_ad.Text;
                ogr.Soyad = txt_soyad.Text;
                ogr.Numara = txt_numara.Text;

                ctx.Entry(ogr).State = EntityState.Modified;
                MessageBox.Show(ctx.SaveChanges() > 0 ? "g�ncelleme ba�ar�l�" : "g�ncelleme ba�ar�s�z!.");
                ctx.SaveChanges();
            }
        }

        private void btn_bul_Click(object sender, EventArgs e) //select
        {
            using (var ctx = new StudentDBContext())
            {

                if (ogr != null)
                {
                    this.ogr = ogr;
                    txt_ad.Text = ogr.Ad;
                    txt_soyad.Text = ogr.Soyad;
                    txt_numara.Text = ogr.Numara;
                }
                else
                {
                    MessageBox.Show("��renci bulunamad�.!");
                }

            }
        }
    }
}