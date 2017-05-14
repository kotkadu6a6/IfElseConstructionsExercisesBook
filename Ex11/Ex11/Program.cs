using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number (1-999)");
            int input = int.Parse(Console.ReadLine());
            int lastDigit = input % 10;
            int middleDigit = (input % 100) / 10;
            int firstDigit = input / 100;
            switch (firstDigit)
            {
                case 0:
                    switch (middleDigit)
                    {
                        case 0:
                            switch (lastDigit)
                            {
                                case 0:
                                    Console.WriteLine("zero");
                                    break;
                                case 1:
                                    Console.WriteLine("one"); break;
                                case 2:
                                    Console.WriteLine("two"); break;
                                case 3:
                                    Console.WriteLine("three"); break;
                                case 4:
                                    Console.WriteLine("four"); break;
                                case 5:
                                    Console.WriteLine("five"); break;
                                case 6:
                                    Console.WriteLine("six"); break;
                                case 7:
                                    Console.WriteLine("seven"); break;
                                case 8:
                                    Console.WriteLine("eight"); break;
                                case 9:
                                    Console.WriteLine("nine"); break;
                                default:
                                    Console.WriteLine("error");
                                    break;
                            }
                            break;
                        case 1:
                            switch (lastDigit)
                            {
                                case 0:
                                    Console.WriteLine("ten");
                                    break;
                                case 1:
                                    Console.WriteLine("eleven");
                                    break;
                                case 2:
                                    Console.WriteLine("twelve");
                                    break;
                                case 3:
                                    Console.WriteLine("thirteen");
                                    break;
                                case 4:
                                    Console.WriteLine("Fourteen");
                                    break;
                                    case 5:
                                    Console.WriteLine("fifteen");
                                    break;
                                case 6:
                                    Console.WriteLine("sixteen");
                                    break;
                                case 7:
                                    Console.WriteLine("seventeen");
                                    break;
                                case 8:
                                    Console.WriteLine("eighteen");
                                    break;
                                case 9:
                                    Console.WriteLine("nineteen");
                                    break;

                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }

                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
