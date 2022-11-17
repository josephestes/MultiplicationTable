/* 
 * This program outputs a multiplication table for the digits 1-10 multiplied by 1-10.
 * 
 * Program loops
 */

using System;
using static System.Console;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Set 10 as multiple limit and create variables to store the table axes factors
            const int MULTIPLE = 10;
            int digitsX;
            int digitsY;

            //Loops create each value in each row of the multiplication table
            for (digitsY = 1; digitsY <= MULTIPLE; ++digitsY)
            {
                //Calculate, align, and output values in a row
                for (digitsX = 1; digitsX <= MULTIPLE; ++digitsX)
                {
                    Write("{0,4}", (digitsY * digitsX));
                }
                //Separate each row of values
                WriteLine();
            }
        }
    }
}