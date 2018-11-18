using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class Methods
    {
        public static void SumTwoIntegers()
        {
            //Complete the function solveMeFirst to compute the sum of two integers.

            //Function prototype:
            //int solveMeFirst(int a, int b);
            //where,
            //a is the first integer input.
            //b is the second integer input
            //Return values sum of the above two integers

            Console.Write("Enter first integer: ");
            int numb1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer: ");
            int numb2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The sum of {numb1:n0} and {numb2:n0} is {(numb1 + numb2):n0}.\n");
        }

    }
}
