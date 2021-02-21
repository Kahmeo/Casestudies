using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer1 = new Customer();
            customer1.City = "Ankara";
            customer1.Id = 1;
            customer1.FirstName = "Engin";
            customer1.LastName = "Demiroğ";

            Customer customer2 = new Customer()
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Derin",
                LastName = "Demir"
            };

            Console.WriteLine(customer2.FirstName);
        }
    }
}
