namespace Kariyer.Kutuphane.Entities
{
    public class Uye : BaseEntity
    {
        public string Adi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime UyelikTarihi { get; set; }
        public string KullaniciAdi { get; set; }
        public bool UyelikAktifMi { get; set; }
    }
}
