using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystemDesignPatterns.Models.EmployeeModels
{
    public interface IEmployeeManager
    {
        double getPay();
        double getBonus();
        //double houseAllowance();
        //double medicalAllowance();
    }
}
