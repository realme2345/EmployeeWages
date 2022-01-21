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
            const int Is_Full_Time = 1; //cretaing a constants value by using the const key word
            const int Is_Part_Time = 2;
            int empHrs = 0;
            const int Emp_Rate_Per_Hr = 20;
            const int Total_Working_Days = 20;
            int totalEmployeeWage = 0;
            int employeeWage = 0;
            Random random = new Random(); // creating a object for a random value
            for (int day = 1; day <= Total_Working_Days; day++)
            {
                int empCheck = random.Next(0, 3); // to get the values randomly between 0 to 2
                switch (empCheck)
                {
                    case Is_Full_Time: //If random value 1 then it will execute the block statemnt
                        empHrs = 8;
                        Console.WriteLine("{0} day Employee is working full time", day);
                        break;
                    case Is_Part_Time: // if random value 2 then it will execute the block statemet
                        empHrs = 4;
                        Console.WriteLine("{0} day Employee is working part time", day);

                        break;
                    default: // if random value is 0 then it will execute the block of statement
                        empHrs = 0;
                        Console.WriteLine("{0} day Employee is absent", day);

                        break;
                }// claculation part for a employee wage
                employeeWage = empHrs * Emp_Rate_Per_Hr;
                Console.WriteLine("Employee Wage :" + employeeWage);
                //totalEmployeeWage=totlaEmployeeWage+employeeWage
                totalEmployeeWage += employeeWage;
            }
            Console.WriteLine("Total employee wage per 20 days:" + totalEmployeeWage);  // here we get the total employee wage
        }     
    }
}
