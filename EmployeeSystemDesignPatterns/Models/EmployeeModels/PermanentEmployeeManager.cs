using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystemDesignPatterns.Models.EmployeeModels
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public double getBonus()
        {
            return 10;
        }

        public double getPay()
        {
            return 8;
        }

        public double getHouseAllowance()
        {
            return 100;
        }


    }
}
