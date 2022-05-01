using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleAppPohidDebug
{
    class Program
    {
        static void Main()
        {
            Program program = new Program();
            Second name = new Second();
            Third age = new Third();
            Fourth salary = new Fourth();
            Console.WriteLine("Name:");
            name.SayName();
            Console.WriteLine("Age:");
            age.SayAge();
            Console.WriteLine("Salary:");
            salary.SaySalary();
        }
    }
}
