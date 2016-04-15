using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaci
{
    class Fibonaci
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long a = 0;
            long b = 1;
            long c = 0;

            if (n == 0)
            {
                return;
            }
            else if (n == 1)
            {
                Console.WriteLine(0);
                return;
            }

            Console.Write("{0}, {1}, ", a, b);

            for (long i = 2; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                if (i == n - 1)
                {
                    Console.Write("{0}", c);
                }
                else
                {
                    Console.Write("{0}, ", c);

                }


            }

        }
    }
}