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
            int isPartTime = 2;
            int empHrs = 0;
            int empRatePerHr = 20;
            int employeeWage = 0;
            Random random = new Random();   // creating a object for a random value
            int empCheck = random.Next(0, 3);   // to get the values randomly between 0 to 2
            if (empCheck == isFullTime)   //If random value 1 then it will execute the block statemnt
            {
                empHrs = 8;
                Console.WriteLine("Employee is Working Full time");
                if (empCheck == isPartTime)   //If random value 2 then it will execute the block statemnt
                {
                    empHrs = 4;
                    Console.WriteLine("Employee is Working Part  time");

                }

            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            employeeWage = empHrs * empRatePerHr;
            Console.WriteLine("Employee Wage:" + employeeWage);
        }     
    }
}
