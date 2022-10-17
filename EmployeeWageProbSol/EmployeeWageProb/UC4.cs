using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProb
{
    internal class UC4
    {
        //CONSTANTS
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public static void EmpsalarySwitch()
        {
            //variables
            int empHrs = 0;
            int empWage = 0;
            //computation
            Random random = new Random();
            int empChech = random.Next(0, 2);
            switch(empChech)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;

            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("employee salary is " + empWage);

        }
    }
}
