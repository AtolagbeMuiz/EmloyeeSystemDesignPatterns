using EmployeeSystemDesignPatterns.Models.EmployeeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystemDesignPatterns.Models.Factory_Method
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;
        public BaseEmployeeFactory(Employee emp)
        {
            this._emp = emp;
        }

        public Employee ComputeAllowances()
        {
            IEmployeeManager manager = this.Create();
            _emp.Bonus = manager.getBonus();
            _emp.HourlyPay = manager.getPay();
            return _emp;
        }
        public abstract IEmployeeManager Create();
    }
}
