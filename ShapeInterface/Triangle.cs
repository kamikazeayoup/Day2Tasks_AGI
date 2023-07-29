using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterface
{
    internal class Triangle : Ishape
    {
        public double Area { get; set; }
        public double Height { get; set; }
        public double Base { get; set; }
        public Triangle(double _height , double _base)
        {
            Height = _height;
            Base = _base;
        }
        public void CalculateArea()
        {
            Area = 0.5 * Base * Height;
        }
        public string GetArea() => $"The Area of Triangle is {Area}";

    }
}
