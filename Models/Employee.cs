using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMVCApp.Models
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeAdress { get; set; }
        public int EmployeeSalary { get; set; }

        public override string ToString()
        {
            return $"<p>The name :{EmployeeName} <p> The Employee adress:{ EmployeeAdress} <p><p> The Employee Salary:{EmployeeSalary}";
        }

    }
}