using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class MethodExamples
    {
        [TestMethod]
        public void Methods()
        {
            Console.WriteLine(AddTwoNumbers(1, 5));
        }

        private int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

    }
}
