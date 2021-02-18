using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };

            Customer customer2 = new Customer();
            customer2.Id = 3;

            Customer customer3 = new Customer(2, "Derin", "Demiroğ", "Ankara");

            Console.WriteLine(customer3.FirstName);
        }
    }

    class Customer
    {
        //Default Constroctor
        public Customer()
        {
            
        }
        public Customer(int id,string firstName,string lastName,string city)
        {
            //Console.WriteLine("Yapıcı blok çalıştı");
            Id = id;  //gelen id yi Id ye aktarıyoruz
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
