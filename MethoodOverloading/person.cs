using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethoodOverloading
{
    internal static class person
    {
        public static void GetWelcome()
        {
            Console.WriteLine("Welcome !");
        }
        public static void GetWelcome(string fname)
        {
            Console.WriteLine($"Welcome {fname} !");
        }
        public static string GetWelcome(string fname , string lname)
        {
           return ($"Welcome {fname} {lname} !");
        }

    }
}
