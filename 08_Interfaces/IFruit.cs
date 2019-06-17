using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces
{
    interface IFruit
    {
        string Name { get; }
        bool IsPeeled { get; set; }
        string Peel();

    }
    public class Grape : IFruit
    {
        public string Name => "Grape";
        public bool IsPeeled { get; set; }

        public string Peel()
        {
            IsPeeled = true;
            return "who peels grapes?";
        }
        public string Squeeze()
        {
            return "you squeeze the grape";
        }
    }
}
