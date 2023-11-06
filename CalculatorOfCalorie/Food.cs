using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfCalorie
{
    internal class Food
    {
        public string Name { get; set; }
        public int Calories { get; set; }

        public Food(string name, int calories)
        {
            Name = name;
            Calories = calories;
        }

    }
}
