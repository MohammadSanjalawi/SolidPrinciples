using DependencyInversionPrinciple.WithoutPrinciple.DAL;
using DependencyInversionPrinciple.WithPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.WithoutPrinciple.Factory
{
    public static class DataAccessFatory
    {
        public static IEmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccessLogic();
        }
    }
}
