using System;
using System.Collections.Generic;

#nullable disable

namespace BookTable_Core_Asp.Net.Models
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public long? Salary { get; set; }
        public int? DeptId { get; set; }
        public string Address { get; set; }
    }
}
