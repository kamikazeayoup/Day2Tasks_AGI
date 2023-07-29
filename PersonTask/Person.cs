using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGI_Tasks_Day2
{
   internal class Person
    {
        public enum Types
        {
            Man = 1, Women = 2
        }

        public string Name{ get; set; }
        public int Age { get; set; }
        public Types Gender { get; set; }
        public override string ToString()
        {
            return ($"Name = {Name}\nAge = {Age}\nGender = {Gender}");
        }
    }
}
