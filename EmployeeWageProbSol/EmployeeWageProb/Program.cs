using EmployeeWageProb;
using System;
namespace EmpwageProblem;
class Employee
{
    static void Main()
    {
        Console.WriteLine("welcome to employee wage problem");
        // UC1.Empattendance();
        // UC2.Empsalary();
        // UC3.Empsalary();
        // UC4.EmpsalarySwitch();
        // UC5.MonthlyEmpSal();
        //UC6.MonthlySalary();
        //UC7.Computesalary();
        UC8 OBJ = new UC8();
        OBJ.computeEmpWage1("Dmart", 10, 25, 80);
        OBJ.computeEmpWage1("Alphabet", 50, 20, 100);
    }
}

