using EmployeeSystemDesignPatterns.Models.EmployeeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystemDesignPatterns.Models.Factory_Method
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory createEmployeeTypeFactory(Employee employee)
        {
            BaseEmployeeFactory returnValue = null;
            if(employee.EmployeeTypeId == 1)
            {
                returnValue = new PermanentEmployeeFactory(employee);
            }
            else if(employee.EmployeeTypeId == 2)
            {
                returnValue = new ContractEmployeeFactory(employee);
            }
            return returnValue;
        }
    }
}
