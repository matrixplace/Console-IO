using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNnumbers
{
    class SumOfNnumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double summary = 0;
            for (double i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                summary += number;
            }
            Console.WriteLine(summary);
        }
    }
}
