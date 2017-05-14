using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of variable (int, double, string)");
            string input = Console.ReadLine();
            switch (input)
            {
                case "int":
                    Console.WriteLine("Input your number");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(number + 1);
                    break;
                case "double":
                    Console.WriteLine("Input your number");
                    double numberDouble = Convert.ToDouble((Console.ReadLine()));
                    Console.WriteLine(numberDouble + 1);
                    break;
                case "string":
                    Console.WriteLine("Input your string");
                    string sentece = Console.ReadLine();
                    Console.WriteLine(sentece+" *");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
