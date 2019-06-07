using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_Challenges
{
    [TestClass]
    public class DayOneWhiteBoard
    {
        [TestMethod]
        public void ChallengeOne()
        {
            int dingus = 5;
            string dingii = "dingus";
            DateTime dingusTime = DateTime.UtcNow;
        }
        [TestMethod]
        public void ChallengeTwo()
        {
            Console.WriteLine("Are you wearing clothes? Answer 'True' or 'False'");
            string clothes = Console.ReadLine();

            switch (clothes)
            {
                case "True":
                    Console.WriteLine("Nice!");
                    break;
                case "False":
                    Console.WriteLine("Ew, put some clothes on!");
                    break;
            }

        }
        [TestMethod]
        public void Challenge3()
        {
            bool tracker = false;
            bool happy;
            Console.WriteLine("Are you happy? type 'true' or 'false' ");
            happy = bool.Parse(Console.ReadLine());

            while (tracker == false)
            {
                if (happy == true)
                {
                    Console.WriteLine("Yay!");
                    tracker = true;
                }
                else if (happy == false)
                {
                    Console.WriteLine("Why aren't you happy?");
                    tracker = true;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Please retype your answer");
                }
            }
        }

        [TestMethod]
        public void Challenge4()
        {
            // Create a method that takes two strings from the user and
            // outputs the concatenated string
            string wordOne = "Rick and";
            string wordTwo = "Morty is awesome!";
            string wordThree = "Just ask my socks!";
            Console.WriteLine(RickAndMortyCommercial(wordOne, wordTwo, wordThree));
        }
        private string RickAndMortyCommercial(string x, string y, string z)
        {
            return x + " " + y + " " + z;
        }

        [TestMethod]
        public void Challenge5(){
            string name = "Nick";
            Greet(name);
        }
        private void Greet(string name)
        {
            Console.WriteLine($"Hello, {name} ! How ya doin??");
        }
    }
}
