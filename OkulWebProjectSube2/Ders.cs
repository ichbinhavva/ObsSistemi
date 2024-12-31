using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulWebProjectSube2
{
    internal class Ders
    {
        [Key]
        public int DersId { get; set; }
        public string? DersKodu { get; set; }
        public string? DersAdi { get; set; }
        public  ICollection<OgrenciDers> OgrenciDersler { get; set; }
    }
}
