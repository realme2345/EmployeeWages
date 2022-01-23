using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{/// <summary>
/// Employee Wage
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage Dmart = new EmployeeWage("Dmart", 26, 27, 100);//creating object 
            EmployeeWage TATA = new EmployeeWage("TATA", 22, 25, 70);
            Dmart.DisplayEmployeeWage();
            Console.WriteLine(Dmart.toString());
            TATA.DisplayEmployeeWage();
            Console.WriteLine(TATA.toString());
        }
    }
}
