using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            float firstVariable; // This is a declaration
            firstVariable = 7f;

            bool on = true;
            bool off = false;

            char character = '?';

            //int, double, decimal, long, short, float

            byte byteExample = 255; // 0-255
            short shortExample = 32000;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 inMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

            float floatExample = 1.04523f;
            double doubleExample = 1.723423859325135023;
            decimal decimalExample = 1.234912312349m;


        }

        [TestMethod]
        public void Operators()
        {
            int numOne = 15;
            int numTwo = 7;

            // +, -, /, *, %
            int sum = numOne + numTwo;
            int diff = numOne - numTwo;
            int product = numOne * numTwo;
            int quotient = numOne / numTwo;
            int remainder = numOne % numTwo;



        }
        [TestMethod]
        public void ReferenceTypes()
        {
            string firstName = "Nicholas";
            string lastName = "Perry";

            //Concatenation
            string concatenatedFullName = firstName + lastName;

            //Composite Formatting
            string compositeFullname =
                string.Format("{0} {1}", firstName, lastName);

            //String Interpolation
            string interpolatedFullName = $"{firstName} {lastName}";

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(compositeFullname);
            Console.WriteLine(interpolatedFullName);

            //Other Reference Types - Objects
            DateTime today = DateTime.Now;
            DateTime someDay = new DateTime(1978, 1, 1);
            TimeSpan timeSpanExample = today - someDay;

            // Collections
            string banana = "An awesome fruit.";
            string[] stringArray = { "Hello", "World", "Why?", banana, "?" };
            string[] anotherArray = new string[17];

            List<string> listExample = new List<string>();
            listExample.Add(banana);
            Console.Write(listExample[0]);
            Queue<int> queueExample = new Queue<int>();
            Dictionary<int, string> dictionaryExample = new Dictionary<int, string>();

        }
    }
}