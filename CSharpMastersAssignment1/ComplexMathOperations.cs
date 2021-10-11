using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMastersAssignment1
{
    public partial class MathOperations
    {


        public double GetAverage(double i1, double i2)
        {
            var addResult = Addition(i1, i2);
            return Division(addResult, 2);
        }

        public double PercentageToDecimal(string i1)
        {
            i1 = i1.Replace("%", "");
            var d = Convert.ToDouble(i1);
            return Division(d, 100);
        }

        public string DecimalToPercentage(double i1)
        {
            return Multiplication(i1, 100).ToString();
        }

        public string GetLargerInput(double i1, double i2)
        {
            var result = Subtraction(i1, i2);
            return (result > 0 ? $"input1 ({i1}) is greated than input2 ({i2})" : $"input2 ({i2}) is greated than input1 ({i1})");
        }


    }
}
