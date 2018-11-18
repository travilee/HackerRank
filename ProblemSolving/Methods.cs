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

        public static void SimpleArraySum()
        {
            //Given an array of integers, find the sum of its elements.
            //For example, if the array ar = [1,2,3], 1+2+3=6, so return 6.
            //Function Description
            //Complete the simpleArraySum function in the editor below.It must return the sum of the array elements as an integer.
            //simpleArraySum has the following parameter(s):
            //ar: an array of integers
            //Input Format
            //The first line contains an integer, , denoting the size of the array.
            //The second line contains  space - separated integers representing the array's elements.
            //Constraints
            //0 < n,ar[i] <= 1000
            //Output Format
            //Print the sum of the array's elements as a single integer.

            int[] arr1 = { 5, 8, 9, 10, 75, 96, 1, 0, 24, 8 };
            Console.WriteLine($"The sum of the elements in the integer array [5, 8, 9, 10, 75, 96, 1, 0, 24, 8] is {arr1.Sum():n0}.\n");
        }

        public static void CompareTriplets()
        {
            //Alice and Bob each created one problem for HackerRank. A reviewer rates the two challenges, awarding points on a scale from 1 to 100 for three categories: problem clarity, originality, and difficulty.

            //We define the rating for Alice's challenge to be the triplet a = (a[0], a[1], a[2]), and the rating for Bob's challenge to be the triplet b = (b[0], b[1], b[2]).

            //Your task is to find their comparison points by comparing a[0] with b[0], a[1] with b[1], and a[2] with a[2].

            //If a[i] > b[i], then Alice is awarded  point.
            //If a[i] < b[i], then Bob is awarded  point.
            //If a[i] = b[i], then neither person receives a point.
            //Comparison points is the total points a person earned.

            //Given a and b, determine their respective comparison points.

            //Return an array of two integers denoting the respective comparison points earned by Alice and Bob.

            int[] a = { 75, 62, 56 };
            int[] b = { 58, 91, 56 };
            int aScore = 0;
            int bScore = 0;
            
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > b[i])
                {
                    aScore++;
                }
                else if (a[i] < b[i])
                {
                    bScore++;
                }
            }
            int[] scoreArray = { aScore, bScore };

            Console.WriteLine($"For the two arrays a = [75, 62, 56] and b = [58, 91, 56], the comparitive score array is [{scoreArray[0]}, {scoreArray[1]}].\n");
        }
    }
}
