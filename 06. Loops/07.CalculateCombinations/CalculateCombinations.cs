﻿/* Problem 7. Calculate N! / (K! * (N-K)!)
In combinatorics, the number of ways to choose k different members out of a group of n different elements 
(also known as the number of combinations) is calculated by the following formula:
n! / (k! * (n-k)!)
For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. 
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops. 
Examples:
n	k	n! / (k! * (n-k)!)
3	2	3
4	2	6
10 	6	210
52	5	2598960
 */

using System;
using System.Numerics;

class CalculateCombinations
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger nkFactorial = 1;


        if (k <= 1 || k >= n || k >= 100 || n <= 1 || n >= 100)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                if (i <= k)
                {
                    kFactorial *= i;
                }
                nFactorial *= i;
            }
            for (int j = 1; j <= n-k; j++)
            {
                nkFactorial *= j;
            }
            Console.WriteLine(nFactorial / (kFactorial*nkFactorial));
        }
    }
}

