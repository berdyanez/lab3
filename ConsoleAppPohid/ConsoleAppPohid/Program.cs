using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleAppPohid
{
    class B
    {
        public string Hello { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Poka { get; set; }
        public void SayHello()
        {
            B bar = new B();
            Console.WriteLine("Hello");
        }
    }
    class C : B
    {
        public void SayPoka() 
        {
            C name = new C();
            name.Poka = "Have a nice day";
            Console.WriteLine(name.Poka);
        }
    }
    class D : B 
    {
        public void PrintData() 
        {
            D data = new D();
            Console.WriteLine("Write your name");
            data.Name = Console.ReadLine();
            Console.WriteLine("Write your age");
            data.Age = Convert.ToInt32(Console.ReadLine());
        }
    
    }
    class Program 
    {
        static void Main() 
        {
            Program program = new Program();
            B bar = new B();
            bar.SayHello();
            D data = new D();
            data.PrintData();
            C name = new C();
            name.SayPoka();
            Console.ReadKey();
        }
    }
}
   


