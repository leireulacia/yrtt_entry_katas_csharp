using System;
using System.Collections.Generic;
using System.Linq; // To use the query

// In this Kata, you will be given an array of numbers in which two numbers occur once and the rest occur only twice. 
// Your task will be to return the sum of the numbers that occur only once.
// For example, repeats([4,5,7,5,4,8]) = 15 because only the numbers 7 and 8 occur once, and their sum is 15.
// More examples in the test cases below.

// Good luck!

namespace TechReturners.Tasks
{
    public class Exercise001
    {
        public static int Singles(List<int> source)
        {
            // throw new NotImplementedException();
            int sum = 0;

            // Query that groups by the identifier, and then filter for groups that have only one member      
            var noDuplicates = source
                              .GroupBy(i => i)
                              .Where(g => g.Count() == 1) // There are only 1 element in the list
                              .Select(g => g.Key);

            foreach (int num in noDuplicates)
            {
                sum += num;
            }

            return (sum);
        }
    }
}