using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulWebProjectSube2
{
    internal class Sinif
    {
        [Key]
        public int SinifId { get; set; }
        public string? SinifAd { get; set; }
        public int Kontenjan { get; set; }
        public ICollection<Students> Ogrenciler { get; set; }


    }

}
