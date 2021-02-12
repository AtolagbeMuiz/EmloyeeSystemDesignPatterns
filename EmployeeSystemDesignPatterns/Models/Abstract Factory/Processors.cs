using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystemDesignPatterns.Models.Abstract_Factory
{
    public class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return Enumerations.Processors.i7.ToString();
        }
    }

    public class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return Enumerations.Processors.i5.ToString();
        }
    }
}
