using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
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
            if (a==0||b==0||c==0)
            {
                Console.WriteLine("The product of the threee numbers is 0");
            }
            else if ((a<0&&b>0&&c>0)||(b<0&&c>0&&a>0)||(c<0&&b>0&&a>0)||(a<0&&b<0&&c<0))
            {
                Console.WriteLine("The product of the numbers is negative");
            }
            else
            {
                Console.WriteLine("The product of the numbers is positive");
            }
            Console.ReadLine();
        }
    }
}
