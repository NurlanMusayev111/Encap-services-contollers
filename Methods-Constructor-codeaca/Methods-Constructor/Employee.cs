using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Constructor
{
    internal class Employee
    {
        public string fullName;
        public string address;
        public int age;


        public string GetFullData()
        {
            return $"{fullName} - {address} - {age}";
        }
    }
}
