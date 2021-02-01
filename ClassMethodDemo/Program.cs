using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Ted";
            customer1.Surname = "Mosby";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Barney";
            customer2.Surname = "Stinson";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Lily";
            customer3.Surname = "Aldrin";

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Name = "Robin";
            customer4.Surname = "Scherbatsky";

            List<Customer> customerList = new List<Customer> { customer1, customer2, customer3, customer4 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.List(customerList);

            Console.ReadLine();
        }
    }
}
