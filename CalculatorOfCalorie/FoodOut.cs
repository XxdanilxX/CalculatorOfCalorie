using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfCalorie
{
    internal class FoodOut
    {
        public string Name { get; set; }
        public double Gram { get; set; }
        public double Cal { get; set; }
        public FoodOut(string name, double gram, double cal)
        {
            Name = name;
            Gram = gram;
            Cal = cal;
        }
    }
}
