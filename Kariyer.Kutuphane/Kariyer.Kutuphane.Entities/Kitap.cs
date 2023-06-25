namespace Kariyer.Kutuphane.Entities
{
    public class Kitap : BaseEntity
    { 
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public YayinEvi YayinEvi { get; set; }
        public Yazar Yazar { get; set; }
        public Tur Tur { get; set; }
    }
}
