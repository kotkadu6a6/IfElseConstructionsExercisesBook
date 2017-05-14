using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());
            int c = new int();
            if (a>b)
            {
                c = a;
                a = b;
                b = c;
            }
            Console.WriteLine("a = {0}, b = {1}",a,b);
            Console.ReadLine();

        }
    }
}
