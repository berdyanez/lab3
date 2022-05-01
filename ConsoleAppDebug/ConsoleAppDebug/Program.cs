using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleAppDebug
{
    class Test
    {
        static void Main()
        {
            Debugg debuggg = new Debugg();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Write your name:");
            debuggg.writen = Console.ReadLine();
            Console.WriteLine("Write your age:");
            debuggg.writea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write your height:");
            debuggg.height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Name:{debuggg.writen} Age:{debuggg.writea}y.o Height:{debuggg.height}cm");
            Debug.WriteLine($"Name:{debuggg.writen} Age:{debuggg.writea}y.o Height:{debuggg.height}cm");
        }
    }
}
