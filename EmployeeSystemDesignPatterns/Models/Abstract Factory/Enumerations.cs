using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystemDesignPatterns.Models.Abstract_Factory
{
    public class Enumerations
    {
        public enum Brand 
        { 
            APPLE,
            DELL
        }

        public enum ComputerTypes
        {
            LAPTOP,
            DESKTOP
        }

        public enum Processors
        {
            i3,
            i5,
            i7
        }
    }
}
