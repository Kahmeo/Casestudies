using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    { /*Senaryo
       Kahve dükkanları için müşteri yönetimi yapan bir sistem yazmak istiyoruz.
        Starbuks ve Nero firması için çalışıyoruz.
        iki firma da müşterilerini veri tabanına kaydetmek istiyor.
        Starbucks müşterileri kaydederken, mutlaka mernis doğrulaması istiyor. Nero müşteri kaydederken böyle bir şey istemiyor.
        Starbucks müşteriler için her kahve alımında yıldız kazandırmak istiyor.
       */
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer 
            { 
                DateOfBirth = new DateTime(1998, 12, 5), 
                FirsName = "Mehmet Ali", 
                LastName = "Kahiloğulları", 
                NationalityId = "44701228660"
            });
            Console.ReadLine();
        }
    }
}
