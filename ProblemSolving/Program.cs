using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                Console.WriteLine("Choose an option from below:\n" +
                                "1) Add two integers\n" +
                                "X) Exit");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Add two integers.\n");
                        Methods.SumTwoIntegers();
                        break;
                    case "x":
                    case "X":
                        Console.WriteLine("Thanks for visiting!!\n");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.\n");
                        break;
                }
            } while (!exit);

        }
    }
}
