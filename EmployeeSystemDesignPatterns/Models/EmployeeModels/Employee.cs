using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystemDesignPatterns.Models.EmployeeModels
{
    public class Employee
    {
        
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string JobDescription { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public double HourlyPay { get; set; }

        [Required]
        public double Bonus { get; set; }

        public int EmployeeTypeId { get; set; }

        [ForeignKey("EmployeeTypeId")]
        public virtual EmployeeTypes EmployeeTypes { get; set; }
    }
}
