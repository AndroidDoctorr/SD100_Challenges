using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceRepo_Repo
{
    public class InsuranceRepository
    {
        private readonly List<Customer> _customers = new List<Customer>();

        // CRUD
        public void AddNewCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new Exception("Customer is null!");
            }
            if (customer.Id == 0)
            {
                throw new Exception("Customer needs an ID");
            }
            _customers.Add(customer);
        }

        public void UpdateCustomer(int id, Customer newCustomer)
        {
            Customer customer = GetCustomerById(id);
            // customer.Name = newCustomer.Name;
        }

        public Customer GetCustomerById(int id)
        {
            return _customers.SingleOrDefault(c => c.Id == id);
        }

        public void SendCustomerMessage(int id)
        {
            Console.WriteLine("Email: blah blah, Message: blah blah");
        }

        public void SendCustomerMessages()
        {
            // get the whole list
            // loop through list
            //     figure out the right message
            //     send message to each user
        }

        public override string ToString()
        {
            return string.Join(", ", _customers.Select(c => c.ToString()));
        }
    }
}
