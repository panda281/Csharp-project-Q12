using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_project_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert 4 digit number. NOTE that the first digit must not be zero");
            int x = int.Parse(Console.ReadLine());

            int a = (x / 1000) % 10;
            int b = (x / 100) % 10;
            int c = (x / 10) % 10;
            int d = x % 10;

            Console.WriteLine("\nthe sum of the digits are {0}", a + b + c + d);
            Console.WriteLine("the reveresed order of the digits are: {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("the last digit in first position is: {0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("exchange between the second and the third digits: {0}{1}{2}{3}", a, c, b, d);
        }
    }
}
