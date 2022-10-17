﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProb
{
    internal class UC5
    {
        //CONSTANTS
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NM_OF_WORKING_DAYS = 20;

        public static void MonthlyEmpSal()
        {
            int empHrs = 0, empWage = 0, TotalempWage = 0;
            for(int day=0;day<NM_OF_WORKING_DAYS;day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                empWage= empHrs*EMP_RATE_PER_HOUR;
                TotalempWage += empWage;
                Console.Write("employee wage: " + empWage);
            }
            Console.WriteLine("Total Employee wage for one month: " +TotalempWage);
        }
    }
}
