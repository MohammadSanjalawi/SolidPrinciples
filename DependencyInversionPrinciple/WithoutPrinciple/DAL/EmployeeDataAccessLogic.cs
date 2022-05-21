using DependencyInversionPrinciple.DOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.WithoutPrinciple.DAL
{
    public class EmployeeDataAccessLogic
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
