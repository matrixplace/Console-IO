using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowCalculator
{
    class PowCalculator
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число: ");
            double number = double.Parse(Console.ReadLine());

            Console.Write("Въведете степен: ");
            double pow = double.Parse(Console.ReadLine());

            double sum = Math.Pow(number, pow);

            Console.WriteLine("Резултатът е: {0}",sum);
        }
    }
}
