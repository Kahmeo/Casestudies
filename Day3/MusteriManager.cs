using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler Müşteri Eklendi.");
            Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad);
            Console.WriteLine("--------------------");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Tebrikler Müşteri Listelendi.");
            Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad);
            Console.WriteLine("--------------------");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Tebrikler Müşteri Silindi.");
            Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad);
            Console.WriteLine("--------------------");
        }
    }
}
