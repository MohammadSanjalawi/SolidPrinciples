﻿using DependencyInversionPrinciple.DOL;
using DependencyInversionPrinciple.WithoutPrinciple.DAL;
using DependencyInversionPrinciple.WithoutPrinciple.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.WithoutPrinciple.BAL
{
    public class EmployeeBusinessLogic
    {
        EmployeeDataAccessLogic _employeeDataAccessLogic;

        public EmployeeBusinessLogic()
        {
            _employeeDataAccessLogic = DataAccessFatory.GetEmployeeDataAccessObj();
        }

        public Employee getEmployeeDetails(int id)
        {
            return _employeeDataAccessLogic.GetEmployeeDetails(id);
        }
    }
}
