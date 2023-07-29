using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterface
{
    internal class Square : Ishape
    {
        public double Side { get; set; }
        public double Area { get; set; }
        public Square(double side)
        {
            Side = side;        
        }
        
        public void CalculateArea()
        {
            Area = Side * Side;
            
        }
        public string GetArea() => $"The Area of Square is {Area}";

    }
}
