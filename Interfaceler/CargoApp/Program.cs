using CargoApp;

Paket paket = new Paket();
paket.PaketBoyutu = PaketBoyutu.Orta;
paket.OdemePesinMiYapilacak = false;
//paket.KargoFirmasi = new MngKargo();
paket.KargoFirmasi = new TrendyolKargo();  
paket.Gonder();
Console.WriteLine("*************");
paket.Al();
