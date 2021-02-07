using EmployeeSystemDesignPatterns.Models.EmployeeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystemDesignPatterns.Models.Factory_Method
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {

        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {

        }

        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager permanentEmployeeManager = new PermanentEmployeeManager();
            _emp.HouseAllowance = permanentEmployeeManager.getHouseAllowance();
            return permanentEmployeeManager; 
        }
    }
}
