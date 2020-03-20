using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asp.Net_MvcCrud.Models;

namespace Asp.Net_MvcCrud.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetData()
        {
            using (DBModel db = new DBModel()) {
                List<Employee> emplist = db.Employees.ToList<Employee>();
                return Json(new { data = emplist }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult AddorEdit(int id = 0)
        {
            return View(new Employee());
           
        }
        [HttpPost]
        public ActionResult AddorEdit(Employee emp)
        {
            using (DBModel db = new DBModel())
            {
                db.Employees.Add(emp);
                db.SaveChanges();
                return Json(new
                {
                    success = true,
                    message = "Saved Successfuly"
                }, JsonRequestBehavior.AllowGet);
            }


        }
    } }