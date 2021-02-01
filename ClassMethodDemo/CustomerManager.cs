using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Remove(List<Customer> customer, int Id)
        {
            foreach (var i in customer)
            {
                if (i.CustomerId == Id)
                {
                    Console.WriteLine("Customer Successfully Deleted!:\n" + i.CustomerId + " " + i.CustomerName + " " + i.CustomerSurname);
                }

            }

        }

        public void Add(Customer customer)
        {
            Console.WriteLine("Customer ID=");
            customer.CustomerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Customer Name:\n ");
            customer.CustomerName = Console.ReadLine();

            Console.WriteLine("Customer Surname:\n");
            customer.CustomerSurname = Console.ReadLine();

            Console.WriteLine("Customer Successfully Added!'\n" + customer.CustomerId + " " + customer.CustomerName + " " + customer.CustomerSurname);


        }

        public void Listing(List<Customer> customers)
        {

            foreach (var customer in customers)
            {
                Console.WriteLine("ID: " + customer.CustomerId + "\nName Surname: " + customer.CustomerName + " " + customer.CustomerSurname);
                Console.WriteLine("~~~~~~~~~~~~");
            }


        }



    }
}
