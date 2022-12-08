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
            // Set 10 as multiple limit
            const int MULTIPLE = 10;

            // Create the multiplication table
            var table = new string[MULTIPLE];

            for (int digitsY = 1; digitsY <= MULTIPLE; ++digitsY)
            {
                var row = new string[MULTIPLE];

                for (int digitsX = 1; digitsX <= MULTIPLE; ++digitsX)
                {
                    row[digitsX - 1] = string.Format("{0,4}", digitsY * digitsX);
                }

                table[digitsY - 1] = string.Join("", row);
            }

            // Output the multiplication table
            WriteLine(string.Join(Environment.NewLine, table));
        }
    }
}
