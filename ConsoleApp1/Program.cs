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
            int a = 60;
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
                Console.WriteLine("THE VALUE OF a is FOUND");
            }
            else
            {
                Console.WriteLine("The value a not found");
            }
            Console.ReadLine();

        }
    }
}
