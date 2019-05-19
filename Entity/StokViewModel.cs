using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class StokViewModel
    {
        public int AyakkabiId { get; set; }
        public int Adet { get; set; }
        public int Numara { get; set; }
        public StokHareketTipi islemTipi { get; set; }

        
    }
    public enum StokHareketTipi
    {
        Cikis,
        Giris
    }
}
