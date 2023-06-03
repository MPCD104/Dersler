namespace Kalitim
{
    public class Tasit
    {
        public YakitTuru YakitTuru { get; set; }

        public void Start()
        {
            Console.WriteLine("Araç çalıştırıldı.");
        }

        public void Stop()
        {
            Console.WriteLine("Araç durduruldu...");
        }
    }
}
