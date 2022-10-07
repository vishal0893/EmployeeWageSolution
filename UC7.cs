using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProb
{
    internal class UC7
    {
        //CONSTANTS
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        //variables
        public static int empHrs = 0, TotalempHrs = 0, TotalWorkingDays = 0;
        public static int Workinghrs(int Rand)
        {
            int empHrs = 0;
            switch (Rand)
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
            return empHrs;
        }
        public static void Computesalary()
        {
            int Monthlysalary = 0;
            while (TotalWorkingDays < MAX_HRS_IN_MONTH && TotalWorkingDays<NM_OF_WORKING_DAYS)
            {
                TotalempHrs++;
                Random random = new Random();
                int rand = (random.Next() % 3) + 1;
                empHrs = Workinghrs(rand);
                TotalempHrs += empHrs;
            }
            Monthlysalary = TotalempHrs*EMP_RATE_PER_HOUR;
            Console.Write("Total salary of the employee in a month is " +Monthlysalary);    


        }
        static void Main(string[] args)
        {
            Computesalary();
        }
           
    }
}
