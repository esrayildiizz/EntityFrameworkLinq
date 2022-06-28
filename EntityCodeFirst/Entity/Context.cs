using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityCodeFirst.Entity
{
    internal class Context:DbContext
    {
        //DbSet: Veri tabanını ayarla demek.
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Musteri> Musteris{ get; set; }

    }


}
