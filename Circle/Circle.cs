using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius \"r\": ");
            double r = double.Parse(Console.ReadLine());

            double perimeter = 2 * r * Math.PI;
            double area = Math.PI * r * r;

            

            Console.WriteLine("{0:F2} {1:F2}", perimeter, area);


        }
    }
}
