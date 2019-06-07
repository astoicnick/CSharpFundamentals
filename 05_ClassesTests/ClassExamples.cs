using System;
using _05_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_ClassesTests
{
    [TestClass]
    public class ClassExamples
    {
        [TestMethod]
        public void CookieExamples()
        {
            Customer nick = new Customer();

            Cookie snickerdoodle = new Cookie();
            snickerdoodle.SugarAmount = 150;

            Cookie chocolateChip = new Cookie(700, 10, 2.0, "chips a'hoy");
        }

        [TestMethod]
        public void VehicleExamples()
        {
            Vehicle myCar = new Vehicle();
            myCar.TypeOfVehicle = VehicleType.Minivan;
            myCar.Odometer = 152780;
            myCar.Make = "Dodge";
            myCar.Model = "Caravan Sport";
            myCar.Year = (2001);

            myCar.StartVehicle();
            Assert.IsTrue(myCar.IsRunning);

            myCar.StopVehicle();
            Assert.IsFalse(myCar.IsRunning);
        }
    }
}
