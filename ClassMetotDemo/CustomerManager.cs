using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        // musteri listesi
       List<Customer> customers =new List<Customer>();


        // musterileri listeleme
        public List<Customer> GetCustomers()
        {
            return customers;
        }


        //musteri ekleme
        public void AddToCustomer(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine(customer.Name + " adlı kişi Müşterilere eklendi");
        }


        //musteri silme
        public List<Customer> RemovoFromCustomer(Customer customer)
        {
            Customer RemovedCustomer = customers.Find(c => c.Id == customer.Id);
            //kullanıcının listenin içerisinde var olup olmadığını kontrol eder
            if (RemovedCustomer.Name == "")
            {
                // yoksa  uyarır.
                Console.WriteLine(" Kullanıcı zaten ekli değil.\n");
            }
            else
            {
                //varsa siler
                customers.Remove(customer);
                Console.WriteLine( RemovedCustomer.Name + " Adlı müşteri müşterilerden silindi.\n");
            }
            return customers;

        }
    }
}
