using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public class CustomerRepository
    {
        private List<Customer> _customerList = new List<Customer>();
        public void AddCustomer(Customer toAdd)
        {
            _customerList.Add(toAdd);
        }
        public List<Customer> GetListOfCustomers()
        {
            return _customerList;
        }
        public void UpdateCustomer(Customer toUpdate)
        {
            foreach (Customer customer in _customerList)
            {
                if (customer.ID == toUpdate.ID)
                {
                    customer.ID = toUpdate.ID;
                    customer.LastName = toUpdate.LastName;
                    customer.Age = toUpdate.Age;
                    customer.EnrollmentDate = toUpdate.EnrollmentDate;
                    customer.YearsUsingKomodo = toUpdate.YearsUsingKomodo;
                }
            }
        }
        public void RemoveCustomer(int toRemove)
        {
            Customer customerToRemove = new Customer();
            foreach (Customer customer in _customerList)
            {
                if (customer.ID == toRemove)
                {
                    customerToRemove = customer;
                }
            }
            _customerList.Remove(customerToRemove);
        }
    }
}
