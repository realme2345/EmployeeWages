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
            EmployeeWage.DisplayEmployeeWage("Dmart", 16, 20, 80); //static method 
            EmployeeWage.DisplayEmployeeWage("relieance", 18, 20, 100);
        }
    }
}
