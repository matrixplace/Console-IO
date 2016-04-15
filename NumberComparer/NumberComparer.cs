using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());

            if ( numberA > numberB)
            {
                Console.WriteLine(numberA);
            }
            else
            {
                Console.WriteLine(numberB);
            }

        }
    }
}
