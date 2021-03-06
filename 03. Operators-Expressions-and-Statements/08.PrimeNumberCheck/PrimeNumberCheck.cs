﻿/* Problem 8. Prime Number Check
Write an expression that checks if given positive integer number n (n ≤ 100) is prime 
(i.e. it is divisible without remainder only to itself and 1). 
Examples:
n	Prime?
1	false
2	true
3	true
4	false
9	false
97	true
51	false
-3	false
0	false
*/ 
using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (n > 1 && n <= 100)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime);
        }
        else
        {
            isPrime = false;
            Console.WriteLine(isPrime);
        }
    }
}

