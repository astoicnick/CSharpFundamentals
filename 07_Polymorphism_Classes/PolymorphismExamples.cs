using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Polymorphism_Classes
{
    public class Animal
    {
        public int EyeCount { get; set; }
        public int LegCount { get; set; }
        public double WeightInFreedomeUnits { get; set; }
        public bool HasTail { get; set; }
        public bool HasFur { get; set; }
        public Animal() {}
        public Animal(int eyeCount, int legCount, double weight, bool hasTail,
            bool hasFur)
        {
            EyeCount = eyeCount;
            LegCount = legCount;
            WeightInFreedomeUnits = weight;
            HasTail = hasTail;
            HasFur = hasFur;
            Console.WriteLine("Animal Constructor");
        }
    }
    public class Sloth : Animal
    {
        public Sloth()
        {
            Console.WriteLine("Sloth constructor");
        }
        public Sloth(int legCount, int eyeCount, bool hasFur, bool hasTail,
            double weight)
        {

        }
       public bool IsSlow
        {
            get
            {
                return true;
            }
        }

    }
    public class Megatherium : Sloth
    {

    }
    public class Cat : Animal
    {
        public Cat() { }
        public Cat(int eyeCount, int legCount, double weight, bool hasTail, bool hasFur,
            double clawLength) : base(eyeCount, legCount, weight, hasTail, hasFur)
        {
            ClawLengthInInches = clawLength;
        }
        public double ClawLengthInInches { get; set; }
        public virtual void MakeSound()
        {
            Console.WriteLine("Meow.");
        }
    }
    public class Liger : Cat
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Roar.");
        }
    }
    public class TabbyCat : Cat
    {
        public new void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Purr!");
        }
    }
}
