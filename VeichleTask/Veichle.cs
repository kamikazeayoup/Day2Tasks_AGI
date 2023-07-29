using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeichleTask
{
    internal class Veichle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"Your Veichle model is {Model} and make is {Make} and year is {Year}";
        }

    }
}
