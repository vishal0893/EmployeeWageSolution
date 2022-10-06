using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProb
{
    internal class UC3
    {

        public static void Empsalary()
        {
            //constants
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            //computation
            Random random = new Random();
            int empChech = random.Next(0, 2);
            if (empChech == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else if(empChech == IS_PART_TIME)
            {
                empHrs = 4;

            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("employee salary is " + empWage);

        }
    }
}
