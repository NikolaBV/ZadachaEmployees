using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaEmployees
{
    public class ContractEmployee : BaseEmployees
    {
        private string employeeTask;
        private string employeeDepartment;

        public ContractEmployee(int employeeID, string employeeName, string employeeAddress, string employeeTask, string employeeDepartmen) : base(employeeID, employeeName, employeeAddress)
        {

        }

        public override void CalculateSalary(int hoursWorked)
        {
            Console.WriteLine($"The salary is {(hoursWorked * 20) + 250}");
        }

        public override void GetDepartment(string departmentName)
        {
            Console.WriteLine(employeeDepartment);
        }

        public override void Show()
        {
            Console.WriteLine($"The employee task is {employeeTask}");
        }
    }
}
