using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the amount of paints");
            int points = int.Parse(Console.ReadLine());
            switch (points)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Your points are {0}", points*10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Your points are {0}", points * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Your points are {0}", points * 1000);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.ReadLine();
        }
    }
}
