using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystemDesignPatterns.Models.EmployeeModels
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public double getBonus()
        {
            return 5;
        }

        public double getPay()
        {
            return 8;
        }
    }
}
