using EmployeeSystemDesignPatterns.Models.EmployeeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystemDesignPatterns.Models.Abstract_Factory
{
    public class EmployeeSystemFactory 
    {
        public IComputerFactory Create(Employee emp)
        {
            IComputerFactory returnValue = null;
            if (emp.EmployeeTypeId == 1)
            {
                if (emp.JobDescription == "Manager")
                {
                    returnValue = new MacLaptopFactory();
                }
                else
                {
                    returnValue = new MacFactory();
                }
            }

            if(emp.EmployeeTypeId == 2)
            {
                if(emp.JobDescription == "Manager")
                {
                    returnValue = new DellLaptopFactory();
                }
                else
                {
                    returnValue = new DellFactory();
                }
            }
            return returnValue;
        }

    }
}
