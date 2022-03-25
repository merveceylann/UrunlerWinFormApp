using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UygSinaviDeneme.Entity;

namespace UygSinaviDeneme.DataAccess
{
    public class UrunlerDenemeDbContext : DbContext
    {
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }

        public UrunlerDenemeDbContext()
        {
            Database.SetInitializer(new UrunlerDenemeDbCreator());
        }

        public class UrunlerDenemeDbCreator : CreateDatabaseIfNotExists<UrunlerDenemeDbContext>
        {
            public override void InitializeDatabase(UrunlerDenemeDbContext context)
            {
                base.InitializeDatabase(context);
            }
            protected override void Seed(UrunlerDenemeDbContext context)
            {
                for (int i = 0; i < 5; i++)
                {
                    Kategori kat = new Kategori();
                    kat.KategoriAdi = "Deneme" + i;

                    context.Kategoriler.Add(kat);
                }
                context.SaveChanges();

                List<Kategori> KategoriList = context.Kategoriler.ToList();

                foreach (Kategori item in KategoriList)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Urun urun = new Urun();
                        urun.UrunAdi = "urun" + i;
                        urun.UreticiFirma = "firma" + i;
                        urun.Fiyat = "fiyat" + i;
                        urun.Kategori = item;

                        context.Urunler.Add(urun);
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
