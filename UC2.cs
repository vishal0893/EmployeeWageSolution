using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProb
{
    internal class UC2
    {
        public static void Empsalary()
        {
            //constants
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            //computation
            Random random = new Random();
            int empChech = random.Next(0, 2);
            if(empChech == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;

            }
            empWage=empHrs*EMP_RATE_PER_HOUR;
            Console.WriteLine("employee salary is "+empWage);

        }
    }
}
