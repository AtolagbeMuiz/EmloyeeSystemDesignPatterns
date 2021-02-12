using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystemDesignPatterns.Models.Abstract_Factory
{
    public class MAC : IBrand
    {
        public string GetBrand()
        {
            return Enumerations.Brand.APPLE.ToString();
        }
    }
}
