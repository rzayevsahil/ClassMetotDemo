using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            Customer customer1 = new Customer();
            customer1.Id = 10001;
            customer1.FirstName = "Leyla";
            customer1.LastName = "Öztürk";
            customer1.PhoneNumber = 5527894565;
            customer1.AccountNumber = 6001245988;
            customer1.Balance=3564.78;

            Customer customer2 = new Customer();
            customer2.Id = 10002;
            customer2.FirstName = "Tuncay";
            customer2.LastName = "Şentürk";
            customer2.PhoneNumber = 5535443218;
            customer2.AccountNumber = 9001861104;
            customer2.Balance = 1742.61;

            Customer customer3 = new Customer();
            customer3.Id = 10003;
            customer3.FirstName = "Deniz";
            customer3.LastName = "Yaman";
            customer3.PhoneNumber = 5525558448;
            customer3.AccountNumber = 6001623765;
            customer3.Balance = 2397.77;

            CustomerManager customerManager = new CustomerManager();

            Customer[] customer = new Customer[] { customer1, customer2, customer3 };
            int j = 1;

            
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            for (int i = 0; i < customer.Length; i++)
            {
                Console.WriteLine("\n****** " + j + ".Müşteri Bilgisi ******\n");
                customerManager.List(customer[i]);
                j++;
            }


            customerManager.Delete(customer2);

            j = 1;
            for (int i = 0; i < customer.Length; i++)
            {
                Console.WriteLine("\n****** " + j + ".Müşteri Bilgisi ******\n");
                customerManager.List(customer[i]);
                j++;
            }
           
            

            

            Console.ReadLine();
        }
    }
}
