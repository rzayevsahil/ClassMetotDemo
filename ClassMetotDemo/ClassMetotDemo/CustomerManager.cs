using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri başarıyla eklendi!" + "--->" + customer.FirstName + " " + customer.LastName + "\n\n");
            
        }

        
        public void Delete(Customer customer)
        {
            Console.WriteLine("\n\n*************************************\n");
            Console.WriteLine("Müşteri " + customer.FirstName + " " + customer.LastName + " silindi!!!\n");
            customer.Id = 0;
            /*customer.FirstName = "";
            customer.LastName = "";
            customer.PhoneNumber = 0;
            customer.AccountNumber = 0;
            customer.Balance = 0;*/
            Console.WriteLine("*************************************\n");
            
        }



        
        public void List(Customer customer)
        {


            if (customer.Id == 0) { Console.WriteLine("   Bu müşteri silinmiştir!!!    \n"); }
            else
            {
                Console.WriteLine("Customer Id: " + customer.Id + "\n" + "Customer First Name: " + customer.FirstName + "\n" +
                "Customer Last Name: " + customer.LastName + "\n" + "Customer PhoneNumber: " + customer.PhoneNumber + "\n" +
                "Customer Acoount Number: " + customer.AccountNumber + "\n" + "Customer Balance: " + customer.Balance + " TL\n");
                Console.WriteLine("---------------");
                
                
            }

            
            
            Console.WriteLine("---------------");
        }

        
    }
}
