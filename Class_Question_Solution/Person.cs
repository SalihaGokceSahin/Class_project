using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Question_Solution
{
    public class Person
    {
        protected int age;

        public void Greet()
        {
            Console.WriteLine("Hello!");
        }

        public void SetAge(int _age)
        {
            age = _age;
        }
    }
}
