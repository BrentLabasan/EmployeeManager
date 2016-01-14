using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using employeeManager.Web.Models;
using employeeManager.Domain;

namespace employeeManager.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IDepartmentDataSource _db;

        public EmployeeController(IDepartmentDataSource db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult Create(int departmentId)
        {
            var model = new CreateEmployeeViewModel();
            model.DepartmentId = departmentId;

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(CreateEmployeeViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                // b4 you can save Employee to DB, you need access to DB. Hence use IDepartmentDataSource _db 2.2 11:40
                var department = _db.Departments.Single(d => d.Id == viewModel.DepartmentId);
                var employee = new Employee();
                employee.Name = viewModel.Name;
                employee.HireDate = viewModel.HireDate;
                department.Employees.Add(employee);

                _db.Save();

                return RedirectToAction("details","department", new { id = viewModel.DepartmentId });
            }
            return View(viewModel);
        }


    }
}