using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulWebProjectSube2
{
    internal class Students
    {
        [Key]
        public int StudentsId { get; set; } // int olarak değiştir sonradan
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Numara { get; set; }
        public int SinifId {  get; set; }
        public  Sinif Sinif {  get; set; }
        public  ICollection<OgrenciDers>? OgrenciDersler { get; set; }

       

    }

}
