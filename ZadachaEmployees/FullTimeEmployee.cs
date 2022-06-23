using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaEmployees
{
    public class FullTimeEmployee : BaseEmployees
    {
        private string employeePosition;
        private string employeeDeparment;

        public FullTimeEmployee(int employeeID, string employeeName, string employeeAddress, string employeePosition, string employeeDepartment) : base(employeeID, employeeName, employeeAddress)
        {

        }

        public override void Show()
        {
            Console.WriteLine($"{employeePosition}, {employeeDeparment}");
        }

        public override void CalculateSalary(int hoursWorked)
        {
            Console.WriteLine($"The salary is {(hoursWorked * 10.80) + 250}");
        }
        public override void GetDepartment(string departmentName)
        {
            Console.WriteLine($"The department is {employeeDeparment}");
        }
    }
}
