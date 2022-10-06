using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProb
{
    internal class UC6
    {
        //CONSTANTS
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        public static void MonthlySalary()
        {
            int empHrs = 0, TotalempHrs = 0, TotalWorkingDays = 0;
            //Computation
            while(TotalempHrs<=MAX_HRS_IN_MONTH && TotalWorkingDays<=NM_OF_WORKING_DAYS)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                TotalempHrs += empHrs;
                Console.Write(" Days:" + TotalWorkingDays + " Emp hrs:" +empHrs);
                    

            }
            int TotalEmpWage = TotalempHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employeewage for one month: " + TotalEmpWage);
        }
    }
}
