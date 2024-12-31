using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgilendirmeApp
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void btnDersSec_Click(object sender, EventArgs e)
        {
            DersIslem dersIslem = new DersIslem();
            dersIslem.Show();
            this.Hide();
        }

        private void btnOgrenciKayit_Click(object sender, EventArgs e)
        {
            OgrenciIslem ogrenciIslem = new OgrenciIslem();
            ogrenciIslem.Show();
            this.Hide();
        }

        private void btnSinifIslemleri_Click(object sender, EventArgs e)
        {
            SinifIslem sinifIslem = new SinifIslem();
            sinifIslem.Show();
            this.Hide();
        }

        private void Giris_Load_1(object sender, EventArgs e)
        {

        }
    }
}
