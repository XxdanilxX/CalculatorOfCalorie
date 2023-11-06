using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculatorOfCalorie
{
    internal class Person
    {
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double DailyCalorieNeeds;

        public Person(int height, int weight, int age, string gender)
        {
            Height = height;
            Weight = weight;
            Age = age;
            Gender = gender;
        }
        public void CalculateDailyCalorieNeeds()
        {
            if (Gender == "Мужской")
            {
                DailyCalorieNeeds = (10 * Weight) + (6.25 * Height) - (5 * Age) + 5;
            }
            else if (Gender == "Женский")
            {
                DailyCalorieNeeds = (10 * Weight) + (6.25 * Height) - (5 * Age) - 161;
            }
        }
    }
}
