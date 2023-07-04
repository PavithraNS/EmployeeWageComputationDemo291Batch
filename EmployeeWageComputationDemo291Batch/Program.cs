using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationDemo291Batch
{
    class Program
    {
        static void Main(string[] args)
        {
            const int IS_PRESENT = 1;
            Console.WriteLine("Welcome to EmployeeWageComputation");
            //UC-1 finding employee attendence 
            Random random = new Random();
            int employeeInput=random.Next(0,2); //0 or 1
            Console.WriteLine("Random value:{0}", employeeInput);
            if (employeeInput==IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}
