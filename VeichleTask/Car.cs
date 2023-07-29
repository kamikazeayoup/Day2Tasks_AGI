using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeichleTask
{
    internal class Car : Veichle
    {

        public override string ToString()
        {
            return $"Your Car model is {Model} and make is {Make} and year is {Year}";
        }
    }
}
