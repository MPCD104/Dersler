using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Kutuphane.Entities.ETicaretEntity
{
    internal class MusteriSiparis
    {
        public int Id { get; set; }//Sipariş No

        public int MusteriId { get; set; }
        public int UrunId { get; set; }
        public int Adet { get; set; }
        public decimal ToplamFiyat { get; set; }
    }
}
//MÜŞTERİ SİPARİŞ
//Sipariş NO:123123132  
//MüşteriId : 1
//UrunId : 5
//Adet : 2
//Fiyat : 900

//Müşteri
//ID : 1
//AD SOYAD : Ali Fuat

//URUN
//ID: 5
//ADI : PC
//FİYAT: 450
//STOK ADEDİ : 100
