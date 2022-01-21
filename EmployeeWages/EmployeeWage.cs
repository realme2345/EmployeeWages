using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class EmployeeWage
    {
        /// <summary>
        /// Employee Wage
        /// </summary>
        public static void DisplayEmployeeWage() //creating method for a class
        {
            
                int isFullTime = 1;
                int empHrs = 0;
                int empRatePerHr = 20;
                int employeeWage = 0;
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                if (empCheck == isFullTime)
                {
                    empHrs = 8;
                    Console.WriteLine("Employee is present");

                }
                else
                {
                    Console.WriteLine("Employee is absent");
                }
                employeeWage = empHrs * empRatePerHr; //Gett the total employee wage
                Console.WriteLine("Employee Wage:" + employeeWage);
            
        }
    }
}
