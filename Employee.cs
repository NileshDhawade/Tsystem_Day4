using System;
//3. Create a array of Employees and display the details using foreach (use array)

namespace Tsystem_Day4_Assignments
{
    public class Employee
    {
        int empId;
        string empName;
        double empSalary;

        public Employee()
        {
            empId = 0;
            empName = "";
            empSalary = 0.0;
        }
        public Employee(int empId,string empName,double empSalary)
        {
            this.empId = empId;
            this.empName = empName;
            this.empSalary = empSalary;

        }
        public override string ToString()
        {
            return "employee id is " + empId + "\nemployee name " + empName + "\nemployee salary " + empSalary;
        }
    }
}
