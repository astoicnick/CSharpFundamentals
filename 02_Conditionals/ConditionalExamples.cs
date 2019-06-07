using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void IfElseStatements()
        {
            int age = 18;

            if (age > 17)
            {
                Console.WriteLine("You're an adult.");
            }
            else if (age > 6)
            {
                Console.WriteLine("You're a kid.");
            }
            else if (age > 0)
            {
                Console.WriteLine("you're far too young to be on a computer");
            }
            else
            {
                Console.WriteLine("You're not born yet.");
            }
            if (age < 65 & age > 18)
            {
                // And comparison
            }
            if (age > 65 || age < 18)
            {
                // Or comparison
            }
            if (age != 19)
            {
                // This is funny... NOT
            }


        }

        [TestMethod]
        public void SwitchCases()
        {
            int age = 7;
            switch (age)
            {
                case 18:
                    // 18 Year old code
                    break;
                case 19:
                    // 19 Year old code
                    break;
                case 20:
                    // 20 Year old code
                    break;
                case 21:
                case 22:
                case 23:
                    // 21-23 Year old code
                    break;
                default:
                    // If no toher code is ture, do this
                    break;

            }
        }
        [TestMethod]
        public void Ternaries()
        {
            int age = 31;
            // (Something to evaluate) ? trueResult : falseResult
            bool isAdult = (age > 17) ? true : false;

            int numOne = 10;
            int numTwo = (numOne == 10) ? 30 : 20;
            Console.WriteLine((numOne == 10) ? "True" : "False");
        }
    }
}
