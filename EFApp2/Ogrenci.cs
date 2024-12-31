using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema; // sonradan import ettik.
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFApp
{
    internal class Ogrenci
    {

        public int OgrenciId { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        [Required] // kimin üzerindeyse o çalışır.required: zorunlu demektir.
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }

        public override string ToString()
        {
            return $"{this.Numara} -{this.Ad}-{this.Soyad}";
        }

    }
}


//Buradaki isimlendirme önemli! Framework bunu kullanarak bir şeyler yapıyor.
//Projeler için mutlaka dbcontext yazmamız gerekiyor her projede bir tane yeterli ~galiba.
//atributler [] içerisinde yazılır.