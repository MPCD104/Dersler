List<int> dizi = new List<int>();
dizi.Add(1000); // ekleme
dizi.Remove(1000); // çıkarma
dizi.Sort(); // k>b sıralama
dizi.Clear(); // temizleme
dizi.Contains(1000); // arama yapar varsa true yoksa false döner
dizi.Any(); // koşullu veya koşulsuz dizi içinde eleman olup olmadığını gösterir. true/false döner
dizi.AddRange(new List<int> { 1, 3, 4, 5 }); // içine birden fazla eleman eklemeye yarar.
int diziElemanSayisi = dizi.Count; // eleman sayısını verir.
dizi.First();//ilk elemanı verir
dizi.FirstOrDefault(); //ilk elemanı veya default değeri getirir.
dizi.IndexOf(1000); // index numarasını verir
dizi.Insert(0, 1); // 
dizi.OrderBy(x => x); // dizi.Sort();
dizi.OrderByDescending(x => x); //tersten sıralar
dizi.Max(); // içindeki maksimum değeri alır
dizi.Min(); // dizi içindeki minimum değeri alır.
//dizi.All(x=>x>5);
//dizi.Where()