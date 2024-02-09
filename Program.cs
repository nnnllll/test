using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()) ;
            Console.WriteLine(a) ;
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(b) ;
            if (a > b)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("число 1 > число 2");
                Console.ReadKey();
            }
            else if (a < b)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(("число 1 < число 2"));
                Console.ReadKey();
            }
            else if (a == b)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(("число 1 = число 2"));
                Console.ReadKey();
            }

        }


        }
    }

