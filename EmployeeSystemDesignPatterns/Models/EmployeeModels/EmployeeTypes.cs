using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystemDesignPatterns.Models.EmployeeModels
{
    public class EmployeeTypes
    {
        //[ForeignKey("EmployeeTypeId")]
       // [Key]
        public int EmployeeTypesId { get; set; }
        public string EmpType { get; set; }


        //public virtual Employee Employee { get; set; }
    }
}
