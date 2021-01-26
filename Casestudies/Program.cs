using System;

namespace Casestudies
{
    class Program
    {
        static void Main(string[] args)
    {
        Urun urun1 = new Urun();
        urun1.UrunAdi = "Iphone 12";
        urun1.Kategori = "Elektronik";
        urun1.Fiyati = "12300 $";

        Urun urun2 = new Urun();
        urun2.UrunAdi = "Polo Kazak";
        urun2.Kategori = "Giyim";
        urun2.Fiyati = "80 $";

        Urun urun3 = new Urun();
        urun3.UrunAdi = "Masa";
        urun3.Kategori = "Ev";
        urun3.Fiyati = "1000$";

        Urun[] products = new Urun[] { urun1, urun2, urun3 };

        foreach (var prod in products)
        {
            Console.WriteLine(prod.UrunAdi);
        }

        Console.WriteLine("--------------");

        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine(products[i].Kategori);
        }

        Console.WriteLine("--------------");

        int j = 0;
        while (j < products.Length)
        {
            Console.WriteLine(products[j].Fiyati);
            j++;
        }





    }
}

class Urun
{
    public string UrunAdi { get; set; }

    public string Kategori { get; set; }

    public string Fiyati { get; set; }
}
}
