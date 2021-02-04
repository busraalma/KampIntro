using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerId = "12345";
            customer1.Name = "Ted";
            customer1.Surname = "Mosby";
            customer1.TcNo = "22222222222";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerId = "12346";
            customer2.CompanyName = "HIMYM";
            customer2.TaxNo = "8333333333";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}
