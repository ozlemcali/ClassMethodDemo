using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerName = "SELMA";
            customer1.CustomerSurname = "CALİ";
            customer1.CustomerId = 1;



            Customer customer2 = new Customer();
            customer2.CustomerName = "ESRA";
            customer2.CustomerSurname = "CALİ";
            customer2.CustomerId = 2;

            Customer customer3 = new Customer();
            customer3.CustomerName = "ZEYNEP";
            customer3.CustomerSurname = "BİLMEZ";
            customer3.CustomerId = 3;

            Operations();

            void Operations()
            {
                Console.WriteLine("Select an operation: \nAdded (1) \nRemove (2)  \nListing (3)");
                int selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        {
                            Console.Clear();
                            Customer customer = new Customer();
                            CustomerManager customerManager = new CustomerManager();
                            customerManager.Add(customer);
                            Console.WriteLine("~~~~~~~~~~~~~~~~");
                            Operations();
                            break;

                        }
                    case 2:
                        {
                            Console.Clear();
                            CustomerManager customerManager = new CustomerManager();
                            List<Customer> customer = new List<Customer> { customer1, customer2, customer3 };
                            foreach (var c in customer)
                            {
                                Console.WriteLine("Customer ID: " + c.CustomerId + " Customer Name Surname: " + c.CustomerName + " " + c.CustomerSurname);
                                Console.WriteLine("~~~~~~~~~~~~~~~~");
                            }

                            Console.WriteLine("\nEnter the customer's ID  to be deleted: ");
                            int Id = Convert.ToInt32(Console.ReadLine());
                            customerManager.Remove(customer, Id);

                            break;
                        }


                    case 3:
                        {
                            Console.Clear();
                            List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };
                            CustomerManager customerManager = new CustomerManager();
                            customerManager.Listing(customers);
                            Console.WriteLine("~~~~~~~~~~~~~~~~");
                            Operations();
                            break;
                        }
                    default:
                        Console.WriteLine("Default Case!");
                        break;


                }
            }




        }
    }
}



