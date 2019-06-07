using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150_RepositoryPattern
{

    public enum DrinkSize
    {
        Small,
        Medium,
        Large,
        BigBoy
    }
    public class Menu
    {
        public string FoodName { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
        public DrinkSize SizeOfDrink { get; set; }

        public Menu() {}

        public Menu(string foodName, double price,
            bool isAvailable, DrinkSize sizeOfDrink)
        {
            FoodName = foodName;
            Price = price;
            IsAvailable = isAvailable;
            SizeOfDrink = sizeOfDrink;

        }
    }
}
