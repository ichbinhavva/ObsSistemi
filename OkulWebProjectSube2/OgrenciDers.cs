using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulWebProjectSube2
{
    internal class OgrenciDers
    {
        public int Id { get; set; }
        public int? OgrenciId { get; set; }
        public  Students Ogrenci {  get; set; }
        public int? DersId { get; set; }
        public  Ders Ders { get; set; }
        

    }
}
