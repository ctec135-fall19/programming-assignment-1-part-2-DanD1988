/*
Author: Daniel Davidson
Date:   10/09/2019
CTEC 135: Microsoft Software Development with C# 

Module 2, Programming Assignment 1, Problem 2

    Prob 2: Iteration Constructs

For this problem print out the numbers 1-5 using several different loop structures.

1. print 1-5 with spaces between the numbers on a single line using a for loop
2. print 1-5 with spaces between the numbers on a single line using a while loop
3. print 1-5 with spaces between the numbers on a single line using a do/while loop
HINT: use Write() instead of WriteLine() in the loop body. Follow the loop with a 
WriteLine() call to insert the newline character at the end of the sequence.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region for loop
            Console.WriteLine("for loop");
            Console.ReadLine();
            Console.WriteLine("print 1-5 with spaces between the numbers on a single line using a for loop");
            Console.ReadLine();

            for(int i=1; i<6; i++)
            {
                Console.Write("{0 } ", i);
            }

            Console.WriteLine();
            
            #endregion

            #region while loop
            Console.WriteLine("\nwhile loop");
            Console.ReadLine();
            Console.WriteLine("print 1-5 with spaces between the numbers on a single line using a while loop");
            Console.ReadLine();

            int count = 1;

            while (count < 6)
            {
                Console.Write("{0} ", count);
                count++;
            }
            Console.WriteLine();
            #endregion

            #region do/while
            Console.WriteLine("\ndo/while loop");
            Console.ReadLine();
            Console.WriteLine("print 1-5 with spaces between the numbers on a single line using a do/while loop");
            Console.ReadLine();

            int j = 1;

            do
            {
                Console.Write("{0} ", j);

                j++;
            } while (j < 6);
            Console.WriteLine();
            

            

            #endregion
        }
    }
}
