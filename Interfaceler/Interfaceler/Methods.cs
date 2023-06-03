namespace Interfaceler
{
    public class Methods
    {
        List<Person> persons = new List<Person>();
        public Methods()
        {
            persons.Add(new Person() 
            {
                AdSoyad = "Ali Fuat",
                Yas= 20,
            });

            persons.Add(new Person()
            {
                AdSoyad = "Cem",
                Yas = 17,
            });

            persons.Add(new Person()
            {
                AdSoyad = "Zafer",
                Yas = 17,
            });
        }

        public Methods(List<Person> persons)
        {
            this.persons = persons;
        }

        
        internal protected Person? KisiBul(string isim, int yas) 
        {
            return persons.FirstOrDefault(person => person.AdSoyad == isim && person.Yas == yas);
        }

        public int Topla(int birinciSayi, int ikinciSayi) 
        {
            return birinciSayi + ikinciSayi;
        }

        public void SelamVer(string isim) 
        {
            persons.Add(new Person 
            {
                AdSoyad = isim,
                Yas=20,
            });
            Console.WriteLine($"Selam {isim}");
        }

        public void SiparisListesi() 
        {
            Console.WriteLine("Ekmek : 10 TL");
            Console.WriteLine("Dolar 25 TL");
        }

        public void KisiListesiniGoster() 
        {
            foreach (Person item in persons)
            {
                Console.WriteLine($"{item.AdSoyad} {item.Yas}");
            }
        }
    }
}
