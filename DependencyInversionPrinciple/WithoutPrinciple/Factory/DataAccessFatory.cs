using DependencyInversionPrinciple.WithoutPrinciple.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.WithoutPrinciple.Factory
{
    public static class DataAccessFatory
    {
        public static EmployeeDataAccessLogic GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccessLogic();
        }
    }
}
