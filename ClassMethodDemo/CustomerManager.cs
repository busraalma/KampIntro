using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer " + customer.Name + " " + customer.Surname + " added");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer " + customer.Name + " " + customer.Surname + " deleted");
        }

        public void List(List<Customer> customers)
        {
            Console.WriteLine("Customers :");
            foreach (var customer in customers)
            {
                Console.WriteLine("Id : " + customer.Id + " Name : " + customer.Name + " Surname : " + customer.Surname);
            }
        }
    }
}
