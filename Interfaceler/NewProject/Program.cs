using Interfaceler;

int sayi = 5;

Random random = new Random();
random.Next(0, 5);

List<Person> list = new List<Person>();
list.Add(new Person()
{
    AdSoyad = "Ali",
    Yas = 22
}) ;

list.Add(new Person()
{
    AdSoyad = "Ali Fuat",
    Yas = 22
});
Methods methods = new Methods(list);
methods.KisiListesiniGoster();