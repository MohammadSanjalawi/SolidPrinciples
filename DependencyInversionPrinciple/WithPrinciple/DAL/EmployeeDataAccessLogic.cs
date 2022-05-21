using DependencyInversionPrinciple.DOL;
using DependencyInversionPrinciple.WithPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.WithoutPrinciple.DAL
{
    public class EmployeeDataAccessLogic : IEmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            Employee employee = new Employee()
            {
                ID = id,
                Name = "Mohammad",
                Department = "IT",
                Salary = 500
            };


            return employee;
        }
    }
}
