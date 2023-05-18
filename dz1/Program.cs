using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * ZADANIE 1
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 1 && a <= 100)
            {
                if (a % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (a % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (a % 3 == 0 && a % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(a);
                }
            }*/


            //ZADANIE 2
            /*
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((a/100)*b);*/


            //Zadanie 3

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a * 1000 + b * 100 + c * 10 + d);
            Console.ReadLine();
        }
    }
}
