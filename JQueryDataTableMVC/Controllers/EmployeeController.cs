using JQueryDataTableMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQueryDataTableMVC.Controllers
{
    public class EmployeeController : Controller
    {
        JQueryDataTableDBContext db = new JQueryDataTableDBContext();

        public ActionResult Index()
        {
            return View();
        }

        //Employee/getEmployees
        [HttpGet]
        public JsonResult getEmployees()
        {
            var jsonData = new
            {
                data = from emp in db.Employees.ToList() select emp
            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);

        } 
	}
}