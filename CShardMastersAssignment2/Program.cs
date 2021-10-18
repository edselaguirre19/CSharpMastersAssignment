using System;
using System.Collections.Generic;

namespace CShardMastersAssignment2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<int, string> inputs = new Dictionary<int, string>();
            Helper helper = new Helper();
            PalindromeImpl palindromeImpl = new PalindromeImpl(helper);
            int limit = 10;
            Console.WriteLine($"Input {limit} string for palindrome determination:");
            for (var i = 0; i < limit; i++)
            {
                var index = i + 1;
                if (i != limit)
                {
                    var currentInput = Console.ReadLine();
                    inputs.Add(index, currentInput);
                    Console.WriteLine($"{index}. {currentInput}");
                }
            }

            Console.Clear();
            Console.WriteLine(palindromeImpl.Determine(inputs));
        }
    }
}