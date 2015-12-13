using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using employeeManager.Domain;

namespace employeeManager.Web.Infrastructure
{

    public class DepartmentDB : DbContext, IDepartmentDataSoure
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        IQueryable<Employee> IDepartmentDataSoure.Employees
        {
            get
            {
                return Employees;
            }
        }

        IQueryable<Department> IDepartmentDataSoure.Departments
        {
            get
            {
                return Departments;
            }
        }
    }

}