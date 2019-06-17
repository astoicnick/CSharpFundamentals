using System;
using System.Collections.Generic;
using _07_Polymorphism_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_Polymorphism_Tests
{
    [TestClass]
    public class PolymorphismTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Animal firstAnimal = new Animal();
            firstAnimal.LegCount = 4;

            Sloth sloth = new Sloth();
            sloth.LegCount = 4;
            Console.WriteLine(sloth.IsSlow);

            Cat baseCat = new Cat();
            baseCat.MakeSound();

            TabbyCat tabby = new TabbyCat();
            Liger liger = new Liger();

            List<Animal> listOfAnimals = new List<Animal>();
            listOfAnimals.Add(baseCat);
            listOfAnimals.Add(tabby);
            listOfAnimals.Add(liger);
            listOfAnimals.Add(sloth);

            foreach (Animal animal in listOfAnimals)
            {
                if (animal is Cat)
                {
                    Cat cat = (Cat)animal;
                    cat.MakeSound();
                }
            }
        }
    }
}
