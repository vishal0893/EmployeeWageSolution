using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProb
{
    internal class UC8
    {
        //Constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public void computeEmpWage1(String companyName, int empRatePerHour, int numOfWorkingDays, int maxHrsPerMonth)
        {
            int totalEmpHrs = 0, totalWorkingDays = 0;
            while(totalEmpHrs<maxHrsPerMonth && totalWorkingDays<numOfWorkingDays)
            {
                int empHrs = 0;
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
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
                totalEmpHrs += empHrs;
                //Console.Write("Total employee hours is " + totalEmpHrs);
            }
            int totalEmpwage = totalEmpHrs * empRatePerHour;
            Console.Write("Total employee wage of" + companyName + "is" + totalEmpwage +"\n");
        }

    }
}
