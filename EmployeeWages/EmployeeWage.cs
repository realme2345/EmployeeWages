using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages  
{
    public class EmployeeWage: IComputeEmployeeWages  //List of multiple companies to manage employee Wages
    {
        /// <summary>
        /// Ability to store the daily wage along with total employee wage
        /// </summary            
        public const int Is_Full_Time = 2; //fields here to assign constant values by using keyword const
        public const int Is_Part_Time = 1;
        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;
        public EmployeeWage()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap=new Dictionary<string, CompanyEmpWage>();
        }
        public  void AddCompanyEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int maxHoursPermonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company,empRatePerHr, numOfWorkingDays, maxHoursPermonth);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
        }
        public void computeEmpWage()
        {
           foreach(CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmployeeWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            {
                int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 1, DailyWage = 0;
                while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Day {0} is {1} hrs", totalWorkingDays, empHrs);
                    totalWorkingDays++;
                    DailyWage = empHrs * companyEmpWage.empRatePerHr;
                    int[] total = { DailyWage };          // Creting an arry for to store the Daily employee wage
                    Console.WriteLine("Daily Wage of Employee: {0}", total[0]);
                }
                return totalEmpHrs * companyEmpWage.empRatePerHr;
            }
        }
        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmployeeWage;
        }   
    }   
    
}
