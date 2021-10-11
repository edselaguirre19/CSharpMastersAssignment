
using System;
using System.Threading.Tasks;

namespace CSharpMastersAssignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations();
            var inputs = new Tuple<double, double, string, double>(10, 5, "75%", 0.75);
            
            Console.WriteLine($"Implementing of Getting Average of {inputs.Item1} and {inputs.Item2} is: {mathOperations.GetAverage(inputs.Item1, inputs.Item2)}");

            Console.WriteLine($"Implementing of Percentage To Decimal Number {inputs.Item3} is: {mathOperations.PercentageToDecimal(inputs.Item3)}");

            Console.WriteLine($"Implementing of Decimal Number to Percentage of {inputs.Item4} is: {mathOperations.DecimalToPercentage(inputs.Item4)}");

            Console.WriteLine($"Implementing of Getting Average of {inputs.Item1} and {inputs.Item2} is: {mathOperations.GetAverage(inputs.Item1, inputs.Item2)}");

        }
    }
}
