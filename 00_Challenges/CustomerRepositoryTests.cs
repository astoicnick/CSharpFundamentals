using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    [TestClass]
    public class CustomerRepositoryTests
    {
        CustomerRepository _customerRepo;
        Customer testCustomer;
        Customer testCustomerTwo;
        Customer testUpdateCustomer;
        List<Customer> _customerList;

        [TestInitialize]
        public void Arrange()
        {
            _customerList = new List<Customer>();
            _customerRepo = new CustomerRepository();
            testCustomer = new Customer(1,"Perry",18,"08/29/2000",18);
            testCustomerTwo = new Customer(2, "Morrison", 19, "12/2/1999", 19);
            testUpdateCustomer = new Customer(2, "Morrison", 19, "12/3/1999", 19);
        }
        [TestMethod]
        public void AddMethodTest()
        {
            //Act
            _customerRepo.AddCustomer(testCustomer);
            //Assert
            Assert.AreEqual(1, _customerRepo.GetListOfCustomers().Count);
        }
        [TestMethod]
        public void ReadMethodTest()
        {
            //Act & Asser
            Assert.AreEqual(_customerList.GetType(), _customerRepo.GetListOfCustomers().GetType());
        }
        [TestMethod]
        public void UpdateMethodTest()
        {
            //Act
            _customerRepo.AddCustomer(testCustomerTwo);
            Assert.IsTrue(_customerRepo.GetListOfCustomers().Count == 1);
            _customerRepo.UpdateCustomer(testUpdateCustomer);
            //Assert
            Assert.AreEqual(testUpdateCustomer.EnrollmentDate, testCustomerTwo.EnrollmentDate);
        }
        [TestMethod]
        public void RemoveMethodTest()
        {
            //Act
            _customerRepo.AddCustomer(testCustomerTwo);
            _customerRepo.RemoveCustomer(testCustomerTwo.ID);
            //Assert
            Assert.AreEqual(0,_customerRepo.GetListOfCustomers().Count);
        }
    }
}
