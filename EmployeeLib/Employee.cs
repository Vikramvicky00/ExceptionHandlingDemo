using System;


namespace EmployeeLib
{
    public class Employee
    {
        private int empNo;
        private string empName;
        private double salary;
        private int deptNo;

        public int EmpNo
        {
            get { return empNo; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("Employee NO can't be zero.");
                }
                empNo = value;
            }
        }

        public string EmpName
        {
            get { return empName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can't be Empty.");
                }
                empName = value;
            }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("Department NO can't be zero.");
                }
                deptNo = value;
            }
        }
    }

}
