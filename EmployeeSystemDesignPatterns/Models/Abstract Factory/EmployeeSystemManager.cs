using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystemDesignPatterns.Models.Abstract_Factory
{
    public class EmployeeSystemManager
    {
        IComputerFactory _IcomputerFactory;
        public EmployeeSystemManager(IComputerFactory computerFactory)
        {
            this._IcomputerFactory = computerFactory;
        }

        public string getSystemDetails()
        {
            IBrand brand = _IcomputerFactory.Brand();
            IProcessor processor = _IcomputerFactory.Processor();
            ISystemType systemType = _IcomputerFactory.SystemType();

            string returnValue = string.Format("{0} {1} {2}", 
                brand.GetBrand(), processor.GetProcessor(), systemType.GetSystemType());

            return returnValue;
        }
    }
}
