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
            const int Is_Full_Time = 1; //fields here to assign constant values by using keyword const
            const int Is_Part_Time = 2;
            int empHrs = 0;
            const int Emp_Rate_Per_Hr = 20;
            const int Total_Working_Days = 20;
            const int Working_Hours = 100;
            int totalEmployeeWage = 0;
            int employeeWage = 0;
            int empWorkingHours = 0;
            Random random = new Random(); //Creating a object for random value
            int day = 1;
            while (day <= Total_Working_Days && empWorkingHours <= Working_Hours)
            {
                int empCheck = random.Next(0, 3);// To get the values from 0 to 2
                switch (empCheck)
                {
                    case Is_Full_Time: // If random value is 1 it will execute block of statement
                        empHrs = 8;
                        Console.WriteLine("{0} day Employee is working full time", day);
                        break;
                    case Is_Part_Time: // If random value is 2 it will execute block of statement
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
                Console.WriteLine("Employee Wage :" + employeeWage);
                totalEmployeeWage += employeeWage; //totalEmployeeWage=totlaEmployeeWage+employeeWage
                empWorkingHours += empHrs;         //empWorkingHours=empWorkingHours+empHrs
                day++;
            }
            Console.WriteLine("Total employee wage per {0} days {1} Hrs: {2}", Total_Working_Days, empWorkingHours, totalEmployeeWage);//To get the total wage
        }     
    }
}
