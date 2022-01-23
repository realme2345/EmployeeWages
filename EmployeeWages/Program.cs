using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage empWageBuilder= new EmployeeWage(); //creating Object for a class
            empWageBuilder.AddCompanyEmpWage("Dmart", 20, 20, 90);
            empWageBuilder.AddCompanyEmpWage("TATA", 20, 23, 100);
            empWageBuilder.AddCompanyEmpWage("Wipro", 22, 22, 100);
            empWageBuilder.computeEmpWage();
            Console.ReadLine();
        }
    }
}
