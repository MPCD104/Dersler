namespace ClassYapisi
{
    public class Sepet
    {
        //prop tab tab ile oluşturulabilir.
        public string UrunAdi { get; set; }
        public int UrunAdedi { get; set; }
        public int UrunFiyati { get; set; }
        public string Ekstra { get; set; }
        public void ToplamFiyat() 
        {
            int toplamFiyat = UrunAdedi * UrunFiyati;
            Console.WriteLine("Toplam Fiyat : "+ toplamFiyat);
        }
    }
}
