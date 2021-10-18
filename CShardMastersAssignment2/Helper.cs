using System;

namespace CShardMastersAssignment2
{
    public class Helper
    {
        /// <summary>Validates the specified input.</summary>
        /// <param name="input">The input.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public Tuple<bool, string> Validate(string input)
        {
            input = input.Trim();
            var result = new Tuple<bool, string>(true, "");
            if (String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input))
                result = new Tuple<bool, string>(false, "Invalid input");
            return result;
        }
    }
}