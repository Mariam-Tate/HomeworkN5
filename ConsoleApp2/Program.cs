using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region N1

            Console.WriteLine("write number");
            var number5 = Convert.ToInt32(Console.ReadLine());
            if (number5 % 5 > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

            #endregion

            #region N2

            var x = 5;
            var y = 10;
            if (x > y)
            {
                Console.WriteLine($"x+y= {x + y}");
                Console.WriteLine($"x-y= {x - y}");
                Console.WriteLine($"x*y= {x * y}");
                if (y != 0)
                {
                    Console.WriteLine($"x/y={x / y}");
                }
                else
                {
                    Console.WriteLine("Not Allowed To Divide By Zero");
                }
            }
            if (x < y)
            {
                Console.WriteLine($"x+y= {x + y}");
                Console.WriteLine($"y-x= {y - x}");
                Console.WriteLine($"x*y= {x * y}");
                if (x != 0)
                {
                    Console.WriteLine($"y/x={ y / x}");
                }
                else
                {
                    Console.WriteLine("Not Allowed To Divide By Zero");
                }
            }

            #endregion

            #region N3

            var a = 5;
            var b = 12;
            var c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);

            #endregion

            #region N4

            var number = 5;
            for (int i = 1; i < 10; i++) 
            {
                Console.WriteLine($"{number} * { i } = {number * i} ");

                    }

            #endregion

            #region N5
            var n = 10;
            int j;
            for ( j = 2; j < n; j=j+2)
            { 
                if (j % 2 == 0);
                {
                    var z = j * j;
                    Console.WriteLine(z);
                }
            }

            #endregion
        }
    }
}