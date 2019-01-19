using System;
using System.Collections.Generic;
using System.Text;

namespace EasyProblems
{
    public class EnormousInputAndOutput
    {
        /*
         * The purpose of this problem is to verify whether the method you are using to read input data is sufficiently fast to handle problems branded with the enormous Input/Output warning. You are expected to be able to process at least 2.5MB of input data per second at runtime.
           
           Input
           The input begins with two positive integers n k (n, k<=107). The next n lines of input contain one positive integer ti, not greater than 109, each.
           
           Output
           Write a single integer to output, denoting how many integers ti are divisible by k.
           
           Example
           Input:
           7 3
           1
           51
           966369
           7
           9
           999996
           11
           
           Output:
           4
         */

        public static void ProcessEnormousInput()
        {
            var lines = ReadInputLine();
            var n = Convert.ToInt32(lines[0]);
            var k = Convert.ToInt32(lines[1]);
            var count = 0;
            for (var i = 0; i < n; i++)
            {
                var ti = Convert.ToInt32(Console.ReadLine());
                if (ti % k == 0) count++;
            }
            Console.WriteLine(count);
        }

        private static string[] ReadInputLine()
        {
            var input = Console.ReadLine();
            while (string.IsNullOrEmpty(input))
            {
                input = Console.ReadLine();
            }
            var line = input.Split(' ');
            return line;
        }
    }
}
