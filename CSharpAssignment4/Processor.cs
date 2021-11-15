using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssignment4
{
    public class Processor<T> where T : Employee
    {

        public decimal ProcessSalary(T employee) => employee.DailyRate* employee.DaysWorked;       

        public decimal ProcessCommission(T employee, decimal sales) => sales * ((decimal)employee.CommissionRateInPercent / 100);       

    }
}
