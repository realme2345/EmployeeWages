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
        
            const int IS_FULL_TIME = 1; //fields here to assign constant values by using keyword const
            const int IS_PART_TIME = 2;
            const int Emp_Rate_Per_Hr = 20;
            const int Total_Working_Days = 20;
            const int Working_Hours = 100;
            public static void DisplayEmployeeWage() //creating method for a class
            {
                int empHrs = 0, totalEmployeeWage = 0, employeeWage = 0, empWorkingHours = 0;
                int day = 1;
                while (day <= Total_Working_Days && empWorkingHours <= Working_Hours)
                {
                    Random random = new Random(); //Creating a object for random value
                    int empCheck = random.Next(0, 3);// To get the values from 0 to 2
                    switch (empCheck)
                    {
                        case IS_FULL_TIME: // If random value is 1 it will execute block of statement
                            empHrs = 8;
                            Console.WriteLine("{0} day Employee is working full time", day);
                            break;
                        case IS_PART_TIME: // If random value is 2 it will execute block of statement
                            empHrs = 4;
                            Console.WriteLine("{0} day Employee is working part time", day);
                            break;
                        default:
                            empHrs = 0; // If random value is 0 then it will execotr
                            Console.WriteLine("{0} day Employee is absent", day);
                            break;
                    }
                    // Employee wage calculation part
                    employeeWage = empHrs * Emp_Rate_Per_Hr;
                    // Console.WriteLine("Employee Wage :" + employeeWage);
                    totalEmployeeWage += employeeWage; //totalEmployeeWage=totlaEmployeeWage+employeeWage
                    empWorkingHours += empHrs;         //empWorkingHours=empWorkingHours+empHrs
                    day++;
                }
                Console.WriteLine("The Total employee wage per {1} days {2} Hrs: {3}", Total_Working_Days, empWorkingHours, totalEmployeeWage);//To get the total wage


            }
    }
}
