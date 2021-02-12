using EmployeeSystemDesignPatterns.Models.Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystemDesignPatterns.Models
{
    public class DELL : IBrand
    {
        public string GetBrand()
        {
            return Enumerations.Brand.DELL.ToString();
        }
    }
}
