using Kariyer.Kutuphane.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kariyer.Kutuphane.DataAccess.Context
{
    public class KariyerKutuphaneContext : DbContext
    {
        public KariyerKutuphaneContext(DbContextOptions<KariyerKutuphaneContext> options) : base(options)
        {
            
        }

        public DbSet<Kitap> Kitap { get; set; }
        public DbSet<KutuphaneIslemleri> KutuphaneIslemleri { get; set; }
        public DbSet<Tur> Tur { get; set; }
        public DbSet<Uye> Uye { get; set; }
        public DbSet<YayinEvi> YayinEvi { get; set; }
        public DbSet<Yazar> Yazar { get; set; }

    }
}
