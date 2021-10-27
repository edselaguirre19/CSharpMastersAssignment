using System;
using System.Collections.Generic;
using System.Text;

namespace CShardMastersAssignment3
{
    public abstract class Employee : Contractual
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        internal decimal Salary { get; set; }
        public Employee() { }
        ~Employee() { }
        public void Work() { }
        public double BasePay { get; set; }

        //sample payout config
        //assumption that regular employee has Taxes and Incentives
        //assumption that contractual has no Taxes and Incentives
        internal double Incentives = 1.2;
        internal double TaxesAndOthers = 0.8;

        public override double Payout(bool isContractual)
        {
            return base.Payout(BasePay) * TaxesAndOthers * Incentives;
        }
    }



    public class Consultant : Employee
    {
        public string ProjectName { get; set; }

        public new double BasePay { get; set; }

        public override double Payout(bool isContractual)
        {
            var grossPay = base.Payout(BasePay);

            return (isContractual ? grossPay : (grossPay * Incentives * TaxesAndOthers));

        }

    }
    public class QualityEngineer : Employee
    {
        public string TestingTool { get; set; }

        public new double BasePay { get; set; }

        public override double Payout(bool isContractual)
        {
            var grossPay = base.Payout(BasePay);

            return (isContractual ? grossPay : (grossPay * Incentives * TaxesAndOthers));
        }
    }
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public new double BasePay { get; set; }

        public override double Payout(bool isContractual)
        {
            var grossPay = base.Payout(BasePay);

            return (isContractual ? grossPay : (grossPay * Incentives * TaxesAndOthers));
        }
    }

}
