using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterface
{
    internal class Circle : Ishape
    {
        public double Radius { get; set; }

        public const double PI = 3.14157;
        public double Area { get; set; }

        public Circle(double radius) 
        {
            Radius = radius;
        }
        public void CalculateArea()
        {
            Area = PI * Radius * Radius;
           
        }
        public string GetArea() => $"The Area of Circle is {Area}";

    }
}
