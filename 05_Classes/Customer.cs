using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Customer
    {
        public string FullName { get; set; }
        public int CustomerID { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        public int AccidentCount { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Premium { get; set; }
        
        public Customer() { }
        public Customer(string fullName, int customerID, int age, Address address, 
            int accidentCount, string phoneNumber, decimal premium)
        {
            FullName = fullName;
            CustomerID = customerID;
            Age = age;
            Address = address;
            AccidentCount = accidentCount;
            PhoneNumber = phoneNumber;
            Premium = premium;
        }
    }
}
