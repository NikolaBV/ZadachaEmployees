using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaEmployees
{
    public abstract class BaseEmployees
    {
        private int employeeID;
        private string employeeName;
        private string employeeAddress;

        public int EmployeeID
        {
            get { return employeeID; }
        }
        public string EmployeeName
        {
            get { return employeeName; }
        }
        public string EmployeeAddress
        {
            get { return employeeAddress; }
        }

        public BaseEmployees(int employeeID, string employeeName, string employeeAddress)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.employeeAddress = employeeAddress;
        }
        public abstract void Show();
        public abstract void CalculateSalary(int hoursWorked);
        public abstract void GetDepartment(string departmentName);

    }
}
