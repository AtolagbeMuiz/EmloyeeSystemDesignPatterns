using EmployeeSystemDesignPatterns.Models.EmployeeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystemDesignPatterns.Models.Simple_Factory
{
    public class EmployeeManagerFactory 
    {
        //private readonly Employee _emp;
        //public EmployeeManagerFactory(Employee emp)
        //{
        //    this._emp = emp;
        //}

        public IEmployeeManager createFactory(int empID)
        {
            IEmployeeManager returnValue=null;
            if (empID == 1)
            {
                return new PermanentEmployeeManager();
            }
            else if (empID == 2)
            {
                return new ContractEmployeeManager();
            }

            return returnValue;
        }
    }
}
