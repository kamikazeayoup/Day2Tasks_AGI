using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterface
{
    internal interface Ishape
    {

        public double Area { get; set; }
        public void CalculateArea();

        public string GetArea();
        
    }
}
