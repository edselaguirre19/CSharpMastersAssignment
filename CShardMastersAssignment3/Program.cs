using System;

namespace CShardMastersAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee/Contractual payout list info:");
            double payOut = 0;

            #region Consultant
            var consultant = new Consultant();
            consultant.BasePay = 1500;


            #region Contractual
            payOut = consultant.Payout(true);
            Console.WriteLine($"For contractual consultants with {consultant.BasePay} base pay has {payOut} net payout");
            #endregion

            #region Regular Employee
            payOut = consultant.Payout(false);
            Console.WriteLine($"For regular employee consultants with {consultant.BasePay} base pay has {payOut} net payout");
            #endregion

            #endregion

            #region Developer
            var developer = new Developer();
            developer.BasePay = 1200;


            #region Contractual
            payOut = developer.Payout(true);
            Console.WriteLine($"For contractual developer with {developer.BasePay} base pay has {payOut} net payout");
            #endregion

            #region Regular Employee
            payOut = developer.Payout(false);
            Console.WriteLine($"For regular employee developer with {developer.BasePay} base pay has {payOut} net payout");
            #endregion

            #endregion

            #region Quality Engineer
            var qE = new QualityEngineer();
            qE.BasePay = 1000;


            #region Contractual
            payOut = qE.Payout(true);
            Console.WriteLine($"For contractual quality engineer with {qE.BasePay} base pay has {payOut} net payout");
            #endregion

            #region Regular Employee
            payOut = qE.Payout(false);
            Console.WriteLine($"For regular employee quality engineer with {qE.BasePay} base pay has {payOut} net payout");
            #endregion

            #endregion
        }
    }
}
