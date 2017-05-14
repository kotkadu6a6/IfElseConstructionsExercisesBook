using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
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
            if (a>b&&a>c)
            {
                Console.WriteLine("The biggest number is \"a\"");
            }
            else if (b>a)
            {
                Console.WriteLine("The biggest number is \"b\"");
            }
            else
            {
                Console.WriteLine("The biggest number is \"c\"");
            }
            Console.ReadLine();
        }
    }
}
