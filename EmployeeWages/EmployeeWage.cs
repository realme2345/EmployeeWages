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
        private string company;
        private int empRatePerHr;
        private int totalWorkingDays;
        private int workingHours;

        public EmployeeWage(string company, int empRatePerHr, int totalWorkingDays, int workingHours)
        {
            this.company = company; //Parametarised constructer to aasign user value
            this.empRatePerHr = empRatePerHr;
            this.totalWorkingDays = totalWorkingDays;
            this.workingHours = workingHours;
        }

        public void DisplayEmployeeWage()
        {
            int empHrs = 0, totalEmployeeWage = 0, employeeWage = 0, empWorkingHours = 0;
            int day = 1;
            while (day <= this.totalWorkingDays && empWorkingHours <= this.workingHours)
            {
                Random random = new Random(); //Creating a object for random value
                int empCheck = random.Next(0, 3);// To get the values from 0 to 2
                switch (empCheck)
                {
                    case Is_Full_Time:
                        // If random value is 1 it will execute block of statement
                        empHrs = 8;
                        break;
                    case Is_Part_Time: // If random value is 2 it will execute block of statement
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0; // If random value is 0 then it will execotr
                        break;
                }
                    // Employee wage calculation part
                employeeWage = empHrs * this.empRatePerHr;
                totalEmployeeWage += employeeWage; //totalEmployeeWage=totlaEmployeeWage+employeeWage
                empWorkingHours += empHrs;         //empWorkingHours=empWorkingHours+empHrs
                day++;
            }
            Console.WriteLine("The Company {0} employee wage per {1} days {2} Hrs: {3}", company, totalWorkingDays, empWorkingHours, totalEmployeeWage);//To get the total Wage
            
        }
        public string toString()
        {
            return "Total Emp Wage for company  : " + this.company;
        }
    }   
    
}
