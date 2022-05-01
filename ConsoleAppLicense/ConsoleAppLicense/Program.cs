using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Ключи:111 для Trial,333 для Common,777 для Pro. 
 */

namespace ConsoleAppLicense
{
    class Program
    {
        static void Main() 
        {
            Console.WriteLine("Console App License in C#\r");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Trial Mode");
            Console.WriteLine("\ts - Common Mode");
            Console.WriteLine("\tm - Pro Mode");
            License license = new License();
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine("Write correct key please:");
                    license.AllowTrial();
                    break;
                case "s":
                    Console.WriteLine("Write correct key please:");
                    license.AllowCommon();
                    break;
                case "m":
                    Console.WriteLine("Write correct key please:");
                    license.AllowPro();
                    break;
                
            }
            Console.Write("Press any key to close the console app...");
            Console.ReadKey();
        }
    }
}
