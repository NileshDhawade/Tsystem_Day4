using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
