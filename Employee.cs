using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyClass
{
    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CodeReg { get; set; }
        public string Develop { get; set; }
        public Employee(string n, string s, string d)
        {
            Name = n;
            Surname = s;
            Develop = d;
        }

    }
}
