using System;
using System.Linq;

namespace FunctionalInCSharp
{
    public static class InputParser
    {
        public static Tuple<char, decimal, decimal> ParseInput(this string input)
        {
            //currently expecting valid input a+b,a-b,a/b,a*b
            return Tuple.Create(input.ElementAt(1),
                                decimal.Parse(input.First().ToString()),
                                decimal.Parse(input.Last().ToString()));
        }
    }
}
