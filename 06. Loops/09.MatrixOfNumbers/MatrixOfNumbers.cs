﻿/* Problem 9. Matrix of Numbers
Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops. 
Examples:
 n   matrix      n   matrix       n   matrix  
 2   1 2         3   1 2 3        4   1 2 3 4 
     2 3             2 3 4            2 3 4 5 
                     3 4 5            3 4 5 6 
                                      4 5 6 7 
*/

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());

        if (n < 1 || n > 20)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < (i + n); j++)
                {
                    Console.Write("{0, 3}", j);
                }
                Console.WriteLine();
            }
        }
    }
}

