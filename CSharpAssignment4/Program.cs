using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 10;
            List<string> inputNameList = new List<string>();

            Console.WriteLine("Input 10 Employee Name:");
            while ((limit) > 0)
            {
                var name = Console.ReadLine();
                if (!Helper.ValidateName(name))
                {
                    Console.WriteLine("Please enter valid name:");
                    continue;
                }
                inputNameList.Add(name);
                limit--;
            }

            Console.WriteLine("Add total sales:");
            var sales = Convert.ToDecimal(Console.ReadLine());
            Process(inputNameList, sales);
        }

        public static void Process(List<string> names, decimal sales)
        {
            List<Employee> employees = new List<Employee>();

            //set up employee details
            //by adding random numbers for their infos

            foreach (var name in names)
            {
                Random random = new Random();
                Employee employee = new Employee();
                Processor<Employee> processor = new Processor<Employee>();
                employee.Name = name;
                employee.DailyRate = random.Next(500, 1000);
                employee.CommissionRateInPercent = random.Next(1, 5);
                employee.DaysWorked = random.Next(25,30); // random from 25 to 30 incase of absent
                employee.Salary = processor.ProcessSalary(employee);
                employee.Commission = processor.ProcessCommission(employee, sales);
                employees.Add(employee);
            }
            Console.Clear();
            Console.WriteLine("List of Employess with highest earnings for this month to lowest.");
            Console.WriteLine(MessageBuilder(employees));
        }

        private static string MessageBuilder(List<Employee> employees)
        {
            var sortedEmployee = employees.OrderByDescending(_ => _.Salary + _.Commission);
            var result = "";
            int count = 0;
            foreach (var item in sortedEmployee)
            {
                result += $"{count + 1}. {item.Name} with monthly compensation of {item.Salary + item.Commission} \n";
                count++;
            }
            return result;
        }

    }
}
