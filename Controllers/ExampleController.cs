using SampleMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVCApp.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        public ViewResult AllEmployess()
        {
            var context = new LttsTrainingEntities();
            var model = context.EmpTables.ToArray();
            return View(model);
        }
    }
}