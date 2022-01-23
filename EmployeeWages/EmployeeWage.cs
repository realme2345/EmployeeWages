using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{/// <summary>
/// Employee Wage
/// </summary>
    class EmployeeWage
    {
        const int Is_Full_Time = 1; //fields here to assign constant values by using keyword const
        const int Is_Part_Time = 2;
        public static void DisplayEmployeeWage(string company, int empRatePerHr, int totalWorkingDays, int workingHours)
        {
            int empHrs = 0, totalEmployeeWage = 0, employeeWage = 0, empWorkingHours = 0;
            int day = 1;
            while (day <= totalWorkingDays && empWorkingHours <= workingHours)
            {
                Random random = new Random(); //Creating a object for random value
                int empCheck = random.Next(0, 3);// To get the values from 0 to 2
                switch (empCheck)
                {
                    case Is_Full_Time: // If random value is 1 it will execute block of statement
                        empHrs = 8;
                        // Console.WriteLine("{0} day Employee is working full time", day);
                        break;
                    case Is_Part_Time: // If random value is 2 it will execute block of statement
                        empHrs = 4;
                        // Console.WriteLine("{0} day Employee is working part time", day);
                        break;
                    default:
                        empHrs = 0; // If random value is 0 then it will execotr
                                    // Console.WriteLine("{0} day Employee is absent", day);
                        break;
                }
                // Employee wage calculation part
                employeeWage = empHrs * empRatePerHr;
                // Console.WriteLine("Employee Wage :" + employeeWage);
                totalEmployeeWage += employeeWage; //totalEmployeeWage=totlaEmployeeWage+employeeWage
                empWorkingHours += empHrs;         //empWorkingHours=empWorkingHours+empHrs
                day++;
            }
            Console.WriteLine("The Company {0} employee wage per {1} days {2} Hrs: {3}", company, totalWorkingDays, empWorkingHours, totalEmployeeWage);//To get the total wage
        }
    }
}
