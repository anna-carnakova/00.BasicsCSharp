﻿/* Problem 5. Formatting Numbers
Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c 
and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. 
The number a should be printed in hexadecimal, left aligned;
then the number a should be printed in binary form, padded with zeroes, 
then the number b should be printed with 2 digits after the decimal point, right aligned; 
the number c should be printed with 3 digits after the decimal point, left aligned. 
Examples:
a	 b	      c	         result
254  11.6	  0.5	     |FE        |0011111110|     11.60|0.500     |
499	 -0.5559  10000	     |1F3       |0111110011|     -0.56|10000     |
0	 3	      -0.1234	 |0         |0000000000|         3|-0.123    |
 */ 

using System;
using System.Globalization;
using System.Threading;

class FormattingNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("a = ");
        uint a = uint.Parse(Console.ReadLine());
        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("c = ");
        float c = float.Parse(Console.ReadLine());
        if (a >= 0 && a <= 500)
        {
            //Print "a" in hexadecimal, left aligned.
            Console.Write("|{0,-10:X}|", a);
            //Print "a" in binary, padded with zeroes
            Console.Write(Convert.ToString(a, 2).PadLeft(10, '0'));
            //Print "b" with 2 digits after the decimal point, right aligned
            Console.Write("|{0,10:0.##}", b);
            //Print "c" with 3 digits after the decimal point, left aligned
            Console.Write("|{0,-10:0.###}|", c);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}

