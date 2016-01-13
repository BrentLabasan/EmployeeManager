using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using employeeManager.Domain;

namespace employeeManager.Web.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        /*
        public ActionResult Index()
        {
            return View();
        }
        */

        private IDepartmentDataSource _db;

        public DepartmentController(IDepartmentDataSource db)
        {
            _db = db;
        }

        public ActionResult Details(int id)
        {
            var model = _db.Departments.Single(d => d.Id == id);
            return View(model);
        }
    }

    
}