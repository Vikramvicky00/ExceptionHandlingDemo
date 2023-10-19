using System;
using EmployeeLib;

namespace ExceptionHandling
{
    public class EmployeeExceptionDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Employee emp = new Employee();
                emp.EmpNo = 10;
                emp.EmpName = "";
                emp.Salary = 25000;
                emp.DeptNo = 0;

                Console.WriteLine($"Employee Number: {emp.EmpNo} \n Employee Name: {emp.EmpName} \n Salary: {emp.Salary} \n Department Number: {emp.DeptNo}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

        }
    }
}
