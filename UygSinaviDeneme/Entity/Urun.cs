using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygSinaviDeneme.Entity
{
    public class Urun
    {
        public int Id { get; set; } 
        public int KategoriId { get; set; }
        public string UrunAdi { get; set; }
        public string Fiyat { get; set; }
        public string UreticiFirma { get; set; }
        public virtual Kategori Kategori { get; set; }
    }
}
