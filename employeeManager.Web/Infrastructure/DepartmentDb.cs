using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using employeeManager.Domain;

namespace employeeManager.Web.Infrastructure
{

    public class DepartmentDB : DbContext, IDepartmentDataSource
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        void IDepartmentDataSource.Save()
        {
            SaveChanges();
        }

        IQueryable<Employee> IDepartmentDataSource.Employees
        {
            get
            {
                return Employees;
            }
        }

        IQueryable<Department> IDepartmentDataSource.Departments
        {
            get
            {
                return Departments;
            }
        }
    }

}