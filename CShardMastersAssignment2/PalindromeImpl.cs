using System;
using System.Collections.Generic;

namespace CShardMastersAssignment2
{
    public class PalindromeImpl
    {
        private Helper _helper;

        /// <summary>Initializes a new instance of the <see cref="PalindromeImpl" /> class.</summary>
        /// <param name="helper">The helper.</param>
        public PalindromeImpl(Helper helper)
        {
            _helper = helper;
        }

        /// <summary>Determines the specified inputs.</summary>
        /// <param name="inputs">The inputs.</param>
        /// <returns>
        /// </returns>
        public string Determine(Dictionary<int, string> inputs)
        {
            List<Tuple<int, string, string>> results = new List<Tuple<int, string, string>>();
            foreach (var item in inputs)
            {
                var validationResult = _helper.Validate(item.Value);
                if (!validationResult.Item1)
                {
                    results.Add(new Tuple<int, string, string>(item.Key, "", "Invalid Input"));
                    continue;
                }
                results.Add(new Tuple<int, string, string>(item.Key, item.Value, Check(item.Value)));
            }

            return ResultBuilder(results);
        }

        /// <summary>Results the builder.</summary>
        /// <param name="results">The results.</param>
        /// <returns>
        /// </returns>
        private string ResultBuilder(List<Tuple<int, string, string>> results)
        {
            string message = "Here are the result:\n";
            foreach (var item in results)
            {
                if (item.Item3 == "Invalid Input")
                    message += $"{item.Item1}. {item.Item3}\n";
                else
                    message += $"{item.Item1}. {item.Item2} {item.Item3} \n";
            }
            return message;
        }

        /// <summary>Checks the specified input.</summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// </returns>
        private string Check(string input)
        {
            int initial = 0;
            int inputLength = input.Length - 1;

            while (inputLength > initial)
            {
                if (input[initial] != input[inputLength])
                {
                    return "is not a Palindrome!";
                }
                initial++;
                inputLength--;
            }

            return "is a Palindrome!";
        }
    }
}