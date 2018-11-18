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
                                "2) Sum integer array elements\n" +
                                "3) Compare two triplet arrays\n" +
                                "X) Exit\n");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Add two integers\n");
                        Methods.SumTwoIntegers();
                        break;
                    case "2":
                        Console.WriteLine("Sum integer array elements\n");
                        Methods.SimpleArraySum();
                        break;
                    case "3":
                        Console.WriteLine("Compare two triplet arrays\n");
                        Methods.CompareTriplets();
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
