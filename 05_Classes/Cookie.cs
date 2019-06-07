using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Cookie
    {
        public int SugarAmount { get; set; } //Property
        public int ChipCount { get; set; }
        public double Diameter { get; set; }
        public string Texture { get; set; } //How to make that public string only one of a few?
        // Chip count, 
        public Cookie()
        {

        }
        public Cookie(int sugarAmount, int chipCount, double diameter, string texture)
        {
            SugarAmount = sugarAmount;
            ChipCount = chipCount;
            Diameter = diameter;
            Texture = texture;
        }
    }
}
