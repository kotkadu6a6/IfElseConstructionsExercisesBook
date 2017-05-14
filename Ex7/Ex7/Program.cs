using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the value of a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of d: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of e: ");
            int e = int.Parse(Console.ReadLine());
            int max1 = new int();
            int max2 = new int();
            max1 = Math.Max(a, b);
            max2 = Math.Max(c, d);
            max1 = Math.Max(max1, max2);
            Console.WriteLine("The largest number is \"{0}\"",Math.Max(max1,e));
            Console.ReadLine();

        }
    }
}
