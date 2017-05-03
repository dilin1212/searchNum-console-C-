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
            int a = 100;
            int location = Array.IndexOf(numbers, a) + 1;
            bool searchvalue = false;


            for (int i = 0; i < 10; i++)
            {
               
                if (numbers[i] == a)
                {
                   
                    searchvalue = true;
                    break;
                }
            }
            if (searchvalue)
            {
                Console.WriteLine("THE VALUE OF 'a' is FOUND & it is located at position " + location + " of the array");
              
            }
            else
            {
                Console.WriteLine("The value a not found");
            }
            Array.IndexOf(numbers, a);
            Console.ReadLine();

        }
    }
}
