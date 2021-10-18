using System;
using System.Collections.Generic;
using System.Text;

namespace CShardMastersAssignment2
{
    public class Helper
    {



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
