using Interfaceler;

List<Person> people = new List<Person>();

Person person = new Person();
person.AdSoyad = "Ali Fuat";
person.Yas = 20;

Person person2 = new Person
{
    AdSoyad = "Cem",
    Yas = 17,
};

Person person3 = new Person();
person.AdSoyad = "Ali Fuat";
person.Yas = 20;

people.Add(person);

people.Add(person2);

people.Add(person3);

people.Add(new Person
{
    AdSoyad = "Zafer",
    Yas = 20,
});

people.Remove(new Person
{
    AdSoyad = "Zafer",
    Yas = 20,
});
people.Remove(person);


bool kisiListedeVarmi = people.Contains(person);


List<Person> yeniListe = new List<Person>();
yeniListe.Add(new Person { Yas = 20, AdSoyad = "Ecem" });


people.AddRange(yeniListe);

Person personVarmi = new Person();
personVarmi.AdSoyad = "Ali Fuat";
personVarmi.Yas = 20;

bool evetVar = false;

foreach (Person person1 in people)
{
    if (person1.AdSoyad == personVarmi.AdSoyad)
    {
        evetVar = true;
        break;
    }
}

evetVar = people.Any(p => p.AdSoyad == personVarmi.AdSoyad);

people.OrderBy(x => x.AdSoyad).ThenBy(x => x.Yas);
people.OrderByDescending(x => x.Yas);

people.ConvertAll(x => x.Yas = x.Yas + 5);

people.Distinct();

people.ForEach(x => x.Yas = x.Yas + 5);

people.Count(x => x.Yas > 20);

people.Find(x => x.AdSoyad == "Ali");

people.FirstOrDefault(x => x.AdSoyad == "Ali");

people.Where(x => x.AdSoyad == "ali" && x.Yas > 20).Distinct().Any(x => x.AdSoyad == "ALi");

Methods method = new Methods();
