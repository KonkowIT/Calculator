using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Person
    {
        private int _age = 23;
        public int GetAge()
        {
            return _age;
        }

        public void SetAge(int newAge)
        {
            _age = newAge;
        }
    }
}
