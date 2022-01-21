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
            EmployeeWage Dmart = new EmployeeWage("Dmart", 26, 27, 100);
            EmployeeWage TATA = new EmployeeWage("TATA", 22, 25, 70);
            Dmart.DisplayEmployeeWage();
            Console.WriteLine(Dmart.toString());
            TATA.DisplayEmployeeWage();
            Console.WriteLine(TATA.toString());
        }
    }
}
