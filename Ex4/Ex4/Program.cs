using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
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
            if (a<b&&a<c)
            {
                if (b<c)
                {
                    Console.WriteLine(a+" "+b+" "+c);      
                }
                else
                {
                    Console.WriteLine(a + " " + c + " " + b);
                }
            }
            else if (b<c)
            {
                if (a<c)
                {
                    Console.WriteLine(b + " " + a + " " + c);
                }
                else
                {
                    Console.WriteLine(b + " " + c + " " + a);
                }
            }
            else
            {
                if (a<b)
                {
                    Console.WriteLine(c + " " + a + " " + b);
                }
                else
                {
                    Console.WriteLine(c + " " +b + " " + a);
                }
            }
            Console.ReadLine();
        }
    }
}
