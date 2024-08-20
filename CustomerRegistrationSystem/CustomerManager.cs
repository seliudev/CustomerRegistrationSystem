using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationSystem
{
    internal class CustomerManager
    {
        public CustomerManager()
        {
            //Database Simulation

            customers = new List<Customer>()
            {
                new Customer{CustomerId = 121, FirstName = "Oscar", LastName = "Jones", City = "Boston", Email = "oscarj@"},
                new Customer{CustomerId = 122, FirstName = "Alice", LastName = "Brown", City = "London", Email = "aliceb@"},
                new Customer{CustomerId = 123, FirstName = "Rebecca", LastName = "Williams", City = "Houston", Email = "rebeccaw@"},
            };
        }
        List<Customer> customers;

        public List<Customer> GetAllCustomers()
        {
            return customers; 
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }

    }
}
