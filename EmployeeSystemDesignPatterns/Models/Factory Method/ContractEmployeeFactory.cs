using EmployeeSystemDesignPatterns.Models.EmployeeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystemDesignPatterns.Models.Factory_Method
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {
                
        }

        public override IEmployeeManager Create()
        {

            ContractEmployeeManager contractEmployeeManager = new ContractEmployeeManager();
            _emp.MedicalAllowance = contractEmployeeManager.getMedicalAllowance();
            return contractEmployeeManager;
        }
    }
}
