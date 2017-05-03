using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int a = 70;
            int location = Array.IndexOf(numbers, a) + 1;
            
            if (location == 0)
            {
                Console.WriteLine("The value a not found");
            }
            else
            {
                Console.WriteLine("THE VALUE OF 'a' is FOUND & it is located at position " + location + " of the array");

           }
            
            Console.ReadLine();

        }
    }
}
