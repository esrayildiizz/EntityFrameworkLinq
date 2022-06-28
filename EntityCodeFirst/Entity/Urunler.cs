using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    public class Urunler
    {
        public int UrunID { get; set; } 
        public string UrunAd { get; set; }  
        public string UrunMarka { get; set; }
        public string UrunKategori { get; set; }    
        public int UrunStok { get; set; }   

    }
}
