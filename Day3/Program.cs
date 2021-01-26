using System;

namespace ClassMetotDemo
{
    class Program
    {
        /*
          ClassMetotDemo isimli bir proje oluşturunuz.
          Bunu Github'a aktarınız.
          Projeniz şunu yapacak.

          Bir bankada müşteri takibi yapmak istiyorsunuz.
          Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id,Ad,Soyad....)
          MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak 
           Musteri ekleme, listeleme,silme gibi metotları simule ediniz.
        */

        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri
            {
                Id = 12,
                Ad = "Mehmet",
                Soyad = "Kahil"
            };

            Musteri musteri2 = new Musteri
            {
                Id = 103,
                Ad = "Emrah",
                Soyad = "Sahil"
            };
            
            Musteri musteri3 = new Musteri
            {
                Id = 6,
                Ad = "Samet",
                Soyad = "Öykü"
            };

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };


            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad);
                Console.WriteLine("--------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteri3);



        }
    }
}
