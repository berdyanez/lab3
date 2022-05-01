using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLicense
{
    class License
    {
        public void AllowTrial()
        {
            int key1 = 111;
            int userkey1 = Convert.ToInt32(Console.ReadLine());
            if (key1 == userkey1)
                Console.WriteLine("Hello dear user,now you in trial mode!");
            else
                Console.WriteLine("Your key is incorrect");
        }
        public void AllowCommon()
        {
            int key2 = 333;
            int userkey2 = Convert.ToInt32(Console.ReadLine());
            if (key2 == userkey2)
                Console.WriteLine("Hello dear user,now you in common mode!");
            else
                Console.WriteLine("Your key is incorrect");
        }
        public void AllowPro() 
        {
            int key3 = 777;
            int userkey3 = Convert.ToInt32(Console.ReadLine());
            if (key3 == userkey3)
                Console.WriteLine("Hello dear user,now you in pro mode!");
            else
                Console.WriteLine("Your key is incorrect");
        }
    }
}
