using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //Müşteriler
            Customer c1 = new Customer()
            {
                Id = 1,
                Name = "Nur",
                LastName = "Cöer",
            };
            Customer c2 = new Customer()
            {
                Id = 1,
                Name = "Türkan",
                LastName = "Cöer",
            };
            Customer c3 = new Customer()
            {
                Id = 1,
                Name = "Emre",
                LastName = "Cöer",
            };
            Customer c4 = new Customer()
            {
                Id = 1,
                Name = "Ali",
                LastName = "Cöer",
            };


            //İşlemler
            Console.WriteLine("\n\n------Ekleme-------\n\n");
            customerManager.AddToCustomer(c1);
            customerManager.AddToCustomer(c2);
            customerManager.AddToCustomer(c3);
            customerManager.AddToCustomer(c4);


            Console.WriteLine("\n\n------Listeleme-------\n\n");
            List<Customer> customers = customerManager.GetCustomers();
            ListCustomer(customers);

            Console.WriteLine("\n\n------Silme-------\n\n");
            customers = customerManager.RemovoFromCustomer(c1);
            ListCustomer(customers);

            Console.ReadLine();

        

            //Listeleme işlemini ekrana yazdıran fonksiyon
            void ListCustomer(List<Customer> Lcustomers)
            {
                foreach (Customer customerItem in Lcustomers)
                {
                    Console.WriteLine(customerItem.Name);
                }
            }
        }

        
    }
}
