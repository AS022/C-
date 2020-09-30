using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleMVCApp.Models;

namespace SampleMVCApp.Controllers
{
    public class FirstDemoController : Controller
    {
        public string Greeting()
        {
            return "<h1>Hello MVC App</h1>";
        }

        public Employee ShowMe()
        {
            return new Employee
            {
                EmployeeName = "Amrita",
                EmployeeAdress = "Mysore",
                EmployeeSalary = 10000

            };
        }
            public ViewResult ShowHtml()
            {
                var emp = new Employee
                { 
                          EmployeeName = "Amrita",
                          EmployeeAdress = "Mysore",
                          EmployeeSalary = 10000

                      };
            return View(emp);
        }

            }
        }
        
    
   

