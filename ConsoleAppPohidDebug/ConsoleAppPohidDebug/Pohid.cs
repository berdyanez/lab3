using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleAppPohidDebug
{
    class First
    {
        public string Name;
        public int Age;
        public int Salary;
    }
    class Second : First
    {
        public void SayName()
        {
            Second name = new Second();
            name.Name = "Andii";
            Console.WriteLine(name.Name);
            Debug.WriteLine($"Name:{name.Name}");
        }
    }
    class Third : Second
    {
        public void SayAge()
        {
            Third age = new Third();
            age.Age = 18;
            Console.WriteLine(age.Age);
            Debug.WriteLine($"Age:{age.Age}");
        }
    }
    class Fourth : Third
    {
        public void SaySalary()
        {
            Fourth salary = new Fourth();
            salary.Salary = 1234;
            Console.WriteLine(salary.Salary);
            Debug.WriteLine($"Salary:{salary.Salary}");
        }
    }
}
