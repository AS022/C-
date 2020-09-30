using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    class Employee
    {
        int id;
        string name, address;
        long phoneNo;

        public int EmployeeID
        {
            get { return id; }
            set { id = value; }
        }

        public string EmpName
        {
            get { return name; }
            set { name = value; }
        }

        public string EmpAddress
        {
            get { return address; }
            set { address = value; }
        }

        public long EmpPhone
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }

    }
    class Ex05
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmployeeID = 123;
            emp.EmpName = "Amrita";
            emp.EmpAddress = "Mysore";
            emp.EmpPhone = 234234234;
            Console.WriteLine($"The name of the Employee is {emp.EmpName} from {emp.EmpAddress} who can be contacted on {emp.EmpPhone}");
            //New Syntax for text formatting in C# 6.0..
        }
    }
}
       
